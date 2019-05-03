using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChoreApplication
{
    /// <summary>
    /// Reocurring Chore. Inherits from the Chore class. Contains what time it's due and what days 
    /// it should occur on in a list.
    /// </summary>
    public class Reocurring : Chore
    {
        #region Properties

        //What time of the day it should set the due time to when it generates Concrete Chores
        public DateTime dueTime { get; set; }

        //What days it should generate a Concrete Chore
        public List<string> days { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructs the chore. Passes variables to the Chore constructer. Sets due time and days.
        /// </summary>
        public Reocurring(int _id, string _name, string _desc, int _points, int _assignment, DateTime _duetime, List<string> _days) : 
            base(_id, _name, _desc, _points, _assignment)
        {
            dueTime = _duetime;
            days = _days;
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
            //Formats the string with variables from this and base class
            var sum = string.Format("Chore: {0} \nDescription: {1} \nPoints: {2} \nAssignment: {3} " +
                "\nDue time: {4} \nDays: ",
                Name, Description, Points, Assignment, dueTime.ToString("T"));

            //Adds each day to the list
            foreach (string day in days)
            {
                sum += "\n" + day;
            }
            return sum;
        }

        //Overvej transactions her
        public static void Insert(int assignment, string name, string desc, int points, 
            DateTime dueTime, List<string> days)
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

            //Formatting the query to concrete_chore table and creating the SqlCommand
            string query2 = string.Format("INSERT INTO dbo.reoccurring_chore (chore_id, due_time) " +
                "OUTPUT inserted.reo_id VALUES ({0}, '{1}')", id, dueTime.ToString("T"));
            SqlCommand cmd2 = new SqlCommand(query2, DatabaseFunctions.dbConn);

            //Executes the query to chore table and returns the chore_id inserted
            id = (int)cmd2.ExecuteScalar();

            //Creates and executes an insert query for each day in the list
            string query3;
            SqlCommand cmd3;
            foreach (string day in days)
            {
                query3 = string.Format("INSERT INTO [days] (reo_id, day) VALUES ({0}, '{1}')", id, day);
                cmd3 = new SqlCommand(query3, DatabaseFunctions.dbConn);
                cmd3.ExecuteNonQuery();
            }

            //Closes connection to DB
            DatabaseFunctions.dbConn.Close();
        }

        public void Update()
        {
            //Formatting the queries to chore table and creating the SqlCommand for the first query
            string query = string.Format("UPDATE reoccurring_chore SET " +
                "due_time='{0}' WHERE chore_id={1}",
                dueTime.ToString("T"), ID);
            string query2 = string.Format("UPDATE chore SET " +
                "child_id={0}, name='{1}', description='{2}', points={3} WHERE chore_id={4}",
                Assignment, Name, Description, Points, ID);
            string query3 = string.Format("DELETE FROM days WHERE reo_id=" +
                "(SELECT reo_id FROM reoccurring_chore WHERE chore_id={0})", ID);
            string query4;

            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.dbConn);

            //Opens connection to the DB
            DatabaseFunctions.dbConn.Open();

            //Executes the SqlCommands
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(query2, DatabaseFunctions.dbConn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(query3, DatabaseFunctions.dbConn);
            cmd.ExecuteNonQuery();

            //Creates and executes an insert query for each day in the list
            foreach (string day in days)
            {
                query4 = string.Format("INSERT INTO [days] (reo_id, day) VALUES " +
                    "((SELECT reo_id FROM reoccurring_chore WHERE chore_id={0}), '{1}')", ID, day);
                cmd = new SqlCommand(query4, DatabaseFunctions.dbConn);
                cmd.ExecuteNonQuery();
            }

            //Closes connection to DB
            DatabaseFunctions.dbConn.Close();
        }

        public static List<Reocurring> Load(string whereClause)
        {
            //Checks if string is empty. If not adds where in front
            if (whereClause != "")
            {
                whereClause = " WHERE " + whereClause;
            }

            //Initializes a list of concrete chores
            List<Reocurring> result = new List<Reocurring>();

            //Makes a string query and opens the connection to DB
            string query = string.Format(
                "SELECT ch.chore_id, ch.name, ch.description, ch.points, ch.child_id, reo.due_time" +
                " FROM chore AS ch INNER JOIN reoccurring_chore AS reo ON " +
                "ch.chore_id=reo.chore_id{0}", whereClause);
            DatabaseFunctions.dbConn.Open();

            //Creates the SqlCommand and executes it
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.dbConn);
            SqlDataReader reader = cmd.ExecuteReader();

            //Reads all lines in the datareader
            while (reader.Read())
            {
                //Declares a Concrete object and casts the data from the datareader into variables
                Reocurring currentChore;
                int choreID = (int)reader[0];
                string name = reader[1].ToString();
                string description = reader[2].ToString();
                int points = (int)reader[3];
                int assignment = (int)reader[4];
                DateTime dueTime = DateTime.ParseExact(reader[5].ToString(), "HH:mm:ss", null);
                List<string> days = new List<string>();

                //Initializes the choreobject with the parameters and adds it to the list
                currentChore = new Reocurring(choreID, name, description, points, assignment, dueTime, days);
                result.Add(currentChore);
            }
            reader.Close();

            //Fills in the blank lists in each Reocurring
            foreach (Reocurring list in result)
            {
                //Selects all days for the current chore in DB
                query = string.Format("SELECT day FROM days WHERE reo_id=" +
                    "(SELECT reo_id FROM reoccurring_chore WHERE chore_id={0})", list.ID);
                cmd = new SqlCommand(query, DatabaseFunctions.dbConn);
                reader = cmd.ExecuteReader();
                
                //Adds each day to the days list for the current chore
                while (reader.Read())
                {
                    list.days.Add(reader[0].ToString());
                }
                reader.Close();
            }
            DatabaseFunctions.dbConn.Close();
            return result;
        }

        #endregion
    }
}
