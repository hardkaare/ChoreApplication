﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreApplication
{
    /// <summary>
    /// Concrete chores. Inherits from the Chore class. Contains due date of the chore, the status of the chore
    /// and the date of approval
    /// </summary>
    class Concrete : Chore
    {
        #region Properties

        //Date and time of when the chore is due
        private string dueDate { get; set; }
        //Status of the chore. Can be active, approval pending, approved and overdue
        private string status { get; set; }
        //Date of approval. Empty if not approved yet
        private string approvalDate { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Sets the properties of the concrete chore and creates and constructs a chore
        /// </summary>
        /// <param name="_name">Name of the chore</param>
        /// <param name="_desc">Description of the chore</param>
        /// <param name="_points">How many points are earned by completing the chore</param>
        /// <param name="_assignment">Who the chore is assigned to</param>
        /// <param name="_dueDate">When the chore is due</param>
        /// <param name="_status">What state the chore is in. Can be active, approval pending, approved and overdue</param>
        /// <param name="_approvalDate">What date the chore is approved. Empty string if not approved</param>
        public Concrete(string _name, string _desc, int _points, string _assignment, string _dueDate, string _status, string _approvalDate) : 
            base(_name, _desc, _points, _assignment)
        {
            dueDate = _dueDate;
            status = _status;
            approvalDate = _approvalDate;
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
                "\nDue date: {4} \nStatus: {5} \nDate of approval: {6}",
                name, description, points, assignment, dueDate, status, approvalDate);
        }
        #endregion

    }
}