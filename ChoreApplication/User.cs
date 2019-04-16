using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChoreApplication
{
    abstract class User
    {
        #region Properties

        // Derived classes can set the firstname and the public can get it. 
        public string FirstName { get; protected set; }

        // Everyone can get the pincode (reconsider this later). Derived classes can set it.
        public int Pincode { get; protected set; }

        #endregion

        #region Constructors

        // The base constructor for ParentUser and ChildUser. Makes sure every object of ParentUser and ChildUser has a firstname and pincode.
        public User(string firstName, int pincode)
        {
            FirstName = firstName;
            Pincode = pincode;
        }

        #endregion
        #region Public methods
        public static void Insert(string f, int p)
        {
               
            string query = string.Format("INSERT INTO dbo.users(first_name, pincode) VALUES ('{0}', '{1}')", f, p);
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.dbConn);
            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }
        #endregion
    }
}
