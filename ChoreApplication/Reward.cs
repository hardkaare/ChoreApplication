using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreApplication
{
    class Reward
    {
        #region Properties
        // The name of the reward. Everyone can set and get.
        public string Name { get; set; }

        // The points required to earn the reward. Everyone can get and set. 
        public int PointsRequired { get; set; }

        // Who the reward is assigned to. Everyone can get and set. 
        public string Assignment { get; set; }
        #endregion

        #region Constructors
        // Creates an object of the class Reward with the specified information.
        public Reward(string name, int pointsRequired, string assignment)
        {
            Name = name;
            PointsRequired = pointsRequired;
            Assignment = assignment;
        }

        #endregion

        #region Public Helpers

        public override string ToString()
        {
            return $"{Assignment} must get {PointsRequired} points to earn {Name}.";
        }

        #endregion

        #region Private Helpers
        #endregion

    }
}
