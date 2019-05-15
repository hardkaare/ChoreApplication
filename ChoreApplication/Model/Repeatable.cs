using System.Collections.Generic;
using System.Data.SqlClient;

namespace ChoreApplication.Model
{
    /// <summary>
    /// Repeatable chores. Inherits from the Chore class. Contains the limit of times the chore can be completed
    /// a day and how many times it has been completed at the moment. Contains a method to generate
    /// Concrete versions of the Chore
    /// </summary>
    public class Repeatable : Chore
    {
        #region Properties

        //Number of times the chore can be completed a day
        public int Limit { get; set; }

        //How many times it has been completed currently
        public int Completions { get; set; }

        #endregion Properties

        #region Constructor

        /// <summary>
        /// Passes variables to construct the chore. Sets limit. Sets completions to 0
        /// </summary>
        public Repeatable(int id, string name, string description, int points, int assignment, int limit, int completions) :
            base(id, name, description, points, assignment)
        {
            Limit = limit;
            Completions = completions;
        }

        #endregion Constructor

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
                Name, Description, Points, Assignment, Limit, Completions);
        }

        public static void Insert(int assignment, string name, string description, int points, int limit)
        {
            //Formatting the query to chore table and creating the SqlCommand
            string query = string.Format("INSERT INTO dbo.chore" +
                "(child_id, name, description, points) OUTPUT inserted.chore_id VALUES " +
                "('{0}', '{1}', '{2}', '{3}')", assignment, name, description, points);
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);

            //Opens connection to the DB
            Functions.DatabaseFunctions.DatabaseConnection.Open();

            //Executes the query to chore table and returns the chore_id inserted
            int id = (int)command.ExecuteScalar();

            //Formatting the query to concrete_chore table, creating the SqlCommand and executing it
            string query2 = string.Format("INSERT INTO dbo.repeatable_chore " +
                "VALUES ({0}, {1}, {2})", id, limit, 0);
            SqlCommand command2 = new SqlCommand(query2, Functions.DatabaseFunctions.DatabaseConnection);
            command2.ExecuteNonQuery();

            //Closes connection to DB
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        public void Update()
        {
            //Formatting the queries to chore table and creating the SqlCommand for the first query
            string query = string.Format("UPDATE repeatable_chore SET " +
                "limit={0}, completions={1} WHERE chore_id={2}",
                Limit, Completions, ID);
            string query2 = string.Format("UPDATE chore SET " +
                "child_id={0}, name='{1}', description='{2}', points={3} WHERE chore_id={4}",
                Assignment, Name, Description, Points, ID);
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);

            //Opens connection to the DB
            Functions.DatabaseFunctions.DatabaseConnection.Open();

            //Executes the SqlCommands
            command.ExecuteNonQuery();
            command = new SqlCommand(query2, Functions.DatabaseFunctions.DatabaseConnection);
            command.ExecuteNonQuery();

            //Closes connection to DB
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        public static List<Repeatable> Load(string whereClause)
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
            Functions.DatabaseFunctions.DatabaseConnection.Open();

            //Creates the SqlCommand and executes it
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            SqlDataReader reader = command.ExecuteReader();

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
            Functions.DatabaseFunctions.DatabaseConnection.Close();
            return result;
        }

        #endregion Public methods
    }
}