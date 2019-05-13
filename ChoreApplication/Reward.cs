using System.Collections.Generic;
using System.Data.SqlClient;

namespace ChoreApplication
{
    public class Reward
    {
        #region Properties

        public int RewardID { get; set; }

        // The name of the reward.
        public string Name { get; set; }

        // The points required to earn the reward.
        public string Description { get; set; }

        public int PointsRequired { get; set; }

        // Who the reward is assigned to.
        public int ChildID { get; set; }

        #endregion Properties

        #region Constructors

        // Creates an object of the class Reward with the specified information.
        public Reward(int rewardID, string name, string description, int pointsReq, int childID)
        {
            RewardID = rewardID;
            Name = name;
            PointsRequired = pointsReq;
            ChildID = childID;
            Description = description;
        }

        #endregion Constructors

        #region Public Helpers

        /// <summary>
        /// Creates a reward based on the values of this class' properties.
        /// </summary>
        /// <param name="childID"></param>
        /// <param name="name"></param>
        /// <param name="pointsRequired"></param>
        public static void Insert(int childID, string name, string description, int pointsRequired)
        {
            string query = string.Format("INSERT INTO dbo.reward VALUES ({0},'{1}','{2}',{3} )", childID, name, description, pointsRequired);
            SqlCommand command = new SqlCommand(query, Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection);
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Updates a specific reward object based on the input from the user.
        /// </summary>
        public void Update()
        {
            //Formatting the query to reward table and creating the SqlCommand.
            string query = string.Format("UPDATE dbo.reward SET child_id='{0}', name='{1}', description='{2}', points={3} WHERE reward_id={4}", ChildID, Name, Description, PointsRequired, RewardID);
            SqlCommand command = new SqlCommand(query, Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection);
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Loads rewards from the database. the <paramref name="whereClause"/> can be specified to narrow the results.
        /// </summary>
        /// <param name="whereClause"></param>
        /// <returns></returns>
        public static List<Reward> Load(string whereClause)
        {
            if (whereClause != "")
            {
                whereClause = " WHERE " + whereClause;
            }
            List<Reward> rewards = new List<Reward>();
            string query = string.Format("SELECT * FROM dbo.reward{0}", whereClause);
            SqlCommand command = new SqlCommand(query, Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection);
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int rewardID = (int)reader["reward_id"];
                string name = reader["name"].ToString();
                string description = reader["description"].ToString();
                int pointsRequired = (int)reader["points"];
                int childID = (int)reader["child_id"];
                Reward reward = new Reward(rewardID, name, description, pointsRequired, childID);
                rewards.Add(reward);
            }
            reader.Close();
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Close();
            return rewards;
        }

        /// <summary>
        /// Deletes an instance of the reward class based on the object interacted with.
        /// </summary>
        public void Delete()
        {
            string query = string.Format("DELETE FROM dbo.reward WHERE reward_id={0}", RewardID);
            SqlCommand command = new SqlCommand(query, Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection);
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();
            Functions.SystemFunctions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// Provides a string representation for objects of this class.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{ChildID} must get {PointsRequired} points to earn {Name}.";
        }

        #endregion Public Helpers
    }
}