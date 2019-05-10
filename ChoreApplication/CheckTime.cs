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
        private List<DateTime> _ticks { get; set; }

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
            _ticks = LoadTicks();

            //When it's a new day
            TimeSpan oneDay = DateTime.Now.Subtract(_ticks[1]);
            if (oneDay.TotalDays > 1)
            {
                UpdateDailyTick();
                ResetChores();
                GenerateConcreteChore();
                MessageBox.Show("It's a new day. Repeatable chores are reset and reocurring chores are generated");
            }

            //Check overdue chores
            foreach (ChildUser child in _childList)
            {
                _concreteList = Concrete.Load($"child_id={child.ChildID}");
                foreach (Chore chore in _concreteList)
                {

                }
            }

            Thread.Sleep(5000); //Lav om til 60 eller 360
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

        //-------------------------------------------------------------------------------------------------------------------------

        private const int WithinOneHour = 60;
        private DateTime _timeNow = DateTime.ParseExact(DateTime.Now.ToString(Properties.Settings.Default.LongDateFormat), Properties.Settings.Default.LongDateFormat, null);
        private TimeSpan _startTimeSpan;

        public void CheckDB1(List<ChildUser> childList)
        {
            _startTimeSpan = TimeSpan.Zero;
            var PeriodTimeSpan = TimeSpan.FromHours(1);//1 tick i timen
            var timer = new System.Threading.Timer((e) =>
            {
                TimeSpan oneDay = _timeNow - LoadTicks()[1];
                if (oneDay.TotalDays > 1)
                {
                    UpdateDailyTick();
                    ResetChores();
                    GenerateConcreteChore();
                }

                if (!CheckDueTime(LoadTicks()[0], _timeNow))
                {
                    UpdateLastTick();
                    foreach (ChildUser child in childList)
                    {
                        foreach (var chore in Concrete.Load($"ch.child_id ={child.ChildId} AND co.status = 1"))
                        {
                            if (chore.DueDate < _timeNow)
                            {
                                child.Points -= chore.Points;
                                child.Update();
                                chore.Status = 4;
                                chore.ApprovalDate = DateTime.ParseExact(DateTime.Now.ToString(Properties.Settings.Default.LongDateFormat), Properties.Settings.Default.LongDateFormat, null);
                                chore.Update();
                                Notification.Insert(child.ID, $"A chore has gone over due", $"You did not complete {chore.Name} in time.");
                            }
                            else if (CheckDueTime(_timeNow, chore.DueDate))
                            {
                                Notification.Insert(child.ID, $"A chore is due within the hour", $"{chore.Name}. Due today at {chore.DueDate.TimeOfDay}");
                            }
                        }
                    }
                }
            }, null, _startTimeSpan, PeriodTimeSpan);
        }

        private static bool CheckDueTime(DateTime timeNow, DateTime dueTime)
        {
            TimeSpan elapsedTime = dueTime - timeNow;
            return (elapsedTime.TotalSeconds > -1 && elapsedTime.TotalSeconds < 0) // up to 1 second before
                   || (elapsedTime.TotalSeconds >= 0 && Math.Floor(elapsedTime.TotalSeconds) <= WithinOneHour * 60); // up to 15 minutes later
        }

        private static List<DateTime> LoadTicks()
        {
            string query = $"SELECT * FROM dbo.checkTime";
            List<DateTime> dateTimes = new List<DateTime>();
            DateTime tickTime = DateTime.ParseExact("01-01-2000 00:00", Properties.Settings.Default.LongDateFormat, null);
            DateTime dailyTick = DateTime.ParseExact("01-01-2000 00:00", Properties.Settings.Default.LongDateFormat, null);
            DatabaseFunctions.DatabaseConnection.Open();
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.DatabaseConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tickTime = DateTime.ParseExact(reader["lastTick"].ToString(), Properties.Settings.Default.LongDateFormat, null);
                dailyTick = DateTime.ParseExact(reader["dailyTick"].ToString(), Properties.Settings.Default.LongDateFormat, null);
                dateTimes.Add(tickTime);
                dateTimes.Add(dailyTick);
            }
            DatabaseFunctions.DatabaseConnection.Close();
            return dateTimes;
        }

        private static void UpdateLastTick()
        {
            string query = $"UPDATE dbo.checkTime SET lastTick = '{DateTime.Now.ToString(Properties.Settings.Default.LongDateFormat)}'";
            DatabaseFunctions.DatabaseConnection.Open();
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.DatabaseConnection);
            cmd.ExecuteNonQuery();
            DatabaseFunctions.DatabaseConnection.Close();
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
