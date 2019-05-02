using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //Use MySQL stuff
using System.Globalization; //Set different time/culture formats
using System.Data.SqlClient;

namespace ChoreApplication
{
    public partial class ChoreApplication : Form
    {
        ParentUser DumbFuckParentUser = new ParentUser(1, "diller", "diller", "dillersen", "diller", "0000");
        public ChoreApplication()
        {
            InitializeComponent();
            DatabaseFunctions.InitializeDB();
        }

        private static void LoadAllUsers()
        {
            List<ParentUser> parents = ParentUser.Load("");
            List<ChildUser> children = ChildUser.Load("");
            
            foreach (var parent in parents)
            {
                MessageBox.Show(string.Format(parent.FirstName + parent.Pincode));
                
            }
            foreach (var child in children)
            {
                MessageBox.Show(string.Format(child.FirstName + child.Pincode));
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var createChore = new UI.CreateChoreUI();
            createChore.Show();
        }
        private void EditJoenler_Click(object sender, EventArgs e)
        {
            var child = ChildUser.Load("u.user_id = 2");
            var chore = Repeatable.Load("ch.chore_id = 3");
            var EditChild = new UI.EditChildUI(child[0]);
            var editChore = new UI.EditChoreUI(chore[0]);

            //EditChild.Show();
            editChore.Show();
        }
        private void TestButtonJoenler_Click(object sender, EventArgs e)
        {
            var LoginInterface = new UI.LoginInterface();
            var RegisterUser = new UI.RegisterUserInterface();
            var ChooseProfile = new UI.ChooseProfileInterface();
            var ParentInterface = new UI.ParentInterface(DumbFuckParentUser);
            var createchore = new UI.CreateChoreUI();
            var createreward = new UI.CreateRewardUI();
            var createChild = new UI.CreateChildUI();

            //createChild.Show();
            //createreward.Show();
            createchore.Show();
            //LoginInterface.Show();
            //RegisterUser.Show();
            //ChooseProfile.Show();
            //ParentInterface.Show();

            //DatabaseFunctions.RunStringQuery("SELECT * FROM dbo.users");
            //TestLabelJoenler.Text = DatabaseFunctions.RunQuery("SELECT * FROM dbo.chore");
            //Notification testNotification = new Notification("You have a new reward available", "Phillip");
            //TestLabelJoenler.Text = testNotification.ToString();
            //Reward testReward = new Reward("A good spanking", 100, "Phillip");
            //TestLabelJoenler.Text = testReward.ToString();
            //ParentUser testParent = new ParentUser("Hansen@lort.dk", "12334", "Hansen", "Jan", 1234);
            //TestLabelJoenler.Text = testParent.ToString();
            //ChildUser testChild = new ChildUser("Phillip", 1234);
            //TestLabelJoenler.Text = testChild.ToString();
        }

        private void Interface1_Click(object sender, EventArgs e)
        {
            var LoginInterface = new UI.LoginInterface();
            var RegisterUser = new UI.RegisterUserInterface();
            var ChooseProfile = new UI.ChooseProfileInterface();
            var ParentInterface = new UI.ParentInterface(DumbFuckParentUser);
            var ChildInterface = new UI.ChildInterface();

            //LoginInterface.Show();
            //RegisterUser.Show();
            //ChooseProfile.Show();
            //ParentInterface.Show();
            ChildInterface.Show();
        }

        private void ChoreApplication_Load(object sender, EventArgs e)
        {

        }

        private void AlexogLuten_Click(object sender, EventArgs e)
        {
            var LoginInterface = new UI.LoginInterface();
            LoginInterface.Show();
            this.Hide();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            var ChildInterface = new UI.ChildInterface();
            ChildInterface.Show();
            
        }
    }
}
