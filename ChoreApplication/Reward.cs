﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChoreApplication
{
    class Reward
    {
        #region Properties
        public int RewardId { get; private set; }
        // The name of the reward. 
        public string Name { get; private set; }

        // The points required to earn the reward.
        public int PointsReq { get; private set; }

        // Who the reward is assigned to. 
        public int ChildId { get; private set; }
        #endregion

        #region Constructors
        // Creates an object of the class Reward with the specified information.
        public Reward(int rewardId, string name, int pointsReq, int childId)
        {
            RewardId = rewardId;
            Name = name;
            PointsReq = pointsReq;
            ChildId = childId;
        }

        #endregion

        #region Public Helpers
        /// <summary>
        /// Creates a reward based on the values of this class' properties.
        /// </summary>
        /// <param name="childId"></param>
        /// <param name="name"></param>
        /// <param name="pointsReq"></param>
        public static void Insert(int childId, string name, int pointsReq)
        {
            string query = string.Format("INSERT INTO dbo.reward VALUES ({0},'{1}',{2} )", childId, name, pointsReq);
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.dbConn);
            DatabaseFunctions.dbConn.Open();
            cmd.ExecuteNonQuery();
            DatabaseFunctions.dbConn.Close();
           
        }
        /// <summary>
        /// Updates a specific reward object based on the input from the user.
        /// </summary>
        public void Update()
        {
            //Formatting the query to reward table and creating the SqlCommand.
            string query = string.Format("UPDATE dbo.reward SET child_id='{0}', name='{1}', points={2} WHERE reward_id={3}", ChildId , Name, PointsReq, RewardId);
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.dbConn);
            DatabaseFunctions.dbConn.Open();
            cmd.ExecuteNonQuery();
            DatabaseFunctions.dbConn.Close();
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
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.dbConn);
            DatabaseFunctions.dbConn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int rewardId = (int)reader["reward_id"];
                string name = reader["name"].ToString();
                int pointsReq = (int)reader["points"];
                int childId = (int)reader["child_id"];
                Reward reward = new Reward(rewardId, name, pointsReq, childId);
                rewards.Add(reward);
            }
            reader.Close();
            DatabaseFunctions.dbConn.Close();
            return rewards;
        }
        /// <summary>
        /// Deletes an instance of the reward class based on the object interacted with. 
        /// </summary>
        public void Delete()
        {
            string query = string.Format("DELETE FROM dbo.reward WHERE reward_id={0}", RewardId);
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.dbConn);
            DatabaseFunctions.dbConn.Open();
            cmd.ExecuteNonQuery();
            DatabaseFunctions.dbConn.Close();
        }


        /// <summary>
        /// Provides a string representation for objects of this class.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{ChildId} must get {PointsReq} points to earn {Name}.";
        }

        #endregion

        #region Private Helpers
        #endregion

    }
}
