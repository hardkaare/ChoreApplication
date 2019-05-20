using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChoreApplication.UI.GeneralInterface
{
    /// <summary>
    /// Displays the PincodeInterface. 
    /// Textbox for user input is added in the designer.
    /// Round buttons for numbers 0-9 are added in the designer, as well as accept and delete button.
    /// This class contains event handlers for each numeric button, accept button, delete button and back button.
    /// </summary>
    public partial class PinCodeInterface : Form
    {
        #region Properties

        //ID for the chosen User in ChooseProfile
        private int ActiveID { get; set; }

        //Session that's passed to ParentMenu or ChildMenu on login
        private Model.User _session { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes components from designer. Sets ActiveID
        /// </summary>
        public PinCodeInterface(int id)
        {
            InitializeComponent();
            ActiveID = id;
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Event handler for the numeric buttons. Adds the number to enterpinTextBox's text
        /// </summary>
        private void OneButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            enterpinTextBox.Text += button.Text;
        }

        /// <summary>
        /// Event handler for DeleteButton. Clears enterpinTextBox.Text
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            enterpinTextBox.Text = "";
        }

        /// <summary>
        /// Event handler for AcceptButton. Validates userinput and sends to respective menu.
        /// </summary>
        private void AcceptButton_click(object sender, EventArgs e)
        {
            //True if pincode was correct
            bool correctpin = false;

            //Is true if enterpinTextBox.Text is converted to int 
            bool conversion = Int32.TryParse(enterpinTextBox.Text, out int pincode);

            //If conversion is true checks if pincode matches the chosen User's pincode
            if (conversion)
            {
                //Creates a query that selects pincode from chosen User
                string query = string.Format("SELECT pincode FROM users WHERE user_id={0}", ActiveID);
                Functions.DatabaseFunctions.DatabaseConnection.Open();

                //Executes the query
                SqlCommand cmd = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
                SqlDataReader reader = cmd.ExecuteReader();

                //Reads the pincode
                while (reader.Read())
                {
                    //Converts pin from DB to int
                    int loadedpin = Convert.ToInt32(reader["pincode"]);

                    //If the pins match correctpin becomes true
                    if (loadedpin == pincode)
                    {
                        correctpin = true;
                    }

                    //Displays error message if incorrect pin
                    else
                    {
                        MessageBox.Show("Incorrect pincode", "Error");
                    }
                }
            }

            //Displays error message if text could not be converted to int
            else
            {
                MessageBox.Show("Please enter numbers in your pincode", "Error");
            }
            Functions.DatabaseFunctions.DatabaseConnection.Close();

            //If pins match logs into respective interface
            if (correctpin == true)
            {
                //If chosen profile was the parent, logs into ParentMenu
                if (ActiveID == 1)
                {
                    //Loads ParentUser and sets _session
                    var sessionList = Model.ParentUser.Load("");
                    _session = sessionList[0];

                    //Creates ParentMenu with _session and closes this
                    var parentUI = new ParentUI.ParentMenu(sessionList[0]);
                    parentUI.Show();
                    this.Close();
                }

                //If chosen profile was a child, logs into ChildMenu
                else
                {
                    //Loads ChildUser with the chosen ID and sets _session
                    var sessionList = Model.ChildUser.Load("u.user_id=" + ActiveID.ToString());
                    _session = sessionList[0];

                    //Creates ChildMenu with _session and closes this
                    var childUI = new UI.ChildMenu(sessionList[0]);
                    childUI.Show();
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Event handler for BackButton. Returns to previous UI
        /// </summary>
        private void BackButton_Click(object sender, EventArgs e)
        {
            var chooseProfile = new ChooseProfileInterface();
            chooseProfile.Show();
            this.Close();
        }

        #endregion
    }
}