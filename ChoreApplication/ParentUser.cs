using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChoreApplication
{
    public class ParentUser : User
    {

        #region Properties
        // The following properties can only be set from the derived classes but everyone can get it. (reconsider this later.)
   
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public string Lastname { get; protected set; }

        #endregion

        #region Constructors

        public ParentUser(int id, string email, string password, string lastName, string firstName, string pincode) : base(id, firstName, pincode)
        {
            Email = email;
            Password = password;
            Lastname = lastName;

        }

        #endregion

        #region Public Helpers
        /// <summary>
        /// Inserts a parent user based on the following parameters:
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="pincode"></param>
        public static void Insert(string firstname, string lastname, string email, string password, string pincode)
        {
            string userQuery = string.Format("INSERT INTO dbo.users(first_name, pincode) OUTPUT inserted.user_id VALUES ('{0}','{1}')", firstname, pincode);
            SqlCommand cmd = new SqlCommand(userQuery, DatabaseFunctions.DbConn);
            DatabaseFunctions.DbConn.Open();
            //executes the query and return the first column of the first row in the result set returned by the query 
            int id = (int)cmd.ExecuteScalar();
            string parentQuery = string.Format("INSERT INTO dbo.parent(user_id, last_name, email, password) VALUES ('{0}','{1}','{2}','{3}')", id, lastname, email, password);
            cmd = new SqlCommand(parentQuery, DatabaseFunctions.DbConn);
            cmd.ExecuteNonQuery();
            DatabaseFunctions.DbConn.Close();
        }
        /// <summary>
        /// Updates a specific parent object based on the input from the user.
        /// </summary>
        public void Update()
        {
            string userQuery = string.Format("UPDATE dbo.users SET first_name='{0}', pincode={1} WHERE user_id=1", FirstName, Pincode);
            SqlCommand cmd = new SqlCommand(userQuery, DatabaseFunctions.DbConn);
            DatabaseFunctions.DbConn.Open();
            cmd.ExecuteNonQuery();
            string parentQuery = string.Format("UPDATE dbo.parent SET last_name='{0}', email='{1}', password='{2}' WHERE user_id=1", Lastname, Email, Password);
            cmd = new SqlCommand(parentQuery, DatabaseFunctions.DbConn);
            cmd.ExecuteNonQuery();
            DatabaseFunctions.DbConn.Close();
        }
      /// <summary>
      /// Loads all parent users. A where clause can be added to narrow the load.
      /// </summary>
      /// <param name="whereClause"></param>
      /// <returns></returns>
        public static List<ParentUser> Load(string whereClause)
        {
            if (whereClause != "")
            {
                whereClause = " WHERE " + whereClause;
            }
            List<ParentUser> parents = new List<ParentUser>();
            
            string query = string.Format("SELECT u.user_id,u.first_name,p.last_name,p.email,p.[password],u.pincode FROM users AS u INNER JOIN parent AS p ON u.user_id = p.user_id{0};",whereClause);
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.DbConn);
            DatabaseFunctions.DbConn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["user_id"];
                string email = reader["email"].ToString();
                string password = reader["password"].ToString();
                string lastname = reader["last_name"].ToString();
                string firstname = reader["first_name"].ToString();
                string pincode = reader["pincode"].ToString();

                ParentUser user = new ParentUser(id, email, password, lastname, firstname, pincode);

                parents.Add(user);
            }
            reader.Close();
            DatabaseFunctions.DbConn.Close();
            return parents;
        }
        public override string ToString()
        {
            return $"Parent with the last name {Lastname} has registered with E-mail: {Email} and password {Password}.";
        }

        #endregion

        #region Private Helpers
        #endregion
    }


}
