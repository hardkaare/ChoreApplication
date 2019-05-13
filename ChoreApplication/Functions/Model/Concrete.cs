﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ChoreApplication
{
    /// <summary>
    /// Concrete chores. Inherits from the Chore class. Contains due date of the chore,
    /// the status of the chore and the date of approval
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
        /// 1 = active
        /// 2 = approval pending
        /// 3 = approved
        /// 4 = overdue
        /// </summary>
        public int Status { get; set; }

        //Date of approval. Empty if not approved yet
        public DateTime ApprovalDate { get; set; }

        public string Type { get; set; }

        public int Reminder { get; set; }

        #endregion Properties

        #region Constructor

        /// <summary>
        /// Sets the properties of the concrete chore and creates and constructs a chore
        /// </summary>
        /// <param name="name">Name of the chore</param>
        /// <param name="description">Description of the chore</param>
        /// <param name="points">How many points are earned by completing the chore</param>
        /// <param name="assignment">Who the chore is assigned to</param>
        /// <param name="dueDate">When the chore is due</param>
        /// <param name="status">What state the chore is in. Can be active, approval pending, approved and overdue</param>
        /// <param name="approvalDate">What date the chore is approved. Empty string if not approved</param>
        public Concrete(int id, string name, string description, int points, int assignment,
            DateTime dueDate, int status, DateTime approvalDate, string type, int reminder) :
            base(id, name, description, points, assignment)
        {
            DueDate = dueDate;
            Status = status;
            ApprovalDate = approvalDate;
            Type = type;
            Reminder = reminder;
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
                "\nDue date: {4} \nStatus: {5} \nDate of approval: {6}\nReminder sent: {7}",
                Name, Description, Points, Assignment, DueDate, Status, ApprovalDate, Reminder);
        }

        /// <summary>
        /// Inserts a new chore into the DB. Inserts into chore table and concrete_chore with the
        /// foreign key inserted into chore table
        /// </summary>
        /// <param name="name">Name of the chore</param>
        /// <param name="desc">Description of the chore</param>
        /// <param name="points">Points of the chore</param>
        /// <param name="assignment">The ID of child the chore is assigned to</param>
        /// <param name="dueDate">When the chore is due</param>
        /// <param name="type">Which type of chore the concrete chore is generated as. Can be
        /// reoc, rep or conc</param>
        public static void Insert(string name, string desc, int points,
            int assignment, DateTime dueDate, string type)
        {
            //If a repeatable chore generated the concrete chore the status goes straight to approval pending
            int status;
            if (type == "rep")
            {
                status = 2;
            }
            else
            {
                status = 1;
            }

            //Formatting the query to chore table and creating the SqlCommand
            string query = string.Format("INSERT INTO dbo.chore" +
                "(child_id, name, description, points) OUTPUT inserted.chore_id VALUES " +
                "('{0}', '{1}', '{2}', '{3}')", assignment, name, desc, points);
            SqlCommand command = new SqlCommand(query, Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection);

            //Opens connection to the DB
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Open();

            //Executes the query to chore table and returns the chore_id inserted
            int id = (int)command.ExecuteScalar();

            //Formatting the query to concrete_chore table, creating the SqlCommand and executing it
            string query2 = string.Format("INSERT INTO dbo.concrete_chore " +
                "VALUES ({0}, '{1}', '{2}', NULL, '{3}', 0)", id, dueDate.ToString(Properties.Settings.Default.LongDateFormat), status, type);
            SqlCommand command2 = new SqlCommand(query2, Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection);
            command2.ExecuteNonQuery();

            //Closes connection to DB
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Updates the DB with the information in the Concrete Chore targeted by the method
        /// </summary>
        public void Update()
        {
            //Formatting the queries to chore table and creating the SqlCommand for the first query
            string query = string.Format("UPDATE concrete_chore SET " +
                "due_date='{0}', status={1}, approval_date='{2}', reminder={3} WHERE chore_id={4}",
                DueDate.ToString(Properties.Settings.Default.LongDateFormat), Status, ApprovalDate.ToString(Properties.Settings.Default.LongDateFormat), Reminder, ID);
            string query2 = string.Format("UPDATE chore SET " +
                "child_id={0}, name='{1}', description='{2}', points={3} WHERE chore_id={4}",
                Assignment, Name, Description, Points, ID);
            SqlCommand command = new SqlCommand(query, Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection);

            //Opens connection to the DB
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Open();

            //Executes the SqlCommands
            command.ExecuteNonQuery();
            command = new SqlCommand(query2, Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection);
            command.ExecuteNonQuery();

            //Closes connection to DB
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Loads concrete chores from the DB. Can load with a where clause in the query
        /// </summary>
        /// <param name="whereClause">String with the where clause. If empty the method loads
        /// all concrete chores</param>
        /// <returns></returns>
        public static List<Concrete> Load(string whereClause)
        {
            //Checks if string is empty. If not adds where in front
            if (whereClause != "")
            {
                whereClause = " WHERE " + whereClause;
            }

            //Initializes a list of concrete chores
            List<Concrete> result = new List<Concrete>();

            //Makes a string query and opens the connection to DB
            string query = string.Format(
                "SELECT ch.chore_id, ch.name, ch.description, ch.points, ch.child_id, co.due_date, " +
                "co.status, co.approval_date, co.type, co.reminder FROM chore AS ch INNER JOIN concrete_chore AS co ON " +
                "ch.chore_id=co.chore_id{0}", whereClause);
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Open();

            //Creates the SqlCommand and executes it
            SqlCommand command = new SqlCommand(query, Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection);
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

                //Initializes the choreobject with the parameters and adds it to the list
                currentChore = new Concrete(choreID, name, description, points, assignment, dueTime, status, approvalDate, type, reminder);
                result.Add(currentChore);
            }
            reader.Close();
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Close();
            return result;
        }

        #endregion Public methods
    }
}