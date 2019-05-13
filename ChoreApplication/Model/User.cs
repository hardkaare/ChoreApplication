namespace ChoreApplication.Model
{
    public abstract class User
    {
        #region Properties

        public int ID { get; private set; }

        // Derived classes can set the firstname and the public can get it.
        public string FirstName { get; set; }

        // Everyone can get the pincode (reconsider this later). Derived classes can set it.
        public string Pincode { get; set; }

        #endregion Properties

        #region Constructors

        // The base constructor for ParentUser and ChildUser. Makes sure every object of ParentUser and ChildUser has a firstname and pincode.
        public User(int id, string firstName, string pincode)
        {
            ID = id;
            FirstName = firstName;
            Pincode = pincode;
        }

        #endregion Constructors
    }
}