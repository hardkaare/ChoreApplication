using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChoreApplication
{
    class Notification
    {
        #region Properties
        //The title of the notification
        public string Title { get; set; }

        // The description of the notification, everyone can get and set it. (reconsider this later).
        public string Description { get; set; }

        // The user who will recieve the notification. Everyone can set and get it, reconsider this later.
        public int UserId { get; set; }
        // The id for a specific notification object
        public int NotificationId { get; set; }
        #endregion
        #region Constructors

        // Creates an object of the class Notification with the specified information entered in the constructor call.
        public Notification(string title, string description, int userId, int notificationId)
        {
            Title = title;
            Description = description;
            UserId = userId;
            NotificationId = notificationId;
        }
        #endregion
        #region Public Helpers
        public static void Insert(int userId, string title, string description)
        {
            title += " - " + DateTime.Now.ToString("HH:mm d. MMMM");
            string query = string.Format("INSERT INTO dbo.notification VALUES ({0},'{1}','{2}')", userId, title, description);
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.DbConn);
            DatabaseFunctions.DbConn.Open();
            cmd.ExecuteNonQuery();
            DatabaseFunctions.DbConn.Close();
        }
        public static List<Notification> Load(string whereClause)
        {
            if (whereClause != "")
            {
                whereClause = " WHERE " + whereClause;
            }
            List<Notification> notifications = new List<Notification>();
            string query = string.Format("SELECT * FROM dbo.notification{0}", whereClause);
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.DbConn);
            DatabaseFunctions.DbConn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string title = reader["title"].ToString();
                string description = reader["description"].ToString();
                int userid = (int)reader["user_id"];
                int notificationId = (int)reader["notification_id"];
             
                Notification notification = new Notification(title, description, userid, notificationId);
                notifications.Add(notification);
            }
            reader.Close();
            DatabaseFunctions.DbConn.Close();
            return notifications;
        }
        public void Delete()
        {
            string query = string.Format("DELETE FROM dbo.notification WHERE notification_id={0}", NotificationId);
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.DbConn);
            DatabaseFunctions.DbConn.Open();
            cmd.ExecuteNonQuery();
            DatabaseFunctions.DbConn.Close();
        }
        public override string ToString()
        {
            return $"{UserId} recieved an notification with the description: {Description}.";
        }

        #endregion

        #region Private Helpers

        #endregion


    }


}
