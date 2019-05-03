using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChoreApplication
{
    /// <summary>
    /// Class for chore objects. Contains name of the chore, description of it, how many points it gives and 
    /// who it's assigned to. 
    /// </summary>
    public abstract class Chore
    {
        #region Properties

        //ID of the chore
        public int ID { get; protected set; }
        //Name of the chore
        public string Name { get; set; }
        //Description of how to do the chore
        public string Description { get; set; }
        //How many points is earned by completing the chore
        public int Points { get; set; }
        //Who the chore's assigned to
        public int Assignment { get; set; }

        #endregion

        #region Constructor


        /// <summary>
        /// Constructor that sets all properties for the class
        /// </summary>
        /// <param name="_name">Name of the chore</param>
        /// <param name="_desc">Description of the chore</param>
        /// <param name="_points">Points earned by completing the chore</param>
        /// <param name="_assignment">Who the chore is assigned to</param>
        public Chore(int _id, string _name, string _desc, int _points, int _assignment)
        {
            ID = _id;
            Name = _name;
            Description = _desc;
            Points = _points;
            Assignment = _assignment;
        }

        #endregion

        #region Public helpers

        //ToString override that lists all properties of the chore
        public override string ToString()
        {
            return string.Format("Chore: {0} | Description: {1} | Points: {2} | Assignment: {3}", 
                Name, Description, Points, Assignment);
        }

        public void Delete()
        {
            //Formatting the queries to chore table and creating the SqlCommand for the first query
            string query = string.Format("DELETE FROM chore WHERE chore_id={0}", ID);
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.dbConn);

            //Opens connection to the DB
            DatabaseFunctions.dbConn.Open();

            //Executes the SqlCommand
            cmd.ExecuteNonQuery();

            //Closes connection to DB
            DatabaseFunctions.dbConn.Close();
        }

        #endregion

        #region Private helpers

        #endregion
    }
}
