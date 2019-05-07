using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChoreApplication
{
    class SystemFunctions
    {
        private static string dateFormatString { get; set; } = "dd-MM-yyyy HH:mm";
        private const int WithinOneHour = 60;
        private static DateTime TimeNow = DateTime.ParseExact(DateTime.Now.ToString(dateFormatString), dateFormatString, null);
        private static TimeSpan _StartTimeSpan;

        private List<ChildUser> childs = ChildUser.Load("u.user_id = 3");

        public SystemFunctions()
        {
            CheckTime(childs[0]);

        }
        public static void CheckTime(ChildUser c)
        {
            _StartTimeSpan = TimeSpan.Zero;
            var PeriodTimeSpan = TimeSpan.FromHours(1);//1 tick i timen
            var timer = new System.Threading.Timer((e) =>
            {
                TimeSpan oneDay = TimeNow - LoadTicks()[1];

                if (oneDay.TotalDays > 1)
                {
                    //UpdateDailyTick();
                    //MessageBox.Show($"{DateTime.Now.Day}");
                }

                if (!CheckDueTime(LoadTicks()[0], TimeNow))
                {
                    UpdateLastTick();
                    foreach (var chore in Concrete.Load($"ch.child_id ={c.ChildId} AND co.status = 1"))
                    {
                        if (chore.DueDate < TimeNow)
                        {
                            c.Points -= chore.Points;
                            c.Update();
                            chore.Status = 4;
                            chore.ApprovalDate = DateTime.ParseExact(DateTime.Now.ToString(dateFormatString), dateFormatString, null);
                            chore.Update();
                            Notification.Insert(c.Id, $"A chore has gone over due", $"You did not complete {chore.Name}.");
                        }
                        if (CheckDueTime(TimeNow, chore.DueDate))
                        {
                            Notification.Insert(c.Id, $"A chore is due in one hour", $"{chore.Name}. Due today at {chore.DueDate.TimeOfDay}");
                        }
                    }
                }
            }, null, _StartTimeSpan, PeriodTimeSpan);
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
            DateTime tickTime = DateTime.ParseExact("01-01-2000 00:00", dateFormatString, null);
            DateTime dailyTick = DateTime.ParseExact("01-01-2000 00:00", dateFormatString, null);
            DatabaseFunctions.DbConn.Open();
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.DbConn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tickTime = DateTime.ParseExact(reader["lastTick"].ToString(), dateFormatString, null);
                dailyTick = DateTime.ParseExact(reader["dailyTick"].ToString(), dateFormatString, null);
                dateTimes.Add(tickTime);
                dateTimes.Add(dailyTick);
            }

            DatabaseFunctions.DbConn.Close();
            return dateTimes;
        }
        private static void UpdateLastTick()
        {
            string query = $"UPDATE dbo.checkTime SET lastTick = '{DateTime.Now.ToString(dateFormatString)}'";
            DatabaseFunctions.DbConn.Open();
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.DbConn);
            cmd.ExecuteNonQuery();
            DatabaseFunctions.DbConn.Close();
        }
        //private static void UpdateDailyTick()
        //{
        //    string query = $"UPDATE dbo.checkTime SET dailyTick = '{DateTime.Now.Date.ToString() + " 06:00"}'";
        //    DatabaseFunctions.DbConn.Open();
        //    SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.DbConn);
        //    cmd.ExecuteNonQuery();
        //    DatabaseFunctions.DbConn.Close();
        //}
    }
}
