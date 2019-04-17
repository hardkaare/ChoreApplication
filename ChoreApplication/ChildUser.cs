using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChoreApplication
{
    class ChildUser : User
    {
        private static SqlConnection dbConn = DatabaseFunctions.dbConn;

        #region Properties
        // Gets and sets the points for the ChildUser
        public int Points { get; set; }
        #endregion

        #region Constructors

        public ChildUser(int id, string firstName, string pincode) : base(id, firstName, pincode)
        {
            Points = 0;
        }

        public static List<ChildUser> GetChildren()
        {
            List<ChildUser> children = new List<ChildUser>();

            string query = "SELECT * FROM dbo.users WHERE user_id <> 1";
            SqlCommand cmd = new SqlCommand(query, dbConn);
            dbConn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["user_id"];
                string firstname = reader["first_name"].ToString();
                string pincode = reader["pincode"].ToString();

                ChildUser user = new ChildUser(id, firstname, pincode);

                children.Add(user);
            }
            reader.Close();
            dbConn.Close();
            return children;
        }


        // Creates an object of the class ChildUser. 
        public ChildUser(string firstName, string pincode) : base(firstName, pincode)
        {
            Points = 0;
        }

        

        #endregion

        #region Public Helpers
        public static void SetPincode(string pincode, int id)
        {
            string query = string.Format("UPDATE dbo.users SET pincode='{0}' WHERE user_id={1}", pincode, id);
            SqlCommand cmd = new SqlCommand(query, dbConn);
            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }
        public override string ToString()
        {
            return $"{FirstName} has {Points} points.";
        }

        #endregion

        #region Private Helpers

        #endregion
    }

}
