using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ChoreApplication.Model
{
    /// <summary>
    /// Inherits from the Chore class. Adds properties DueDate, Status and ApprovalDate. 
    /// Contains methods for inserting, loading and updating the chore in DB.
    /// </summary>
    public class Concrete : Chore
    {
        #region Properties

        /// <summary>
        /// Date and time of when the chore is due. If null in DB this property is
        /// set to "01-01-2000 00:00:00"
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Status of the chore:
        /// 1 = active, 
        /// 2 = approval pending, 
        /// 3 = approved, 
        /// 4 = overdue
        /// </summary>
        public int Status { get; set; }

        //Date of approval. Empty if not approved yet
        public DateTime FinalDate { get; set; }

        /// <summary>
        /// Tells what has created the chore: 
        /// Reoc = Generated from reocurring chore, 
        /// Rep = Generated from repeatable chore, 
        /// Conc = Created by a ParentUser
        /// </summary>
        public string Type { get; private set; }

        /// <summary>
        /// Binary notation of wether there has been sent a reminder to the child 
        /// an hour before it's due date.
        /// </summary>
        public int Reminder { get; set; }

        #endregion Properties

        #region Constructor

        /// <summary>
        /// Sets the properties of the concrete chore and constructs a chore. 
        /// Passes id, name, description, points and assignment to base.
        /// </summary>
        public Concrete(int id, string name, string description, int points, int assignment,
            DateTime dueDate, int status, DateTime approvalDate, string type, int reminder) :
            base(id, name, description, points, assignment)
        {
            DueDate = dueDate;
            Status = status;
            FinalDate = approvalDate;
            Type = type;
            Reminder = reminder;
        }

        #endregion Constructor

        #region Public methods

        /// <summary>
        /// Inserts a new chore into the DB. Inserts into chore table and concrete_chore with the foreign key inserted into chore table
        /// </summary>
        public static void Insert(string name, string desc, int points,
            int assignment, DateTime dueDate, string type)
        {
            //If a repeatable chore generated the concrete chore the status goes straight to approval pending
            int status;
            if (type == "rep")
            {
                status = 2;
            }

            //If not it starts as active
            else
            {
                status = 1;
            }

            //Creates a query that inserts data into chore and returns the inserted chore_id
            string query = string.Format("INSERT INTO dbo.chore" +
                "(child_id, name, description, points) OUTPUT inserted.chore_id VALUES " +
                "('{0}', '{1}', '{2}', '{3}')", assignment, name, desc, points);

            //Executes the query to chore table and sets id to the inserted chore_id
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            int id = (int)command.ExecuteScalar();

            //Creates a query that inserts data into concrete_chore
            string query2 = string.Format("INSERT INTO dbo.concrete_chore " +
                "VALUES ({0}, '{1}', '{2}', NULL, '{3}', 0)", id, dueDate.ToString(Properties.Settings.Default.LongDateFormat), status, type);

            //Executes the command
            SqlCommand command2 = new SqlCommand(query2, Functions.DatabaseFunctions.DatabaseConnection);
            command2.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Updates the DB with the information in the Concrete Chore targeted by the method
        /// </summary>
        public void Update()
        {
            //Creates queries that updates the concrete_chore and chore entries with this chore's ID
            string query = string.Format("UPDATE concrete_chore SET " +
                "due_date='{0}', status={1}, approval_date='{2}', reminder={3} WHERE chore_id={4}",
                DueDate.ToString(Properties.Settings.Default.LongDateFormat), 
                Status, FinalDate.ToString(Properties.Settings.Default.LongDateFormat), Reminder, ID);
            string query2 = string.Format("UPDATE chore SET " +
                "child_id={0}, name='{1}', description='{2}', points={3} WHERE chore_id={4}",
                Assignment, Name, Description, Points, ID);

            //Executes the queries
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();
            command = new SqlCommand(query2, Functions.DatabaseFunctions.DatabaseConnection);
            command.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Loads Concrete Chores from the DB. Can load with a where clause in the query
        /// </summary>
        /// <param name="whereClause">String with the where clause. If empty the method loads
        /// all concrete chores</param>
        /// <returns>List of loaded Concrete Chores</returns>
        public static List<Concrete> Load(string whereClause)
        {
            //Checks if string is empty. If not adds WHERE in front if it
            if (whereClause != "")
            {
                whereClause = " WHERE " + whereClause;
            }

            //Declares a list of Concrete Chores
            List<Concrete> result = new List<Concrete>();

            //Creates a query that selects columns from concrete_chore inner joined with chore based on chore_id
            string query = string.Format(
                "SELECT ch.chore_id, ch.name, ch.description, ch.points, ch.child_id, co.due_date, " +
                "co.status, co.approval_date, co.type, co.reminder FROM chore AS ch INNER JOIN concrete_chore AS co ON " +
                "ch.chore_id=co.chore_id{0}", whereClause);

            //Executes the query
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            SqlDataReader reader = command.ExecuteReader();

            //Reads all lines in the datareader
            while (reader.Read())
            {
                //Declares a Concrete object and casts the data from the datareader into variables
                Concrete currentChore;
                int choreID = (int)reader[0];
                string name = reader[1].ToString();
                string description = reader[2].ToString();
                int points = (int)reader[3];
                int assignment = (int)reader[4];
                var dueTime = DateTime.ParseExact(reader[5].ToString(), Properties.Settings.Default.LongDateFormat, null);
                int status = (int)reader[6];
                DateTime approvalDate;
                string type = reader[8].ToString();
                int reminder = (int)reader[9];

                //Checks if approval date is null in DB and sets the time to a predefined date if so
                if (!reader.IsDBNull(7))
                {
                    approvalDate = DateTime.ParseExact(reader[7].ToString(), Properties.Settings.Default.LongDateFormat, null);
                }
                else
                {
                    approvalDate = DateTime.ParseExact("01-01-2000 00:00", Properties.Settings.Default.LongDateFormat, null);
                }

                //Initializes the Concrete object with the parameters and adds it to the list
                currentChore = new Concrete(choreID, name, description, points, assignment, dueTime, status, approvalDate, type, reminder);
                result.Add(currentChore);
            }

            //Clean up and return
            reader.Close();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
            return result;
        }

        /// <summary>
        /// Override of ToString. Mainly used for testing purposes
        /// </summary>
        /// <returns>Returns a string representation of the properties of the object and the associated Chore object</returns>
        public override string ToString()
        {
            return string.Format("Chore: {0} \nDescription: {1} \nPoints: {2} \nAssignment: {3} " +
                "\nDue date: {4} \nStatus: {5} \nDate of approval: {6}\nReminder sent: {7}",
                Name, Description, Points, Assignment, DueDate, Status, FinalDate, Reminder);
        }

        #endregion Public methods
    }
}