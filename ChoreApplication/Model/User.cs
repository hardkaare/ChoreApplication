namespace ChoreApplication.Model
{
    /// <summary>
    /// Abstract class for User objects. Contains ID, FirstName and Pincode. 
    /// </summary>
    public abstract class User
    {
        #region Properties

        //ID of the User given by DB
        public int ID { get; private set; }

        // First name of the User
        public string FirstName { get; set; }

        // Pincode used to log in with ChooseProfileUI
        public string Pincode { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Constructor that sets all properties for the class
        /// </summary>
        public User(int id, string firstName, string pincode)
        {
            ID = id;
            FirstName = firstName;
            Pincode = pincode;
        }

        #endregion Constructors
    }
}