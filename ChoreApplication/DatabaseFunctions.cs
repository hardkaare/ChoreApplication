using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ChoreApplication
{
    /// <summary>
    /// Functions for interacting with the DB. Inkludes a function run once that initializes the connection
    /// to the DB.
    /// </summary>
    class DatabaseFunctions
    {
        #region Connection string constants

        //Server
        private const String DATASOURCE = "choreapplication.database.windows.net";
        //Name of DB
        private const String INITIALCATALOG = "ChoreApplication";
        //Username
        private const String UID = "bi408f19";
        //Password
        private const String PASSWORD = "Tuborg123";
        //Sql connection
        private static SqlConnection dbConn;

        #endregion

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
            dbConn = new SqlConnection(connString);

            //When application is closed, clear connection if active
            Application.ApplicationExit += (sender, args) =>
            {
                if (dbConn != null)
                {
                    dbConn.Dispose();
                    dbConn = null;
                }
            };
        }

        #endregion

        public static void Insert(string f, int p)
        {
            string query = string.Format("INSERT INTO dbo.users(first_name, pincode) VALUES ('{0}', '{1}')", f, p);
            SqlCommand cmd = new SqlCommand(query, dbConn);
            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }
    }
}

