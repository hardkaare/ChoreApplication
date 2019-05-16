using System.Collections.Generic;
using System.Data.SqlClient;

namespace ChoreApplication.Model
{
    /// <summary>
    /// This class manages information about child users. It inherits from User, and adds the properties Points and ChildID.
    /// It contains methods for loading, inserting, updating and deleting child users from the DB.
    /// </summary>
    public class ChildUser : User
    {
        #region Properties

        // Amount points the child has earned by doing chores
        public int Points { get; set; }

        // ID from the DB
        public int ChildID { get; private set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Creates a User and a Child User. Id, firstname and pincode parameters are passed to base constructor.
        /// </summary>
        public ChildUser(int id, int childId, string firstName, int points, string pincode) : base(id, firstName, pincode)
        {
            Points = points;
            ChildID = childId;
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Inserts a child user in the DB.
        /// </summary>
        public static void Insert(string firstName, string pincode)
        {
            //Creates query that inserts firstname and pincode to users and returns the inserted user_id
            string query = string.Format("INSERT INTO dbo.users(first_name, pincode) OUTPUT inserted.user_id VALUES ('{0}', '{1}')", firstName, pincode);

            //Creates command and opens connection to DB
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            
            //Executes the query and sets id to returned user_id
            int id = (int)command.ExecuteScalar();

            //Creates query to insert to child table, executes it and closes connection to DB
            query = string.Format("INSERT INTO dbo.child(user_id, points) VALUES ('{0}',0)", id);
            command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            command.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Updates a child in DB with properties from User and ChildUser
        /// </summary>
        public void Update()
        {
            //Creates a query that updates users with this child's user_id and executes it
            string query = string.Format("UPDATE dbo.users SET first_name='{0}', pincode={1} WHERE user_id={2}", FirstName, Pincode, ID);
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();

            //Creates a query that updates child with  this child's user_id and executes it
            query = string.Format("UPDATE dbo.child SET points={0} WHERE user_id={1}", Points, ID);
            command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            command.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Loads all children from the database. Can be modified to only return children that fits defined parameters.
        /// </summary>
        /// <param name="whereClause">String with a where clause in SQL. The method adds WHERE on it's own</param>
        /// <returns>A list of all found ChildUsers</returns>
        public static List<ChildUser> Load(string whereClause)
        {
            //Checks if string is empty, and if not adds a WHERE in front of it
            if (whereClause != "")
            {
                whereClause = " WHERE " + whereClause;
            }

            //Defines list to return
            List<ChildUser> children = new List<ChildUser>();

            //Creates query that selects all columns from users inner joined with child. Adds the optional where clause.
            string query = string.Format("SELECT u.user_id,c.child_id,u.first_name,c.points,u.pincode FROM users AS u INNER JOIN child AS c ON u.user_id = c.user_id{0}", whereClause);

            //Executes the query
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            SqlDataReader reader = command.ExecuteReader();

            //Reads queried data, creates a ChildUser with it and adds it to the list
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

            //Clean up and return
            reader.Close();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
            return children;
        }

        /// <summary>
        /// Deletes this ChildUser from DB
        /// </summary>
        public void Delete()
        {
            //Creates query that deletes from users with this ChildUser's ID. Table has cascading constraint in DB so it deletes from child by itself
            string query = string.Format("DELETE FROM dbo.users WHERE user_id={0}", ID);

            //Executes the query
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Provides a string representation of an object of this class. Used for testing purposes.
        /// </summary>
        public override string ToString()
        {
            return $"{FirstName} has {Points} points.";
        }

        #endregion Public Helpers
    }
}