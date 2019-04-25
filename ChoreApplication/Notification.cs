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

        #endregion

        #region Constructors

        // Creates an object of the class Notification with the specified information entered in the constructor call.
        public Notification(string title, string description, int userId)
        {
            Title = title;
            Description = description;
            UserId = userId;
        }
        #endregion

        #region Public Helpers
        public static void Insert(int userId, string title, string description)
        {
            string query4 = string.Format("INSERT INTO dbo.notification VALUES ({0},'{1}','{2}')", userId, title, description);
            SqlCommand cmd = new SqlCommand(query4, DatabaseFunctions.dbConn);
            cmd.ExecuteNonQuery();
       
        }

        //public void CreateNotification(int type, int userId)
        //{
            

        //    switch (type)
        //    {
        //        // Reward Created.
        //        case 1:
        //            var rewards = Reward.Load("");
        //            break;
        //        // Reward Claimed.
        //        case 2:
        //            Insert(1, $" ({DateTime.Now}) Reward claimed", "");
        //            break;
        //        // Chore Completed.
        //        case 3:
        //            Insert(1, $" ({DateTime.Now}) Chore completed", "");
        //            break;
        //        // Chore Denied.
        //        case 4:
        //            Insert(userId, $" ({DateTime.Now}) Chore denied", "");
        //            break;
        //        // Chore Approved. 
        //        case 5:
        //            Insert(userId, $" ({DateTime.Now}) Chore approved", "");
        //            break;
        //        // Chore Overdue. 
        //        case 6:
        //            Insert(userId, $" ({DateTime.Now}) Chore overdue", "");
        //            break;
        //        // Chore reminder. 
        //        case 7:
        //            Insert(userId, $" ({DateTime.Now}) Chore available", "");
        //            break;
        //        // Due date reminder. 
        //        case 8:
        //            Insert(userId, $" ({DateTime.Now}) Attention: Chore due", "");
        //            break;
        //        // Executes if none of the above cases are met. 
        //        default:
        //            throw new Exception("Could not recognize the type of notification.");
        //    }
        //}


      

        public override string ToString()
        {
            return $"{UserId} recieved an notification with the description: {Description}.";
        }

        #endregion

        #region Private Helpers

        #endregion


    }


}
