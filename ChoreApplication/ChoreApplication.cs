using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChoreApplication
{
    public partial class ChoreApplication : Form
    {
        //private SystemFunctions _checkTime;
        public Model.ChildUser DumbFuckChildUser = new Model.ChildUser(1, 1, "child", 100, "1234");

        public Model.ParentUser DumbFuckParentUser = new Model.ParentUser(1, "admin", "1234", "adminsen", "admin", "1234");

        public ChoreApplication()
        {
            InitializeComponent();
            Functions.DatabaseFunctions.InitializeDB();
            var LoginUI = new UI.GeneralInterface.LoginInterface();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var checkTime = new TechnicalPlatform.CheckTime();
        }

        private void EditJoenler_Click(object sender, EventArgs e)
        {
            var child = Model.ChildUser.Load("u.user_id = 2");
            var chore = Model.Reoccurring.Load("ch.chore_id = 1");
            var reward = Model.Reward.Load("");
            var EditChild = new UI.ParentUI.EditChildUI(child[0]);
            var editChore = new UI.ParentUI.EditChoreUI(chore[0]);
            //var editReward = new UI.EditRewardUI(reward[0]);

            //EditChild.Show();
            editChore.Show();
            //editReward.Show();
        }

        //public UI.CreateChoreUI createchore = new UI.CreateChoreUI();
        private void TestButtonJoenler_Click(object sender, EventArgs e)
        {
            var LoginInterface = new UI.GeneralInterface.LoginInterface();
            var RegisterUser = new UI.GeneralInterface.RegisterUserInterface();
            var ChooseProfile = new UI.GeneralInterface.ChooseProfileInterface();
            var ParentInterface = new UI.ParentUI.ParentMenu(DumbFuckParentUser);
            //var createchore = new UI.CreateChoreUI();
            var createreward = new UI.ParentUI.CreateRewardUI();
            var createChild = new UI.ParentUI.CreateChildUI();

            //createChild.Show();
            //createreward.Show();
            //createchore.Show();
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
            var LoginInterface = new UI.GeneralInterface.LoginInterface();
            var RegisterUser = new UI.GeneralInterface.RegisterUserInterface();
            var ChooseProfile = new UI.GeneralInterface.ChooseProfileInterface();

            var ChildInterface = new UI.ChildMenu(DumbFuckChildUser);
            var editparent = new UI.ParentUI.EditParentUI(DumbFuckParentUser);
            //LoginInterface.Show();
            //RegisterUser.Show();
            //ChooseProfile.Show();
            //ParentInterface.Show();
        }

        private void ChoreApplication_Load(object sender, EventArgs e)
        {
        }

        private void AlexogLuten_Click(object sender, EventArgs e)
        {
            var LoginInterface = new UI.GeneralInterface.LoginInterface();
            this.Hide();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            var ChildInterface = new UI.ChildMenu(DumbFuckChildUser);
            var ParentInterface = new UI.ParentUI.ParentMenu(DumbFuckParentUser);
            ChildInterface.Show();
        }

        private void EditParentUI_Click(object sender, EventArgs e)
        {
            var EditParentUI = new UI.ParentUI.EditParentUI(DumbFuckParentUser);
            EditParentUI.Show();
        }
    }
}