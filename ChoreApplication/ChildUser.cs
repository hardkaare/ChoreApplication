﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChoreApplication
{
    public class ChildUser : User
    {

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
        /// <summary>
        /// Inserts a child user with the firstName specified in the <param>firstName</param>
        /// </summary>
        /// <param name="firstName"></param>
        public static void Insert(string firstName, string pincode)
        {
            string userQuery = string.Format("INSERT INTO dbo.users(first_name, pincode) OUTPUT inserted.user_id VALUES ('{0}', '{1}')", firstName, pincode);
            SqlCommand cmd = new SqlCommand(userQuery, DatabaseFunctions.DbConn);
            DatabaseFunctions.DbConn.Open();
            //executes the query and return the first column of the first row in the result set returned by the query 
            int id = (int)cmd.ExecuteScalar();
            string parentQuery = string.Format("INSERT INTO dbo.child(user_id, points) VALUES ('{0}',0)", id);
            cmd = new SqlCommand(parentQuery, DatabaseFunctions.DbConn);
            cmd.ExecuteNonQuery();
            DatabaseFunctions.DbConn.Close();
        }

        /// <summary>
        /// Updates a specific child object based on the input from the user.
        /// </summary>
        public void Update()
        {
            string userQuery = string.Format("UPDATE dbo.users SET first_name='{0}', pincode={1} WHERE user_id={2}", FirstName, Pincode, Id);
            string childQuery = string.Format("UPDATE dbo.child SET points={0} WHERE user_id={1}",Points,Id);
            SqlCommand cmd = new SqlCommand(userQuery, DatabaseFunctions.DbConn);
            DatabaseFunctions.DbConn.Open();
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(childQuery, DatabaseFunctions.DbConn);
            cmd.ExecuteNonQuery();
            DatabaseFunctions.DbConn.Close();
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

            string query = string.Format("SELECT u.user_id,c.child_id,u.first_name,c.points,u.pincode FROM users AS u INNER JOIN child AS c ON u.user_id = c.user_id{0}", whereClause);
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.DbConn);
            DatabaseFunctions.DbConn.Open();
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
            DatabaseFunctions.DbConn.Close();
            return children;
        }

        /// <summary>
        /// Deletes an instance of the ChildUser class based on the object interacted with. 
        /// </summary>
        public void Delete()
        {
            string query = string.Format("DELETE FROM dbo.users WHERE user_id={0}", Id);
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.DbConn);
            DatabaseFunctions.DbConn.Open();
            cmd.ExecuteNonQuery();
            DatabaseFunctions.DbConn.Close();
        }

        /// <summary>
        /// Provides a representation of an object of this class.
        /// </summary>
        /// <returns>A string describing the object.</returns>
        public override string ToString()
        {
            return $"{FirstName} has {Points} points.";
        }

        #endregion

        #region Private Helpers

        #endregion
    }

}
