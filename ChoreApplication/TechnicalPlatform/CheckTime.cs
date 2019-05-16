﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Data.SqlClient;

namespace ChoreApplication.TechnicalPlatform
{
    class CheckTime
    {
        private List<Model.ChildUser> _childList { get; set; }
        private List<Model.Concrete> _concreteList { get; set; }
        private List<Model.Repeatable> _repeatableList { get; set; }
        private List<Model.Reoccurring> _reocurringList { get; set; }
        private DateTime _tick { get; set; }

        public CheckTime()
        {
            CheckDB();
        }

        private void CheckDB()
        {
            //Initialize Lists
            _childList = Model.ChildUser.Load("");
            _repeatableList = Model.Repeatable.Load("");
            _reocurringList = Model.Reoccurring.Load("");
            _tick = LoadTick();

            //When it's a new day
            TimeSpan oneDay = DateTime.Now.Subtract(_tick);
            if (oneDay.TotalDays > 1)
            {
                UpdateDailyTick();
                ResetChores();
                GenerateConcreteChore();
            }

            //Check concrete chores
            foreach (Model.ChildUser child in _childList)
            {
                _concreteList = Model.Concrete.Load($"child_id={child.ChildID} AND [status]=1");
                foreach (Model.Concrete chore in _concreteList)
                {
                    //If it's past it's due date
                    if (chore.DueDate < DateTime.Now)
                    {
                        child.Points -= chore.Points;
                        child.Update();
                        chore.Status = 4;
                        chore.ApprovalDate = DateTime.ParseExact(DateTime.Now.ToString(Properties.Settings.Default.LongDateFormat), Properties.Settings.Default.LongDateFormat, null);
                        chore.Update();
                        Model.Notification.Insert(child.ID, $"A chore has gone over due", $"You did not complete {chore.Name} in time.");
                    }
                    
                    //If theres less than an hour to the chore being due
                    else if (CheckDueTime(chore.DueDate) && (chore.Reminder == 0))
                    {
                        Model.Notification.Insert(child.ID, $"A chore is due within the hour", $"{chore.Name}. Due today at {chore.DueDate.TimeOfDay}");
                        chore.Reminder = 1;
                        chore.Update();
                    }
                }
            }
            Thread.Sleep(60000); //Lav om til 60
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
                        Model.Concrete.Insert(chore.Name, chore.Description, chore.Points, chore.Assignment, chore.DueTime, "reoc");
                    }
                }
            }
        }

        private DateTime LoadTick()
        {
            string query = $"SELECT * FROM dbo.checkTime";
            DateTime dailyTick = DateTime.ParseExact("01-01-2000 00:00", Properties.Settings.Default.LongDateFormat, null);
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            SqlCommand cmd = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dailyTick = DateTime.ParseExact(reader["dailyTick"].ToString(), Properties.Settings.Default.LongDateFormat, null);
            }
            Functions.DatabaseFunctions.DatabaseConnection.Close();
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
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            SqlCommand cmd = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            cmd.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }
    }
}
