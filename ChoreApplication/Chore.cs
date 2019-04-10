using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreApplication
{
    /// <summary>
    /// Class for chore objects. Contains name of the chore, description of it, how many points it gives and 
    /// who it's assigned to. 
    /// </summary>
    class Chore
    {
        #region Properties

        //Name of the chore
        private string name { get; set; }
        //Description of how to do the chore
        private string description { get; set; }
        //How many points is earned by completing the chore
        private int points { get; set; }
        //Who the chore's assigned to
        private string assignment { get; set; }

        #endregion

        #region Constructor


        /// <summary>
        /// Constructor that sets all properties for the class
        /// </summary>
        /// <param name="_name">Name of the chore</param>
        /// <param name="_desc">Description of the chore</param>
        /// <param name="_points">Points earned by completing the chore</param>
        /// <param name="_assignment">Who the chore is assigned to</param>
        public Chore(string _name, string _desc, int _points, string _assignment)
        {
            name = _name;
            description = _desc;
            points = _points;
            assignment = _assignment;
        }

        #endregion

        #region Public helpers

        //ToString override that lists all properties of the chore
        public override string ToString()
        {
            return string.Format("Chore: {0} | Description: {1} | Points: {2} | Assignment: {3}", 
                name, description, points, assignment);
        }

        #endregion

        #region Private helpers

        #endregion
    }
}
