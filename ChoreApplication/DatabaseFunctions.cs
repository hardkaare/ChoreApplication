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
        public static void Connection()
        {
            List<object> objectList = new List<object>();
            var i = 0;
            var readerOutput = 0;
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "choreapplication.database.windows.net";
                builder.UserID = "bi408f19";
                builder.Password = "Tuborg123";
                builder.InitialCatalog = "ChoreApplication";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();

                    sb.Append("SELECT * FROM dbo.users");
                    string sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
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
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }


    }
}

