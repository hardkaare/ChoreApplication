using System.Data.SqlClient;

namespace ChoreApplication.Model
{
    /// <summary>
    /// Class for chore objects. Contains name of the chore, description of it, how many points it gives and
    /// who it's assigned to.
    /// </summary>
    public abstract class Chore
    {
        #region Properties

        //ID of the chore
        public int ID { get; protected set; }

        //Name of the chore
        public string Name { get; set; }

        //Description of how to do the chore
        public string Description { get; set; }

        //How many points is earned by completing the chore
        public int Points { get; set; }

        //Who the chore's assigned to
        public int Assignment { get; set; }

        #endregion Properties

        #region Constructor

        /// <summary>
        /// Constructor that sets all properties for the class
        /// </summary>
        /// <param name="name">Name of the chore</param>
        /// <param name="description">Description of the chore</param>
        /// <param name="points">Points earned by completing the chore</param>
        /// <param name="assignment">Who the chore is assigned to</param>
        public Chore(int id, string name, string description, int points, int assignment)
        {
            ID = id;
            Name = name;
            Description = description;
            Points = points;
            Assignment = assignment;
        }

        #endregion Constructor

        #region Public helpers

        //ToString override that lists all properties of the chore
        public override string ToString()
        {
            return string.Format("Chore: {0} | Description: {1} | Points: {2} | Assignment: {3}",
                Name, Description, Points, Assignment);
        }

        public void Delete()
        {
            //Formatting the queries to chore table and creating the SqlCommand for the first query
            string query = string.Format("DELETE FROM chore WHERE chore_id={0}", ID);
            SqlCommand cmd = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);

            //Opens connection to the DB
            Functions.DatabaseFunctions.DatabaseConnection.Open();

            //Executes the SqlCommand
            cmd.ExecuteNonQuery();

            //Closes connection to DB
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        #endregion Public helpers
    }
}