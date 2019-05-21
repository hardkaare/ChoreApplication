﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChoreApplication
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void OpenApplicationButton_Click(object sender, EventArgs e)
        {
            _ = new UI.GeneralInterface.LoginInterface();
        }

        private void CheckTimeButton_Click(object sender, EventArgs e)
        {
            _ = new TechnicalPlatform.CheckTime();
            MessageBox.Show("CheckTime function has run succesfully.\nRefresh the application to see the changes.", "Success");
        }

        private void ResetDatabaseButton_Click(object sender, EventArgs e)
        {
            ResetDB();
            MessageBox.Show("The database has been cleared.", "Success");
        }

        private void DummyDataButton_Click(object sender, EventArgs e)
        {
            ResetDB();
            var query = string.Format("INSERT INTO dbo.users VALUES ('Far', '1234'); INSERT INTO dbo.parent VALUES (1, 'Test', 'test@test.dk', '123456'); INSERT INTO dbo.users VALUES ('Erik', '1234'); INSERT INTO dbo.child VALUES (2, 0); INSERT INTO dbo.users VALUES ('Valdemar', '1234'); INSERT INTO dbo.child VALUES (3, 0); INSERT INTO dbo.users VALUES ('Peter', '1234'); INSERT INTO dbo.child VALUES (4, 0); INSERT INTO dbo.chore VALUES (1,'Gå med hunden', 'Husk poser til afføring',15); INSERT INTO dbo.repeatable_chore VALUES(1,3,0); INSERT INTO dbo.chore VALUES (1,'Tøm opvaskemaskinen.', 'Husk at tørre vandet ovenpå kopperne af.',10); INSERT INTO dbo.concrete_chore VALUES(2,'15-05-2019 17:00',1,NULL,'conc', 0); INSERT INTO dbo.chore VALUES (1,'Rengør værelse', 'Tørre støv af og støvsuge',25); INSERT INTO dbo.concrete_chore VALUES(3,'15-04-2019 17:00',1,NULL,'reoc', 0); INSERT INTO dbo.chore VALUES (1,'Slå græsset.','Huske at komme godt ind til kanterne.',10); INSERT INTO dbo.concrete_chore VALUES(4,'15-05-2019 18:00',1,NULL,'conc', 0); INSERT INTO dbo.reward VALUES (1,'Fredagsslik.','200g.',75); INSERT INTO dbo.chore VALUES (2,'Rengør værelse', 'Tørre støv af og støvsuge',10); INSERT INTO dbo.concrete_chore VALUES(5,'15-04-2019 17:00',3,NULL,'conc', 0); INSERT INTO dbo.chore VALUES (2,'Rengør værelse', 'Tørre støv af og støvsuge',10); INSERT INTO dbo.concrete_chore VALUES(6,'15-04-2019 17:00',3,NULL,'conc', 0); INSERT INTO dbo.chore VALUES (2,'Rengør værelse', 'Tørre støv af og støvsuge',10); INSERT INTO dbo.concrete_chore VALUES(7,'15-04-2019 17:00',3,NULL,'conc', 0); INSERT INTO dbo.chore VALUES (2,'Rengør værelse', 'Tørre støv af og støvsuge',10); INSERT INTO dbo.concrete_chore VALUES(8,'15-04-2019 17:00',3,NULL,'conc', 0); INSERT INTO dbo.chore VALUES (2,'Rengør værelse', 'Tørre støv af og støvsuge',10); INSERT INTO dbo.concrete_chore VALUES(9,'15-04-2019 17:00',3,NULL,'conc', 0); INSERT INTO dbo.chore VALUES (2,'Rengør værelse', 'Tørre støv af og støvsuge',10); INSERT INTO dbo.concrete_chore VALUES(10,'15-04-2019 17:00',3,NULL,'conc', 0); INSERT INTO dbo.chore VALUES (2,'Rengør værelse', 'Tørre støv af og støvsuge',10); INSERT INTO dbo.concrete_chore VALUES(11,'15-04-2019 17:00',4,NULL,'conc', 0); INSERT INTO dbo.chore VALUES (2,'Rengør værelse', 'Tørre støv af og støvsuge',10); INSERT INTO dbo.concrete_chore VALUES(12,'15-04-2019 17:00',4,NULL,'conc', 0); INSERT INTO dbo.chore VALUES (3,'Rengør værelse', 'Tørre støv af og støvsuge',70); INSERT INTO dbo.concrete_chore VALUES(13,'15-04-2019 17:00',3,NULL,'conc', 0); INSERT INTO dbo.chore VALUES (3,'Rengør værelse', 'Tørre støv af og støvsuge',10); INSERT INTO dbo.concrete_chore VALUES(14,'15-04-2019 17:00',3,NULL,'conc', 0); INSERT INTO dbo.chore VALUES (3,'Rengør værelse', 'Tørre støv af og støvsuge',10); INSERT INTO dbo.concrete_chore VALUES(15,'15-04-2019 17:00',4,NULL,'conc', 0); INSERT INTO dbo.chore VALUES (3,'Rengør værelse', 'Tørre støv af og støvsuge',10); INSERT INTO dbo.concrete_chore VALUES(16,'15-04-2019 17:00',3,NULL,'conc', 0); INSERT INTO dbo.chore VALUES (3,'Rengør værelse', 'Tørre støv af og støvsuge',10); INSERT INTO dbo.concrete_chore VALUES(17,'15-04-2019 17:00',4,NULL,'conc', 0); INSERT INTO dbo.chore VALUES (3,'Rengør værelse', 'Tørre støv af og støvsuge',10); INSERT INTO dbo.concrete_chore VALUES(18,'15-04-2019 17:00',3,NULL,'conc', 0); INSERT INTO dbo.chore VALUES (3,'Rengør værelse', 'Tørre støv af og støvsuge',10); INSERT INTO dbo.concrete_chore VALUES(19,'15-04-2019 17:00',4,NULL,'conc', 0); INSERT INTO dbo.chore VALUES (3,'Rengør værelse', 'Tørre støv af og støvsuge',10); INSERT INTO dbo.concrete_chore VALUES(20,'15-04-2019 17:00',4,NULL,'conc', 0);");
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();

            MessageBox.Show("The dummy data has been inserted.", "Success");
        }

        private void ResetDB()
        {
            var query = string.Format("SET DATEFORMAT dmy; IF OBJECT_ID ('dbo.days', 'U') IS NOT NULL DROP TABLE dbo.days; IF OBJECT_ID ('dbo.reoccurring_chore', 'U') IS NOT NULL DROP TABLE dbo.reoccurring_chore; IF OBJECT_ID('dbo.repeatable_chore', 'U') IS NOT NULL DROP TABLE dbo.repeatable_chore; IF OBJECT_ID('dbo.concrete_chore', 'U') IS NOT NULL DROP TABLE dbo.concrete_chore; IF OBJECT_ID('dbo.chore', 'U') IS NOT NULL DROP TABLE dbo.chore; IF OBJECT_ID ('dbo.reward', 'U') IS NOT NULL DROP TABLE dbo.reward; IF OBJECT_ID ('dbo.notification', 'U') IS NOT NULL DROP TABLE dbo.notification; IF OBJECT_ID ('dbo.child', 'U') IS NOT NULL DROP TABLE dbo.child; IF OBJECT_ID('dbo.parent', 'U') IS NOT NULL DROP TABLE dbo.parent; IF OBJECT_ID('dbo.users', 'U') IS NOT NULL DROP TABLE dbo.users; IF OBJECT_ID('dbo.checkTime', 'U') IS NOT NULL DROP TABLE dbo.checkTime; CREATE TABLE dbo.users(user_id INT NOT NULL IDENTITY(1,1) PRIMARY KEY, first_name  VARCHAR(20) NOT NULL, pincode VARCHAR(4)); CREATE TABLE dbo.parent(user_id INT NOT NULL, last_name VARCHAR(50) NOT NULL, email VARCHAR(50) NOT NULL, password VARCHAR(20) NOT NULL, FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE); CREATE TABLE dbo.child(child_id    INT NOT NULL IDENTITY(1,1) PRIMARY KEY, user_id INT NOT NULL, points INT NOT NULL DEFAULT 0, FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE );    CREATE TABLE dbo.notification( notification_id     INT NOT NULL PRIMARY KEY IDENTITY(1,1), user_id             INT NOT NULL, title               VARCHAR(255) NOT NULL, description         VARCHAR(255) NOT NULL, FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE );  CREATE TABLE dbo.checkTime( dailyTick  VARCHAR(19) );   CREATE TABLE dbo.reward( reward_id   INT NOT NULL IDENTITY(1,1) PRIMARY KEY, child_id    INT NOT NULL, name        VARCHAR(50) NOT NULL, description VARCHAR(255), points      INT NOT NULL, FOREIGN KEY (child_id) REFERENCES child(child_id) ON DELETE CASCADE );  CREATE TABLE dbo.chore( chore_id    INT NOT NULL IDENTITY(1,1) PRIMARY KEY, child_id    INT NOT NULL, name        VARCHAR(50) NOT NULL, description VARCHAR(255), points      INT NOT NULL, FOREIGN KEY (child_id) REFERENCES child(child_id) ON DELETE CASCADE );  CREATE TABLE dbo.concrete_chore( chore_id        INT NOT NULL, due_date        VARCHAR(19), status          INT NOT NULL, approval_date   VARCHAR(19), type            VARCHAR(11) NOT NULL, reminder        INT NOT NULL, FOREIGN KEY (chore_id) REFERENCES chore(chore_id) ON DELETE CASCADE );  CREATE TABLE dbo.repeatable_chore( chore_id        INT NOT NULL, limit           INT, completions     INT NOT NULL, FOREIGN KEY (chore_id) REFERENCES chore(chore_id) ON DELETE CASCADE ); CREATE TABLE dbo.reoccurring_chore( reo_id      INT NOT NULL PRIMARY KEY IDENTITY(1,1), chore_id    INT NOT NULL, due_time    VARCHAR(19) NOT NULL, FOREIGN KEY (chore_id) REFERENCES chore(chore_id) ON DELETE CASCADE );  CREATE TABLE dbo.days( reo_id  INT NOT NULL, day     CHAR(9), FOREIGN KEY (reo_id) REFERENCES reoccurring_chore(reo_id) ON DELETE CASCADE );");
            SqlCommand command = new SqlCommand(query, Functions.DatabaseFunctions.DatabaseConnection);
            Functions.DatabaseFunctions.DatabaseConnection.Open();
            command.ExecuteNonQuery();
            Functions.DatabaseFunctions.DatabaseConnection.Close();
        }
    }
}