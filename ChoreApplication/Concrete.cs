using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
        private DateTime DueDate { get; set; }
        //Status of the chore. Can be active, approval pending, approved and overdue
        private string status { get; set; }
        //Date of approval. Empty if not approved yet
        private DateTime approvalDate { get; set; }

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
        public Concrete(string _name, string _desc, int _points, string _assignment, DateTime _dueDate, string _status, DateTime _approvalDate) : 
            base(_name, _desc, _points, _assignment)
        {
            DueDate = _dueDate;
            status = _status;
            approvalDate = _approvalDate;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Override of ToString. 
        /// </summary>
        /// <returns>Returns a string representation of the properties of the object 
        /// and the associated Chore object</returns>
        public override string ToString()
        {
            return string.Format("Chore: {0} \nDescription: {1} \nPoints: {2} \nAssignment: {3} " +
                "\nDue date: {4} \nStatus: {5} \nDate of approval: {6}",
                name, description, points, assignment, DueDate, status, approvalDate);
        }

        public static void Insert(string name, string desc, int points, 
            int assignment, DateTime dueTime, string status, string type)
        {
            string query = string.Format("INSERT INTO dbo.concrete_chore" +
                "(due_date, status, approval_date, type) VALUES " +
                "('{0}', '{1}', NULL, '{2}')", dueTime, status, type);
            string query2 = string.Format("INSERT INTO dbo.chore" +
                "(child_id, name, description, points) VALUES " +
                "('{0}', '{1}', '{2}', '{3}')", assignment, name, desc, points);
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.dbConn);
            DatabaseFunctions.dbConn.Open();
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(query2, DatabaseFunctions.dbConn);
            cmd.ExecuteNonQuery();
            DatabaseFunctions.dbConn.Close();
        }

        #endregion
    }
}
