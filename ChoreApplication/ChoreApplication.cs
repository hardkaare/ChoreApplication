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
        public ChoreApplication()
        {
            InitializeComponent();
            DatabaseFunctions.InitializeDB();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Repeatable.Insert(1, "Tag opvasken", "", 75, 10);
            List<Repeatable> testlist = Repeatable.LoadWhere("");
            foreach(Repeatable l in testlist)
            {
                MessageBox.Show(l.ToString());
            }
            testlist[2].Delete();
            MessageBox.Show("Item deleted");
            testlist[3].completions = 2;
            testlist[3].Update();
            MessageBox.Show("Item updted");
            testlist = Repeatable.LoadWhere("");
            foreach (Repeatable l in testlist)
            {
                MessageBox.Show(l.ToString());
            }
        }

        private void TestButtonJoenler_Click(object sender, EventArgs e)
        {

            ParentUser.Delete(9);
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
            var LoginInterface = new LoginInterface();
            var RegisterUser = new RegisterUserInterface();
            var ChooseProfile = new ChooseProfileInterface();
            var ParentInterface = new ParentInterface();

            //LoginInterface.Show();
            //RegisterUser.Show();
            //ChooseProfile.Show();
            ParentInterface.Show();
        }

        private void ChoreApplication_Load(object sender, EventArgs e)
        {

        }
    }
}
