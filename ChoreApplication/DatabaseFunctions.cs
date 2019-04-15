using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ChoreApplication
{
    class DatabaseFunctions
    {
        public static void Connection()
        {
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
                                MessageBox.Show(reader.GetString(1));
                                MessageBox.Show(Convert.ToString(reader.GetInt32(0)));
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


        //public static string RunQuery(string sql)
        //{
        //    Connection();
        //    using (SqlCommand = new SqlCommand(sql, connection))
        //    {

        //    }
        //}

        /*
        public static MySqlConnection Connection()
        {
            MySqlConnection con = null;
            string myConnectionString = "Server=127.0.0.1;Database=world;User ID=root;Password=999;Connection Timeout=30;";

            try
            {
                con = new MySqlConnection();
                con.ConnectionString = myConnectionString;
                con.Open();
                MessageBox.Show("Connection Succesful");
                return con;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
               
            }
            finally
            {
                if(con != null)
                {
                    con.Clone();
                }   
            }
            return con;
        }
        */
        /*
        public static string RunQuery(string query)
        {
            var result = "";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = Connection();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    result += reader[i];
                }
            }
            return result;

        }
        */
    }
}

