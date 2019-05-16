using System.Collections.Generic;
using System.Data.SqlClient;

namespace ChoreApplication.Model
{
    /// <summary>
    /// This class manages information about parent users. It inherits from User, and adds the properties email, password and last name.
    /// It contains methods for loading, inserting, updating and deleting parent users from the DB.
    /// It's currently only possible to have 1 parent user pr. family
    /// </summary>
    public class ParentUser : User
    {
        #region Properties

        //Email used to log in to the system for the whole family
        public string Email { get; set; }

        //Password used to log in to the system for the whole family
        public string Password { get; set; }

        //The family's surname
        public string LastName { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Creates a User and a Parent User. Id, firstname and pincode parameters are passed to base constructor.
        /// </summary>
        public ParentUser(int id, string email, string password, string lastName, string firstName, string pincode) : base(id, firstName, pincode)
        {
            Email = email;
            Password = password;
            LastName = lastName;
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Inserts a parent user to the DB.
        /// </summary>
        public static void Insert(string firstname, string lastname, string email, string password, string pincode)
        {
            //Creates a query that inserts data into users and returns the inserted user_id
            string userQuery = string.Format("INSERT INTO dbo.users(first_name, pincode) OUTPUT inserted.user_id VALUES ('{0}','{1}')", firstname, pincode);
            SqlCommand command = new SqlCommand(userQuery, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the query and sets id to the returned user_id
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            int id = (int)command.ExecuteScalar();

            //Creates a query that inserts data into parent
            string parentQuery = string.Format("INSERT INTO dbo.parent(user_id, last_name, email, password) VALUES ('{0}','{1}','{2}','{3}')", id, lastname, email, password);
            command = new SqlCommand(parentQuery, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the query
            command.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Updates a specific parent object based on the properties of the object
        /// </summary>
        public void Update()
        {
            //Creates a query that updates data in users based on the objects user_id
            string userQuery = string.Format("UPDATE dbo.users SET first_name='{0}', pincode={1} WHERE user_id=1", FirstName, Pincode);
            SqlCommand command = new SqlCommand(userQuery, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the query
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();

            //Creates a query that updates data in parent based on the objects user_id
            string parentQuery = string.Format("UPDATE dbo.parent SET last_name='{0}', email='{1}', password='{2}' WHERE user_id=1", LastName, Email, Password);
            command = new SqlCommand(parentQuery, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the query
            command.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Loads parent users from the DB. Can load with a where clause in the query
        /// </summary>
        /// <param name="whereClause">String with the where clause. If empty the method loads
        /// all parents</param>
        public static List<ParentUser> Load(string whereClause)
        {
            //Checks if string is empty. If not adds WHERE in front if it
            if (whereClause != "")
            {
                whereClause = " WHERE " + whereClause;
            }
            //Declares a list of Parent Users
            List<ParentUser> parents = new List<ParentUser>();

            //Creates a query that selects columns from users inner joined with parent based on user_id
            string query = string.Format("SELECT u.user_id,u.first_name,p.last_name,p.email,p.[password],u.pincode FROM users AS u INNER JOIN parent AS p ON u.user_id = p.user_id{0};", whereClause);
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the query
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            SqlDataReader reader = command.ExecuteReader();

            //Reads all lines in the datareader
            while (reader.Read())
            {
                //Declares a ParentUser object and casts the data from the datareader into variables
                ParentUser user;
                int id = (int)reader["user_id"];
                string email = reader["email"].ToString();
                string password = reader["password"].ToString();
                string lastname = reader["last_name"].ToString();
                string firstname = reader["first_name"].ToString();
                string pincode = reader["pincode"].ToString();

                //Initializes the ParentUser object with the parameters and adds it to the list
                user = new ParentUser(id, email, password, lastname, firstname, pincode);
                parents.Add(user);
            }

            //Clean up and return
            reader.Close();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
            return parents;
        }

        /// <summary>
        /// Override of ToString. Mainly used for testing purposes
        /// </summary>
        /// <returns>Returns a string representation of the properties of the parent and the associated user object</returns>
        public override string ToString()
        {
            return $"Parent {FirstName} {LastName} has registered with E-mail: {Email}, password {Password} nad pincode {Pincode}.";
        }

        #endregion Public Helpers
    }
}