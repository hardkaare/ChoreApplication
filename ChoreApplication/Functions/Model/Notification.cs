using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ChoreApplication.Model
{
    internal class Notification
    {
        #region Properties

        //The title of the notification
        public string Title { get; set; }

        // The description of the notification, everyone can get and set it. (reconsider this later).
        public string Description { get; set; }

        // The user who will recieve the notification. Everyone can set and get it, reconsider this later.
        public int UserID { get; set; }

        // The id for a specific notification object
        public int NotificationID { get; set; }

        #endregion Properties

        #region Constructors

        // Creates an object of the class Notification with the specified information entered in the constructor call.
        public Notification(string title, string description, int userID, int notificationID)
        {
            Title = title;
            Description = description;
            UserID = userID;
            NotificationID = notificationID;
        }

        #endregion Constructors

        #region Public Helpers

        public static void Insert(int userID, string title, string description)
        {
            var fulltitle = DateTime.Now.ToString(Properties.Settings.Default.TextDateFormat) + " - " + title;
            string query = string.Format("INSERT INTO dbo.notification VALUES ({0},'{1}','{2}')", userID, fulltitle, description);
            SqlCommand command = new SqlCommand(query, Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection);
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Close();
        }

        public static List<Notification> Load(string whereClause)
        {
            if (whereClause != "")
            {
                whereClause = " WHERE " + whereClause;
            }
            List<Notification> notifications = new List<Notification>();
            string query = string.Format("SELECT * FROM dbo.notification{0}", whereClause);
            SqlCommand command = new SqlCommand(query, Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection);
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string title = reader["title"].ToString();
                string description = reader["description"].ToString();
                int userID = (int)reader["user_id"];
                int notificationID = (int)reader["notification_id"];

                Notification notification = new Notification(title, description, userID, notificationID);
                notifications.Add(notification);
            }
            reader.Close();
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Close();
            return notifications;
        }

        public void Delete()
        {
            string query = string.Format("DELETE FROM dbo.notification WHERE notification_id={0}", NotificationID);
            SqlCommand command = new SqlCommand(query, Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection);
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Close();
        }

        public override string ToString()
        {
            return $"{UserID} recieved an notification with the description: {Description}.";
        }

        #endregion Public Helpers
    }
}