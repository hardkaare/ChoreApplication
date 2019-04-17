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
            List<string> testlist = new List<string>();
            testlist.Add("Mon");
            testlist.Add("Wed");
            testlist.Add("Fri");
            Reocurring testchore1 = new Reocurring("Gå tur med hunden", "Husk poser og snor", 5, 
                "Hans", DateTime.Now, testlist);
            TestLabelLuten.Text = testchore1.ToString();
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
            RegisterUser.Show();
        }
    }
}
