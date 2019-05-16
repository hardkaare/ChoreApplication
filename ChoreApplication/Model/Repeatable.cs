using System.Collections.Generic;
using System.Data.SqlClient;

namespace ChoreApplication.Model
{
    /// <summary>
    /// Inherits from the Chore class. Adds properties Limit and Completions. 
    /// Contains methods for inserting, loading and updating the chore in DB.
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
        /// Sets the properties of the concrete chore and constructs a chore. 
        /// Passes id, name, description, points and assignment to base.
        /// </summary>
        public Repeatable(int id, string name, string description, int points, int assignment, int limit, int completions) :
            base(id, name, description, points, assignment)
        {
            Limit = limit;
            Completions = completions;
        }

        #endregion Constructor

        #region Public Methods

        /// <summary>
        /// Inserts a new chore into the DB. Inserts into chore table and concrete_chore with the foreign key inserted into chore table
        /// </summary>
        public static void Insert(int assignment, string name, string description, int points, int limit)
        {
            //Creates a query that inserts data into chore and returns the inserted chore_id
            string query = string.Format("INSERT INTO dbo.chore" +
                "(child_id, name, description, points) OUTPUT inserted.chore_id VALUES " +
                "('{0}', '{1}', '{2}', '{3}')", assignment, name, description, points);
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the query to chore table and sets id to the inserted chore_id
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            int id = (int)command.ExecuteScalar();

            //Creates a query that inserts data into repeatable_chore
            string query2 = string.Format("INSERT INTO dbo.repeatable_chore " +
                "VALUES ({0}, {1}, {2})", id, limit, 0);
            SqlCommand command2 = new SqlCommand(query2, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the command
            command2.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Updates the DB with the information in the Repeatable Chore targeted by the method
        /// </summary>
        public void Update()
        {
            //Creates queries that updates the repeatable_chore and chore entries with this chore's ID
            string query = string.Format("UPDATE repeatable_chore SET " +
                "limit={0}, completions={1} WHERE chore_id={2}",
                Limit, Completions, ID);
            string query2 = string.Format("UPDATE chore SET " +
                "child_id={0}, name='{1}', description='{2}', points={3} WHERE chore_id={4}",
                Assignment, Name, Description, Points, ID);
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the queries
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();
            command = new SqlCommand(query2, Functions.DatabaseFunctions.DatabaseConnection);
            command.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Loads Repeatable Chores from the DB. Can load with a where clause in the query
        /// </summary>
        /// <param name="whereClause">String with the where clause. If empty the method loads
        /// all repeatable chores</param>
        /// <returns>List of loaded Concrete Chores</returns>
        public static List<Repeatable> Load(string whereClause)
        {
            //Checks if string is empty. If not adds WHERE in front if it
            if (whereClause != "")
            {
                whereClause = " WHERE " + whereClause;
            }

            //Declares a list of Concrete Chores
            List<Repeatable> result = new List<Repeatable>();

            //Creates a query that selects columns from repeatable_chore inner joined with chore based on chore_id
            string query = string.Format(
                "SELECT ch.chore_id, ch.name, ch.description, ch.points, ch.child_id, rep.limit, " +
                "rep.completions FROM chore AS ch INNER JOIN repeatable_chore AS rep ON " +
                "ch.chore_id=rep.chore_id{0}", whereClause);

            //Executes the query
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            SqlDataReader reader = command.ExecuteReader();

            //Reads all lines in the datareader
            while (reader.Read())
            {
                //Declares a Repeatable object and casts the data from the datareader into variables
                Repeatable currentChore;
                int choreID = (int)reader[0];
                string name = reader[1].ToString();
                string description = reader[2].ToString();
                int points = (int)reader[3];
                int assignment = (int)reader[4];
                int limit = (int)reader[5];
                int completions = (int)reader[6];

                //Initializes the Repeatable object with the parameters and adds it to the list
                currentChore = new Repeatable(choreID, name, description, points, assignment, limit, completions);
                result.Add(currentChore);
            }

            //Clean up and return
            reader.Close();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
            return result;
        }

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

        #endregion Public methods
    }
}