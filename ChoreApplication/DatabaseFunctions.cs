using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChoreApplication
{
    /// <summary>
    /// Functions for interacting with the DB. Inkludes a function run once that initializes the connection
    /// to the DB.
    /// </summary>
    internal class DatabaseFunctions
    {
        #region Connection string constants

        //Server
        private const String DATASOURCE = "choreapplication1.database.windows.net";

        //Name of DB
        private const String INITIALCATALOG = "ChoreApplication";

        //Username
        private const String UID = "bi408f19";

        //Password
        private const String PASSWORD = "Tuborg123";

        //Sql connection
        public static SqlConnection DbConn { get; private set; }

        #endregion Connection string constants

        #region Public methods

        /// <summary>
        /// Initializes the DB. Makes connection string from constants and uses it to
        /// create a connection to the DB
        /// </summary>
        public static void InitializeDB()
        {
            //Builds a connection string from the connection string constants
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = DATASOURCE;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.InitialCatalog = INITIALCATALOG;

            //Clears the string builder
            String connString = builder.ToString();
            builder = null;

            //Makes the connection to DB
            DbConn = new SqlConnection(connString);

            //When application is closed, clear connection if active
            Application.ApplicationExit += (sender, args) =>
            {
                if (DbConn != null)
                {
                    DbConn.Dispose();
                    DbConn = null;
                }
            };
        }

        #endregion Public methods
    }
}