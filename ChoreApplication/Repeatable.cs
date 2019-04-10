using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreApplication
{
    class Repeatable : Chore
    {
        public int limit { get; protected set; }
        public int completions { get; protected set; }

        public Repeatable(string _name, string _desc, int _points, string _assignment) : base(_name, _desc, _points, _assignment)
        {
            limit = 0;
            completions = 0;
        }

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
