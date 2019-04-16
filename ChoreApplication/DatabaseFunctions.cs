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
        public static SqlConnectionStringBuilder Connection()
        {


            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "choreapplication.database.windows.net";
            builder.UserID = "bi408f19";
            builder.Password = "Tuborg123";
            builder.InitialCatalog = "ChoreApplication";

            return builder;


        }
        public static void RunQuery(string query)
        {
            List<object> objectList = new List<object>();
            var i = 0;
            var readerOutput = 0;
            var builder = Connection();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();                  

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            objectList.Add(reader.GetValue(0));
                            readerOutput = Convert.ToInt32(objectList[i]);
                            readerOutput++;
                            MessageBox.Show(Convert.ToString(objectList[i]));
                            i++;

                        }
                    }
                }
            }


        }
    }
}

