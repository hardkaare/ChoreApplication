using System.Collections.Generic;
using System.Data.SqlClient;

namespace ChoreApplication.Model
{
    public class ChildUser : User
    {
        #region Properties

        // Gets and sets the points for the ChildUser
        public int Points { get; set; }

        public int ChildID { get; private set; }

        #endregion Properties

        #region Constructors

        public ChildUser(int id, int childId, string firstName, int points, string pincode) : base(id, firstName, pincode)
        {
            Points = points;
            ChildID = childId;
        }

        #endregion Constructors

        #region Public Helpers

        /// <summary>
        /// Inserts a child user with the firstName specified in the <param>firstName</param>
        /// </summary>
        /// <param name="firstName"></param>
        public static void Insert(string firstName, string pincode)
        {
            string userQuery = string.Format("INSERT INTO dbo.users(first_name, pincode) OUTPUT inserted.user_id VALUES ('{0}', '{1}')", firstName, pincode);
            SqlCommand command = new SqlCommand(userQuery, Functions.DatabaseFunctions.DatabaseConnection);
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            //executes the query and return the first column of the first row in the result set returned by the query
            int id = (int)command.ExecuteScalar();
            string parentQuery = string.Format("INSERT INTO dbo.child(user_id, points) VALUES ('{0}',0)", id);
            command = new SqlCommand(parentQuery, Functions.DatabaseFunctions.DatabaseConnection);
            command.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Updates a specific child object based on the input from the user.
        /// </summary>
        public void Update()
        {
            string userQuery = string.Format("UPDATE dbo.users SET first_name='{0}', pincode={1} WHERE user_id={2}", FirstName, Pincode, ID);
            string childQuery = string.Format("UPDATE dbo.child SET points={0} WHERE user_id={1}", Points, ID);
            SqlCommand command = new SqlCommand(userQuery, Functions.DatabaseFunctions.DatabaseConnection);
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();
            command = new SqlCommand(childQuery, Functions.DatabaseFunctions.DatabaseConnection);
            command.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Loads children from the database. the <paramref name="whereClause"/> can be specified to narrow the results.
        /// </summary>
        /// <param name="whereClause"></param>
        /// <returns></returns>
        public static List<ChildUser> Load(string whereClause)
        {
            if (whereClause != "")
            {
                whereClause = " WHERE " + whereClause;
            }
            List<ChildUser> children = new List<ChildUser>();
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            string query = string.Format("SELECT u.user_id,c.child_id,u.first_name,c.points,u.pincode FROM users AS u INNER JOIN child AS c ON u.user_id = c.user_id{0}", whereClause);
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            SqlDataReader reader = command.ExecuteReader();
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
            Functions.DatabaseFunctions.DatabaseConnection.Close();
            return children;
        }

        /// <summary>
        /// Deletes an instance of the ChildUser class based on the object interacted with.
        /// </summary>
        public void Delete()
        {
            string query = string.Format("DELETE FROM dbo.users WHERE user_id={0}", ID);
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Provides a representation of an object of this class.
        /// </summary>
        /// <returns>A string describing the object.</returns>
        public override string ToString()
        {
            return $"{FirstName} has {Points} points.";
        }

        #endregion Public Helpers
    }
}