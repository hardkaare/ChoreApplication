using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
        public int completions { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Passes variables to construct the chore. Sets limit. Sets completions to 0
        /// </summary>
        public Repeatable(int _id, string _name, string _desc, int _points, int _assignment, int _limit, int _completions) : 
            base(_id, _name, _desc, _points, _assignment)
        {
            limit = _limit;
            completions = _completions;
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
                "\nLimit: {4} \nCompletions: {5}",
                name, description, points, assignment, limit, completions);
        }

        public static void Insert(int assignment, string name, string desc, int points, int limit)
        {
            //Formatting the query to chore table and creating the SqlCommand
            string query = string.Format("INSERT INTO dbo.chore" +
                "(child_id, name, description, points) OUTPUT inserted.chore_id VALUES " +
                "('{0}', '{1}', '{2}', '{3}')", assignment, name, desc, points);
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.dbConn);

            //Opens connection to the DB
            DatabaseFunctions.dbConn.Open();

            //Executes the query to chore table and returns the chore_id inserted
            int id = (int)cmd.ExecuteScalar();

            //Formatting the query to concrete_chore table, creating the SqlCommand and executing it
            string query2 = string.Format("INSERT INTO dbo.repeatable_chore " +
                "VALUES ({0}, {1}, {2})", id, limit, 0);
            SqlCommand cmd2 = new SqlCommand(query2, DatabaseFunctions.dbConn);
            cmd2.ExecuteNonQuery();

            //Closes connection to DB
            DatabaseFunctions.dbConn.Close();
        }

        public void Update()
        {
            //Formatting the queries to chore table and creating the SqlCommand for the first query
            string query = string.Format("UPDATE repeatable_chore SET " +
                "limit={0}, completions={1} WHERE chore_id={2}",
                limit, completions, ID);
            string query2 = string.Format("UPDATE chore SET " +
                "child_id={0}, name='{1}', description='{2}', points={3} WHERE chore_id={4}",
                assignment, name, description, points, ID);
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.dbConn);

            //Opens connection to the DB
            DatabaseFunctions.dbConn.Open();

            //Executes the SqlCommands
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(query2, DatabaseFunctions.dbConn);
            cmd.ExecuteNonQuery();

            //Closes connection to DB
            DatabaseFunctions.dbConn.Close();
        }

        public static List<Repeatable> LoadWhere(string whereClause)
        {
            //Checks if string is empty. If not adds where in front
            if (whereClause != "")
            {
                whereClause = " WHERE " + whereClause;
            }

            //Initializes a list of concrete chores
            List<Repeatable> result = new List<Repeatable>();

            //Makes a string query and opens the connection to DB
            string query = string.Format(
                "SELECT ch.chore_id, ch.name, ch.description, ch.points, ch.child_id, rep.limit, " +
                "rep.completions FROM chore AS ch INNER JOIN repeatable_chore AS rep ON " +
                "ch.chore_id=rep.chore_id{0}", whereClause);
            DatabaseFunctions.dbConn.Open();

            //Creates the SqlCommand and executes it
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.dbConn);
            SqlDataReader reader = cmd.ExecuteReader();

            //Reads all lines in the datareader
            while (reader.Read())
            {
                //Declares a Concrete object and casts the data from the datareader into variables
                Repeatable currentChore;
                int choreID = (int)reader[0];
                string name = reader[1].ToString();
                string description = reader[2].ToString();
                int points = (int)reader[3];
                int assignment = (int)reader[4];
                int limit = (int)reader[5];
                int completions = (int)reader[6];

                //Initializes the choreobject with the parameters and adds it to the list
                currentChore = new Repeatable(choreID, name, description, points, assignment, limit, completions);
                result.Add(currentChore);
            }
            reader.Close();
            DatabaseFunctions.dbConn.Close();
            return result;
        }

        #endregion
    }
}
