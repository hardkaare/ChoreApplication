using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreApplication
{
    /// <summary>
    /// Repeatable chores. Inherits from the Chore class. Contains the limit of times the chore can be completed
    /// a day and how many times it has been completed at the moment. Contains a method to generate 
    /// Concrete versions of the Chore
    /// </summary>
    class Repeatable : Chore
    {
        #region Properties

        //Number of times the chore can be completed a day
        public int limit { get; protected set; }

        //How many times it has been completed currently
        public int completions { get; protected set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Passes variables to construct the chore. Sets limit. Sets completions to 0
        /// </summary>
        public Repeatable(string _name, string _desc, int _points, string _assignment, int _limit) : 
            base(_name, _desc, _points, _assignment)
        {
            limit = _limit;
            completions = 0;
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
            return string.Format("Chore: {0} \nDescription: {1} \nPoints: {2} \nAssignment: {3} " +
                "\nLimit: {4} \nCompletions: {5}",
                name, description, points, assignment, limit, completions);
        }

        /// <summary>
        /// Used when a child completes a repeatable chore. Generates a Concrete Chore with the same name, 
        /// description and assignment. Diminishing returns on points are calculated and the state is 
        /// ApprovalPending by default
        /// </summary>
        public void GenerateConcreteChore()
        {
            //TODO
        }
        #endregion
    }
}
