using System;
using System.Collections.Generic;
using System.Threading;
using System.Data.SqlClient;

namespace ChoreApplication.TechnicalPlatform
{
    /// <summary>
    /// This class's purpose is to check the database and manage all time related fucntionality. 
    /// It is meant to run constantly on a server and not in the user's client. 
    /// The constructor calls a method that loops itself every minute after scanning the DB.
    /// </summary>
    class CheckTime
    {
        #region Properties

        //List of all ChildUsers from the DB
        private List<Model.ChildUser> _childList { get; set; }

        //List of Concrete Chores from the DB. Is loaded for each ChildUser
        private List<Model.Concrete> _concreteList { get; set; }

        //List of all Repeatable Chores from the DB
        private List<Model.Repeatable> _repeatableList { get; set; }

        //List of all Reoccurring Chores from the DB
        private List<Model.Reoccurring> _reocurringList { get; set; }

        //DateTime for last time the Repeatable chores was reset, Reoccurring Chores for the day was generated and daily notifications sent out
        private DateTime _tick { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Starts the loop checking the DB and calling relevant methods
        /// </summary>
        public CheckTime()
        {
            CheckDB();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Main loop that: 
        /// Initializes properties, 
        /// checks if it's a new day and resets Repeatable Chores and generates Reoccurring Chores if so,
        /// checks whether each ChildUser's chores are overdue and subtracts points from its account if so,
        /// checks whether each ChildUser's chores are due within an hour and generates a notification if so.
        /// </summary>
        private void CheckDB()
        {
            //Initialize Lists
            _childList = Model.ChildUser.Load("");
            _repeatableList = Model.Repeatable.Load("");
            _reocurringList = Model.Reoccurring.Load("");
            _tick = LoadTick();

            //Checks if it's more than a day since last resets and chores being generated. This happens at 05:00 each day.
            TimeSpan oneDay = DateTime.Now.Subtract(_tick);
            if (oneDay.TotalDays > 1)
            {
                //Updates daily_tick in DB to 05:00 this date
                UpdateDailyTick();

                //Resets Repeatable Chores
                ResetChores();

                //Generates Concrete Chores from Reoccurring Chores if they are to be done this day
                GenerateConcreteChore();
            }

            //Checks each ChildUser's Concrete Chores. Checks for overdue and if they are due within 1 hour
            foreach (Model.ChildUser child in _childList)
            {
                //Loads the ChildUser's Concrete Chores
                _concreteList = Model.Concrete.Load($"child_id={child.ChildID} AND [status]=1");

                //Checks each Concrete Chore
                foreach (Model.Concrete chore in _concreteList)
                {
                    // Checks if the Chore is past it's due date
                    if (chore.DueDate < DateTime.Now)
                    {
                        //Subtracks the Chore's points from the ChildUser's account and updates DB
                        child.Points -= chore.Points;
                        child.Update();

                        //Sets the Chore to overdue and the ApprovalDate to now. Updates the DB
                        chore.Status = 4;
                        chore.FinalDate = DateTime.ParseExact(DateTime.Now.ToString(Properties.Settings.Default.LongDateFormat), Properties.Settings.Default.LongDateFormat, null);
                        chore.Update();

                        //Creates a notification for the ChildUser
                        Model.Notification.Insert(child.ID, $"A chore has gone over due", $"You did not complete {chore.Name} in time.");
                    }
                    
                    //Checks if theres less than an hour to the Chore is due AND there hasn't been sent a notification to the ChildUser for it
                    else if (CheckDueTime(chore.DueDate) && (chore.Reminder == 0))
                    {
                        //Creates a notification for the ChildUser
                        Model.Notification.Insert(child.ID, $"A chore is due within the hour", $"{chore.Name}. Due today at {chore.DueDate.TimeOfDay}");

                        //Sets the reminder column to 1 for the Chore
                        chore.Reminder = 1;
                        chore.Update();
                    }
                }
            }

            //Sleeps for 1 minute and calls this method
            Thread.Sleep(60000);
            CheckDB();
        }

        /// <summary>
        /// Resets all Repeatable Chores in the DB
        /// </summary>
        private void ResetChores()
        {
            //Set each Repeatable Chore's Completions to 0 and updates the DB
            foreach (var chore in _repeatableList)
            {
                chore.Completions = 0;
                chore.Update();
            }
        }

        /// <summary>
        /// Generates a Concrete Chore for all Reoccurring Chores that are due today
        /// </summary>
        private void GenerateConcreteChore()
        {
            //Checks each Reoccurring Chore
            foreach (var chore in _reocurringList)
            {
                //Checks each day the Reoccurring Chore is due
                foreach (var day in chore.Days)
                {
                    //If this day is this day of the week
                    if (day == DateTime.Now.DayOfWeek.ToString())
                    {
                        //Creates a Concrete Chore with the same information as the Reoccurring Chore. The DueTime in DB is only a timestamp,
                        //but when it's loaded into the program to a DateTime object it's date set to today's date
                        Model.Concrete.Insert(chore.Name, chore.Description, chore.Points, chore.Assignment, chore.DueTime, "reoc");
                    }
                }
            }
        }

        /// <summary>
        /// Loads the daily_tick from DB and returns it as a DateTime
        /// </summary>
        private DateTime LoadTick()
        {
            //Creates a query that selects the daily_tick from DB
            string query = $"SELECT * FROM dbo.checkTime";

            //Initializes the returned DateTime
            DateTime dailyTick = DateTime.ParseExact("01-01-2000 00:00", Properties.Settings.Default.LongDateFormat, null);

            //Executes the query
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            SqlCommand cmd = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            //Reads all the loaded data. Only reads once due to the nature of the DB
            while (reader.Read())
            {
                //Sets dailyTick to the loaded data
                dailyTick = DateTime.ParseExact(reader["dailyTick"].ToString(), Properties.Settings.Default.LongDateFormat, null);
            }

            //Clean up and return
            Functions.DatabaseFunctions.DatabaseConnection.Close();
            return dailyTick;
        }

        /// <summary>
        /// Private helper that checks if a DateTime is within 1 hour of now
        /// </summary>
        /// <param name="dueTime">DateTime to check</param>
        /// <returns>Bool that is true if dueTime is within 1 hour of now</returns>
        private bool CheckDueTime(DateTime dueTime)
        {
            //Initializes the returned bool as false
            bool due = false;

            //Subtracts dueTime from now as a TimeSpan
            TimeSpan elapsedTime = dueTime - DateTime.Now;

            //If the timespan is less than 1 hour long sets due to true
            if (elapsedTime.TotalHours < 1)
            {
                due = true;
            }
            return due;
        }

        /// <summary>
        /// Private helper that updates the daily_tick to today. It sets the time to 05:00 so it's not pushed back slowly over time
        /// </summary>
        private static void UpdateDailyTick()
        {
            //Creates the query that updates dailyTick to today at 05:00
            string query = $"UPDATE dbo.checkTime SET dailyTick = '{DateTime.Now.Date.ToShortDateString() + " 05:00"}'";
            SqlCommand cmd = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the query
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            cmd.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        #endregion
    }
}
