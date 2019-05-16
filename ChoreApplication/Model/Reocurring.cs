using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ChoreApplication.Model
{
    /// <summary>
    /// Inherits from the Chore class. Adds properties DueTime and Days. 
    /// Contains methods for inserting, loading and updating the chore in DB.
    /// </summary>
    public class Reoccurring : Chore
    {
        #region Properties

        //What time of the day it should set the due time to when it generates Concrete Chores
        public DateTime DueTime { get; set; }

        //What days it should generate a Concrete Chore
        public List<string> Days { get; set; }

        #endregion Properties

        #region Constructor

        /// <summary>
        /// Sets the properties of the reocurring chore and constructs a chore. 
        /// Passes id, name, description, points and assignment to base.
        /// </summary>
        public Reoccurring(int id, string name, string description, int points, int assignment, DateTime dueTime, List<string> days) :
            base(id, name, description, points, assignment)
        {
            DueTime = dueTime;
            Days = days;
        }

        #endregion Constructor

        #region Public Methods

        /// <summary>
        /// Inserts a new chore into the DB. Inserts into chore table and reocurring_chore with the foreign key inserted into chore table
        /// </summary>
        public static void Insert(int assignment, string name, string desc, int points,
            DateTime dueTime, List<string> days)
        {
            //Creates a query that inserts data into chore and returns the inserted chore_id
            string query = string.Format("INSERT INTO dbo.chore" +
                "(child_id, name, description, points) OUTPUT inserted.chore_id VALUES " +
                "('{0}', '{1}', '{2}', '{3}')", assignment, name, desc, points);
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);


            //Executes the query to chore table and sets id to the inserted chore_id
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            int id = (int)command.ExecuteScalar();

            //Creates a query that inserts data into concrete_chore
            string query2 = string.Format("INSERT INTO dbo.Reoccurring_chore (chore_id, due_time) " +
                "OUTPUT inserted.reo_id VALUES ({0}, '{1}')", id, dueTime.ToString("T"));
            SqlCommand command2 = new SqlCommand(query2, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the query to reocurring_chore table and sets id to the inserted reo_id
            id = (int)command2.ExecuteScalar();

            //Creates and executes an insert query for each day in the list
            string query3;
            SqlCommand command3;
            foreach (string day in days)
            {
                //Creates query string
                query3 = string.Format("INSERT INTO [days] (reo_id, day) VALUES ({0}, '{1}')", id, day);

                //Executes query
                command3 = new SqlCommand(query3, Functions.DatabaseFunctions.DatabaseConnection);
                command3.ExecuteNonQuery();
            }

            //Closes connection to DB
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Updates the DB with the information in the Reocurring Chore targeted by the method
        /// </summary>
        public void Update()
        {
            //Creates queries that updates the concrete_chore and chore entries with this chore's ID
            string query = string.Format("UPDATE Reoccurring_chore SET " +
                "due_time='{0}' WHERE chore_id={1}",
                DueTime.ToString("T"), ID);
            string query2 = string.Format("UPDATE chore SET " +
                "child_id={0}, name='{1}', description='{2}', points={3} WHERE chore_id={4}",
                Assignment, Name, Description, Points, ID);
            string query3 = string.Format("DELETE FROM days WHERE reo_id=" +
                "(SELECT reo_id FROM Reoccurring_chore WHERE chore_id={0})", ID);
            string query4;

            //Executes the 3 first queries
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();
            command = new SqlCommand(query2, Functions.DatabaseFunctions.DatabaseConnection);
            command.ExecuteNonQuery();
            command = new SqlCommand(query3, Functions.DatabaseFunctions.DatabaseConnection);
            command.ExecuteNonQuery();

            //Creates and executes an insert query for each day in the list
            foreach (string day in Days)
            {
                //Creates the query string
                query4 = string.Format("INSERT INTO [days] (reo_id, day) VALUES " +
                    "((SELECT reo_id FROM Reoccurring_chore WHERE chore_id={0}), '{1}')", ID, day);

                //Executes the query
                command = new SqlCommand(query4, Functions.DatabaseFunctions.DatabaseConnection);
                command.ExecuteNonQuery();
            }

            //Closes connection to DB
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Loads Reocurring Chores from the DB. Can load with a where clause in the query
        /// </summary>
        /// <param name="whereClause">String with the where clause. If empty the method loads
        /// all concrete chores</param>
        /// <returns>List of loaded Reocurring Chores</returns>
        public static List<Reoccurring> Load(string whereClause)
        {
            //Checks if string is empty. If not adds WHERE in front if it
            if (whereClause != "")
            {
                whereClause = " WHERE " + whereClause;
            }

            //Declares a list of Reocurring Chores
            List<Reoccurring> result = new List<Reoccurring>();

            //Creates a query that selects columns from reocurring_chore inner joined with chore based on chore_id
            string query = string.Format(
                "SELECT ch.chore_id, ch.name, ch.description, ch.points, ch.child_id, reo.due_time" +
                " FROM chore AS ch INNER JOIN Reoccurring_chore AS reo ON " +
                "ch.chore_id=reo.chore_id{0}", whereClause);

            //Executes the query
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            SqlDataReader reader = command.ExecuteReader();

            //Reads all lines in the datareader
            while (reader.Read())
            {
                //Declares a Reocurring object and casts the data from the datareader into variables
                Reoccurring currentChore;
                int choreID = (int)reader[0];
                string name = reader[1].ToString();
                string description = reader[2].ToString();
                int points = (int)reader[3];
                int assignment = (int)reader[4];
                DateTime dueTime = DateTime.ParseExact(reader[5].ToString(), "HH:mm:ss", null);
                List<string> days = new List<string>(); //This list will be filled in later in the method

                //Initializes the Reocurring object with the parameters and adds it to the list
                currentChore = new Reoccurring(choreID, name, description, points, assignment, dueTime, days);
                result.Add(currentChore);
            }
            reader.Close();

            //Fills in the blank days lists in each Reocurring
            foreach (Reoccurring list in result)
            {
                //Creates a query that selects all days with this objects reo_id
                query = string.Format("SELECT day FROM days WHERE reo_id=" +
                    "(SELECT reo_id FROM Reoccurring_chore WHERE chore_id={0})", list.ID);
                command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);

                //Executes the query
                reader = command.ExecuteReader();

                //Adds each day to the days list for the current chore
                while (reader.Read())
                {
                    list.Days.Add(reader[0].ToString());
                }
                reader.Close();
            }

            //Clean up and return
            Functions.DatabaseFunctions.DatabaseConnection.Close();
            return result;
        }

        /// <summary>
        /// Override of ToString. Mainly used for testing purposes
        /// </summary>
        /// <returns>Returns a string representation of the properties of the object and the associated Chore object</returns>
        public override string ToString()
        {
            //Formats the string with variables from this and base class
            var sum = string.Format("Chore: {0} \nDescription: {1} \nPoints: {2} \nAssignment: {3} " +
                "\nDue time: {4} \nDays: ",
                Name, Description, Points, Assignment, DueTime.ToString("T"));

            //Adds each day to the list
            foreach (string day in Days)
            {
                sum += "\n" + day;
            }
            return sum;
        }

        #endregion Public helpers
    }
}