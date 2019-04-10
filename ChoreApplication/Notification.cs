using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreApplication
{
    class Notification
    {
        #region Properties

        // The description of the notification, everyone can get and set it. (reconsider this later).
        public string Description { get; set; }

        // The user who will recieve the notification. Everyone can set and get it, reconsider this later.
        public string Assignment { get; set; }

        #endregion

        #region Constructors

        // Creates an object of the class Notification with the specified information entered in the constructor call.
        public Notification(string description, string assignment)
        {
            Description = description;
            Assignment = assignment;
        }
        #endregion

        #region Public Helpers

        public override string ToString()
        {
            return $"{Assignment} recieved an notification with the description: {Description}.";
        }

        #endregion

        #region Private Helpers

        #endregion


    }


}
