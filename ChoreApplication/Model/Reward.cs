using System.Collections.Generic;
using System.Data.SqlClient;

namespace ChoreApplication.Model
{
    /// <summary>
    /// Rewards that a ParentUser can set for a ChildUser. Contains a RewardID, Name, Description, PointsRequired and ChildID.
    /// Contains methods for inserting, loading, updating and deleting the reward in DB. 
    /// </summary>
    public class Reward
    {
        #region Properties

        // ID for the reward given by DB
        private int RewardID { get; set; }

        // The name of the reward.
        public string Name { get; set; }

        // The points required to earn the reward.
        public string Description { get; set; }

        public int PointsRequired { get; set; }

        // To which ChildUser the reward is assigned to.
        public int ChildID { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Sets the properties of the reward.
        /// </summary>
        public Reward(int rewardID, string name, string description, int pointsReq, int childID)
        {
            RewardID = rewardID;
            Name = name;
            PointsRequired = pointsReq;
            ChildID = childID;
            Description = description;
        }

        #endregion Constructors

        #region Public Methods

        /// <summary>
        /// Inserts a new reward into the DB. Inserts into reward table
        /// </summary>
        public static void Insert(int childID, string name, string description, int pointsRequired)
        {
            //Creates a query that inserts data into reward
            string query = string.Format("INSERT INTO dbo.reward VALUES ({0},'{1}','{2}',{3} )", childID, name, description, pointsRequired);
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the query
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Updates the DB with the information in the Reward targeted by the method
        /// </summary>
        public void Update()
        {
            //Creates queries that updates the reward entry with this reward's ID
            string query = string.Format("UPDATE dbo.reward SET child_id='{0}', name='{1}', description='{2}', points={3} WHERE reward_id={4}", ChildID, Name, Description, PointsRequired, RewardID);
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the query
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Loads Rewards from the DB. Can load with a where clause in the query
        /// </summary>
        /// <param name="whereClause">String with the where clause. If empty the method loads
        /// all concrete chores</param>
        /// <returns>List of loaded Concrete Chores</returns>
        public static List<Reward> Load(string whereClause)
        {
            //Checks if string is empty. If not adds WHERE in front if it
            if (whereClause != "")
            {
                whereClause = " WHERE " + whereClause;
            }

            //Declares a list of Rewards
            List<Reward> rewards = new List<Reward>();

            //Creates a query that selects all from the reward table
            string query = string.Format("SELECT * FROM dbo.reward{0}", whereClause);
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the query
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            SqlDataReader reader = command.ExecuteReader();

            //Reads all lines in the datareader
            while (reader.Read())
            {
                //Declares a Reward object and casts the data from the datareader into variables
                Reward reward;
                int rewardID = (int)reader["reward_id"];
                string name = reader["name"].ToString();
                string description = reader["description"].ToString();
                int pointsRequired = (int)reader["points"];
                int childID = (int)reader["child_id"];

                //Initializes the Reward object with the parameters and adds it to the list
                reward = new Reward(rewardID, name, description, pointsRequired, childID);
                rewards.Add(reward);
            }

            //Clean up and return
            reader.Close();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
            return rewards;
        }

        /// <summary>
        /// Deletes an instance of the reward class based on the object interacted with.
        /// </summary>
        public void Delete()
        {
            string query = string.Format("DELETE FROM dbo.reward WHERE reward_id={0}", RewardID);
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Override of ToString. Mainly used for testing purposes
        /// </summary>
        /// <returns>Returns a string representation of the properties of the object</returns>
        public override string ToString()
        {
            return $"{ChildID} must get {PointsRequired} points to earn {Name}.";
        }

        #endregion Public Helpers
    }
}