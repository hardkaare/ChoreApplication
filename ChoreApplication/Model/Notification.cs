using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ChoreApplication.Model
{
    /// <summary>
    /// Class for notifications to Users. Contains methods to insert, load and delete in DB
    /// </summary>
    internal class Notification
    {
        #region Properties

        //The title of the notification
        public string Title { get; private set; }

        // The description of the notification
        public string Description { get; private set; }

        // The user who will recieve the notification
        private int Assignment { get; set; }

        // The id for a specific notification object
        private int NotificationID { get; set; }

        #endregion Properties

        #region Constructors

        // Creates an object of the class Notification with the specified information entered in the constructor call.
        public Notification(string title, string description, int userID, int notificationID)
        {
            Title = title;
            Description = description;
            Assignment = userID;
            NotificationID = notificationID;
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Inserts a notification in the DB
        /// </summary>
        public static void Insert(int userID, string title, string description)
        {
            //Sets the title of the notification based on time of creation
            var fulltitle = DateTime.Now.ToString(Properties.Settings.Default.TextDateFormat) + " - " + title;

            //Creates a query that inserts into notification
            string query = string.Format("INSERT INTO dbo.notification VALUES ({0},'{1}','{2}')", userID, fulltitle, description);
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the command
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Loads all notifications to a list. Can add an optional where clause to only load some of the notifications
        /// </summary>
        /// <param name="whereClause">String with the optional where clause</param>
        public static List<Notification> Load(string whereClause)
        {
            //Checks if the where clause is empty, and if not adds WHERE in front of it
            if (whereClause != "")
            {
                whereClause = " WHERE " + whereClause;
            }

            //Declares the returned list
            List<Notification> notifications = new List<Notification>();

            //Creates a query that selects all data from notification
            string query = string.Format("SELECT * FROM dbo.notification{0}", whereClause);
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the command
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            SqlDataReader reader = command.ExecuteReader();

            //Reads all loaded notifications and add them to the list
            while (reader.Read())
            {
                string title = reader["title"].ToString();
                string description = reader["description"].ToString();
                int userID = (int)reader["user_id"];
                int notificationID = (int)reader["notification_id"];

                //Creates a notification object based on the data and adds it to the list
                Notification notification = new Notification(title, description, userID, notificationID);
                notifications.Add(notification);
            }

            //Clean up and return
            reader.Close();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
            return notifications;
        }

        //Deletes the notification with this objects ID from DB
        public void Delete()
        {
            //Creates the delete wuery
            string query = string.Format("DELETE FROM dbo.notification WHERE notification_id={0}", NotificationID);
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the query
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// ToString override. Mainly used for testing purposes
        /// </summary>
        /// <returns>String representation of the notification</returns>
        public override string ToString()
        {
            return $"{Assignment} recieved an notification with the description: {Description}.";
        }

        #endregion
    }
}