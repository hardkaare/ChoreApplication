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
    class DatabaseFunctions
    {
        private const String DATASOURCE = "choreapplication.database.windows.net";
        private const String INITIALCATALOG = "ChoreApplication";
        private const String UID = "bi408f19";
        private const String PASSWORD = "Tuborg123";
        public static SqlConnection dbConn;

        public static void InitializeDB()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = DATASOURCE;
            builder.UserID = UID;
            builder.Password = PASSWORD;
            builder.InitialCatalog = INITIALCATALOG;

            String connString = builder.ToString();

            builder = null;

            dbConn = new SqlConnection(connString);

            Application.ApplicationExit += (sender, args) =>
            {
                if (dbConn != null)
                {
                    dbConn.Dispose();
                    dbConn = null;
                }
            };
        }

        
    }
}

