using System;
using System.Collections.Generic;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChoreApplication
{
    class CheckTime
    {
        private List<ChildUser> _childList { get; set; }
        private List<Concrete> _concreteList { get; set; }
        private List<Repeatable> _repeatableList { get; set; }
        private List<Reocurring> _reocurringList { get; set; }
        private DateTime _tick { get; set; }

        public CheckTime()
        {
            CheckDB();
        }

        private void CheckDB()
        {
            //Initialize Lists
            _childList = ChildUser.Load("");
            _repeatableList = Repeatable.Load("");
            _reocurringList = Reocurring.Load("");
            _tick = LoadTick();

            //When it's a new day
            TimeSpan oneDay = DateTime.Now.Subtract(_tick);
            if (oneDay.TotalDays > 1)
            {
                UpdateDailyTick();
                ResetChores();
                GenerateConcreteChore();
                MessageBox.Show("It's a new day. Repeatable chores are reset and reocurring chores are generated");
            }

            //Check concrete chores
            foreach (ChildUser child in _childList)
            {
                _concreteList = Concrete.Load($"child_id={child.ChildID} AND [status]=1");
                foreach (Concrete chore in _concreteList)
                {
                    //If it's past it's due date
                    if (chore.DueDate < DateTime.Now)
                    {
                        child.Points -= chore.Points;
                        child.Update();
                        chore.Status = 4;
                        chore.ApprovalDate = DateTime.ParseExact(DateTime.Now.ToString(Properties.Settings.Default.LongDateFormat), Properties.Settings.Default.LongDateFormat, null);
                        chore.Update();
                        Notification.Insert(child.ID, $"A chore has gone over due", $"You did not complete {chore.Name} in time.");
                    }
                    //If theres less than an hour to the chore being due
                    
                    else if (CheckDueTime(chore.DueDate) && (chore.Reminder == 0))
                    {
                        Notification.Insert(child.ID, $"A chore is due within the hour", $"{chore.Name}. Due today at {chore.DueDate.TimeOfDay}");
                        chore.Reminder = 1;
                        chore.Update();
                        MessageBox.Show("A notification was created for because the following chore is due within 1 hour: " + chore.ToString());
                    }
                }
            }
            Thread.Sleep(60000); //Lav om til 60 eller 360
            CheckDB();
        }

        private void ResetChores()
        {
            foreach (var chore in _repeatableList)
            {
                chore.Completions = 0;
                chore.Update();
            }
        }

        private void GenerateConcreteChore()
        {
            foreach (var chore in _reocurringList)
            {
                foreach (var day in chore.Days)
                {
                    if (day == DateTime.Now.DayOfWeek.ToString())
                    {
                        Concrete.Insert(chore.Name, chore.Description, chore.Points, chore.Assignment, chore.DueTime, "reoc");
                    }
                }
            }
        }

        private DateTime LoadTick()
        {
            string query = $"SELECT * FROM dbo.checkTime";
            DateTime dailyTick = DateTime.ParseExact("01-01-2000 00:00", Properties.Settings.Default.LongDateFormat, null);
            DatabaseFunctions.DatabaseConnection.Open();
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.DatabaseConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dailyTick = DateTime.ParseExact(reader["dailyTick"].ToString(), Properties.Settings.Default.LongDateFormat, null);
            }
            DatabaseFunctions.DatabaseConnection.Close();
            return dailyTick;
        }

        private bool CheckDueTime(DateTime dueTime)
        {
            bool due = false;
            TimeSpan elapsedTime = dueTime - DateTime.Now;
            if (elapsedTime.TotalHours < 1)
            {
                due = true;
            }
            return due;
        }

        private static void UpdateDailyTick()
        {
            string query = $"UPDATE dbo.checkTime SET dailyTick = '{DateTime.Now.Date.ToShortDateString() + " 05:00"}'";
            DatabaseFunctions.DatabaseConnection.Open();
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.DatabaseConnection);
            cmd.ExecuteNonQuery();
            DatabaseFunctions.DatabaseConnection.Close();
        }
    }
}
