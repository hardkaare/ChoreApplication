using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreApplication
{
    /// <summary>
    /// Reocurring Chore. Inherits from the Chore class. Contains what time it's due and what days 
    /// it should occur on in a list. Contains a method to generate Concrete versions of the chore
    /// </summary>
    class Reocurring : Chore
    {
        #region Properties

        //What time of the day it should set the due time to when it generates Concrete Chores
        public string dueTime { get; protected set; }

        //What days it should generate a Concrete Chore
        public List<string> days { get; protected set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructs the chore. Passes variables to the Chore constructer. Sets due time and days.
        /// </summary>
        public Reocurring(string _name, string _desc, int _points, string _assignment, string _duetime, List<string> _days) : 
            base(_name, _desc, _points, _assignment)
        {
            dueTime = _duetime;
            days = _days;
        }

        #endregion

        #region Public helpers

        /// <summary>
        /// Override of ToString. 
        /// </summary>
        /// <returns>Returns a string representation of the properties of the object 
        /// and the associated Chore object</returns>
        public override string ToString()
        {
            //Formats the string with varables from this and base class
            var sum = string.Format("Chore: {0} \nDescription: {1} \nPoints: {2} \nAssignment: {3} " +
                "\nDue time: {4} \nDays: ",
                name, description, points, assignment, dueTime);

            //Adds each day to the list
            foreach (string day in days)
            {
                sum += "\n" + day;
            }
            return sum;
        }

        #endregion
    }
}
