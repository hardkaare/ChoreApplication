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
            //Concrete.Insert("Spis broccoli", "Mindst 3 kg om dagen", 125, 1, DateTime.Now, "Reoc");
            
            var testList = new List<Concrete>();
            testList = Concrete.LoadWhere("");
            foreach(Concrete l in testList)
            {
                MessageBox.Show(l.ToString());
            }
            

            /*
            string tidcsharp = DateTime.Now.ToString();

            string query = "SELECT due_date FROM concrete_chore";
            SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.dbConn);
            string tidSQL ="";
            DatabaseFunctions.dbConn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tidSQL = reader[0].ToString();
            }
            DatabaseFunctions.dbConn.Close();

            string samlet = string.Format("C#'s tidsformat som ToString: {0} \nSQL's tidsformat som ToString: {1}", tidcsharp, tidSQL);

            MessageBox.Show(samlet);
            */
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
