using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreApplication
{
    class ChildUser : User
    {
        #region Properties
        // Gets and sets the points for the ChildUser
        public int Points { get; set; }
        #endregion

        #region Constructors
        // Creates an object of the class ChildUser. 
        public ChildUser(string firstName, int pincode) : base(firstName, pincode)
        {
            Points = 0;
        }

        #endregion

        #region Public Helpers

        public override string ToString()
        {
            return $"{FirstName} has {Points} points.";
        }

        #endregion

        #region Private Helpers

        #endregion
    }

}
