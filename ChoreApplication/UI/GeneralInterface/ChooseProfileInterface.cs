using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ChoreApplication.UI.GeneralInterface
{
    /// <summary>
    /// Displays a form with where the User can choose which profile to use. Leads to PincodeInterface.
    /// Adds a button on runtime for each User in the DB.
    /// Contains event handlers UserButton_Click and BackButton_Click.
    /// </summary>
    public partial class ChooseProfileInterface : Form
    {
        #region Properties

        //Surname of the family
        private string Surname { get; set; }

        #endregion

        #region Constructor

        //Displays component created by the designer
        public ChooseProfileInterface()
        {
            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Creates and displays a profilebutton for each User. Is executed when the form is loaded.
        /// </summary>
        private void ChooseProfile_Load(object sender, EventArgs e)
        {
            //Creates a query to load last_name from DB
            string query = "SELECT last_name FROM parent";

            //Executes the query
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            SqlDataReader reader = command.ExecuteReader();

            //Reads the line and sets Surname
            while (reader.Read())
            {
                Surname = reader["last_name"].ToString();
            }
            Functions.DatabaseFunctions.DatabaseConnection.Close();

            //Displays Surname
            surnameLabel.Text = "The " + Surname + "'s";

            //Loads a list of all ParentUsers and ChildUsers
            var parentUsers = Model.ParentUser.Load("");
            var childUsers = Model.ChildUser.Load("");

            //Sets ints for relative locations in 2*x grit format. LocationCounter1 is the nr. for x location and locationCounter2 is for y location
            int locationCounter1 = 1;
            int locationCounter2 = 1;

            //Displays name and a button for each ParentUser
            foreach (Model.ParentUser parent in parentUsers)
            {
                //Creates a standard button from TechnicalPlatform.UILibrary with ID as tag. 
                Button userButton = TechnicalPlatform.UILibrary.StandardElements.AddImageButton(new Point(locationCounter2 * 120, locationCounter1 * 100 - 90), parent.ID, global::ChoreApplication.Properties.Resources.user);

                //Resizes and adds even handler
                userButton.Size = new Size(60, 60);
                userButton.Click += new EventHandler(UserButton_Click);

                //Creates a standard label with the User's first name
                var nameLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel(parent.FirstName, true, new Point(userButton.Location.X - 7, userButton.Location.Y + userButton.Height));

                //Adds the button and label to UI
                profilesPanel.Controls.Add(userButton);
                profilesPanel.Controls.Add(nameLabel);

                //If last button/label was displayed to the left, display the next to the right
                if (locationCounter2 == 1)
                {
                    locationCounter2 = 2;
                }

                //If last button/label was displayed to the right, display the next to the left and a row below
                else if (locationCounter2 == 2)
                {
                    locationCounter2 = 1;
                    locationCounter1++;
                }
            }

            //Displays a name and button for each ChildUser
            foreach (Model.ChildUser child in childUsers)
            {
                //Creates a standard button from TechnicalPlatform.UILibrary with ID as tag. 
                Button userButton = TechnicalPlatform.UILibrary.StandardElements.AddImageButton(new Point(locationCounter2 * 120, locationCounter1 * 100 - 90), child.ID, global::ChoreApplication.Properties.Resources.user);

                //Resizes and adds even handler
                userButton.Size = new Size(60, 60);
                userButton.Click += new EventHandler(UserButton_Click);

                //Creates a standard label with the User's first name
                var nameLabel = TechnicalPlatform.UILibrary.StandardElements.AddLabel(child.FirstName, false, new Point(userButton.Location.X - 7, userButton.Location.Y + userButton.Height));

                //Adds the button and label to UI
                profilesPanel.Controls.Add(userButton);
                profilesPanel.Controls.Add(nameLabel);

                //If last button/label was displayed to the left, display the next to the right
                if (locationCounter2 == 1)
                {
                    locationCounter2 = 2;
                }

                //If last button/label was displayed to the right, display the next to the left and a row below
                else if (locationCounter2 == 2)
                {
                    locationCounter2 = 1;
                    locationCounter1++;
                }
            }
        }

        //Creates a new PincodeInterface, passing ID from the button's tag
        private void UserButton_Click(object sender, System.EventArgs e)
        {
            //Sets ActiveID to the clicked button's tag. 
            Button clickedButton = (Button)sender;
            int ActiveID = (int)clickedButton.Tag;
            
            //Creates a new PincodeInterface and closes this one
            var pinCodeUI = new PinCodeInterface(ActiveID);
            pinCodeUI.Show();
            this.Close();
        }

        //Returns to the previous interface
        private void BackButton_Click(object sender, EventArgs e)
        {
            var loginUI = new LoginInterface();
            loginUI.Show();
            this.Close();
        }

        #endregion
    }
}