using System.Data.SqlClient;

namespace ChoreApplication.Model
{
    /// <summary>
    /// Abstract class for Chore objects. Contains name of the chore, description of it, how many points it gives and
    /// who it's assigned to. Contains a method for deleting chores in DB.
    /// </summary>
    public abstract class Chore
    {
        #region Properties

        //ID of the chore
        protected int ID { get; private set; }

        //Name of the chore
        public string Name { get; set; }

        //Description of how to do the chore
        public string Description { get; set; }

        //How many points is earned by completing the chore
        public int Points { get; set; }

        //To whom the chore's assigned
        public int Assignment { get; set; }

        #endregion Properties

        #region Constructor

        /// <summary>
        /// Constructor that sets all properties for the class
        /// </summary>
        public Chore(int id, string name, string description, int points, int assignment)
        {
            ID = id;
            Name = name;
            Description = description;
            Points = points;
            Assignment = assignment;
        }

        #endregion Constructor

        #region Public Methods

        /// <summary>
        /// Deleting any type of chore in DB. Chore has cascading constraint so it deletes the rest automatically
        /// </summary>
        public void Delete()
        {
            //Formatting the queries to chore table and creating the SqlCommand for the first query
            string query = string.Format("DELETE FROM chore WHERE chore_id={0}", ID);
            SqlCommand cmd = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);

            //Executes the SqlCommand
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            cmd.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }

        /// <summary>
        /// ToString override that lists all properties of the chore
        /// </summary>
        public override string ToString()
        {
            return string.Format("Chore: {0} | Description: {1} | Points: {2} | Assignment: {3}",
                Name, Description, Points, Assignment);
        }

        #endregion Public helpers
    }
}