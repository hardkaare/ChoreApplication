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
        public int ChildId { get; private set; }
        #endregion

        #region Constructors

        public ChildUser(int id, int childId, string firstName, int points, string pincode) : base(id, firstName, pincode)
        {
            Points = points;
            ChildId = childId;
        }



        #endregion

        #region Public Helpers
        public static void Insert(string firstname)
        {
            string userQuery = string.Format("INSERT INTO dbo.users(first_name) OUTPUT inserted.user_id VALUES ('{0}')", firstname);
            SqlCommand cmd = new SqlCommand(userQuery, dbConn);
            dbConn.Open();
            //executes the query and return the first column of the first row in the result set returned by the query 
            int id = (int)cmd.ExecuteScalar();
            string parentQuery = string.Format("INSERT INTO dbo.child(user_id, points) VALUES ('{0}',0)", id);
            cmd = new SqlCommand(parentQuery, dbConn);
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }

        public void Update()
        {
            string userQuery = string.Format("UPDATE dbo.users SET first_name='{0}', pincode={1} WHERE user_id={2}", FirstName, Pincode, Id);
            string childQuery = string.Format("UPDATE dbo.child SET points={0} WHERE user_id={1}",Points,Id);
            SqlCommand cmd = new SqlCommand(userQuery, dbConn);
            dbConn.Open();
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(childQuery, dbConn);
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }

        public static List<ChildUser> LoadAll()
        {
            List<ChildUser> result = new List<ChildUser>();
            result = LoadWhere("");
            return result;
        }
        public static List<ChildUser> LoadWhere(string whereClause)
        {
            if (whereClause != "")
            {
                whereClause = " WHERE " + whereClause;
            }
            List<ChildUser> children = new List<ChildUser>();

            string query = string.Format("SELECT u.user_id,c.child_id,u.first_name,c.points,u.pincode FROM users AS u INNER JOIN child AS c ON u.user_id = c.user_id{0}", whereClause);
            SqlCommand cmd = new SqlCommand(query, dbConn);
            dbConn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["user_id"];
                int childId = (int)reader["child_id"];
                string firstname = reader["first_name"].ToString();
                int points = (int)reader["points"];
                string pincode = reader["pincode"].ToString();

                ChildUser user = new ChildUser(id, childId, firstname, points, pincode);

                children.Add(user);
            }
            reader.Close();
            dbConn.Close();
            return children;
        }

       
   
        public void Delete()
        {
            string query = string.Format("DELETE FROM dbo.users WHERE user_id={0}", Id);
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
