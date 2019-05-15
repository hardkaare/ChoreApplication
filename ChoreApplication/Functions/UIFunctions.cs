using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChoreApplication.Functions
{
    internal abstract class UIFunctions
    {
        public static Panel LoadNotification(Model.Notification notification, int width, int yLocation)
        {
            int labelDistance = 0;
            int yLoc = 5;

            var notificationTitle = notification.Title;
            var notificationDescription = notification.Description;

            var notificationTitleLabel = UI.UILibrary.StandardElements.AddLabel(notificationTitle, true, new Point(5, yLoc));
            yLoc += notificationTitleLabel.Height + labelDistance;
            var notificationDescriptionLabel = UI.UILibrary.StandardElements.AddLabel(notificationDescription, false, new Point(10, yLoc));
            var panelHeight = notificationTitleLabel.Height + notificationDescriptionLabel.Height;
            var individualNotificationPanel = UI.UILibrary.StandardElements.AddPanel(new Point(1, yLocation), width, panelHeight);

            individualNotificationPanel.Controls.Add(notificationTitleLabel);
            individualNotificationPanel.Controls.Add(notificationDescriptionLabel);

            return individualNotificationPanel;
        }

        public static Panel LoadLongestStreak(Point location, int width, Dictionary<int, string> ChildrenNames, List<Model.ChildUser> ChildUsers)
        {
            Panel currentPanel = new Panel
            {
                Location = location,
                Width = width
            };
            int barDistance = 5;
            int locationY = 0;
            var longestStreak = LongestStreak(ChildUsers);
            var first = longestStreak.First();
            int maxValue = first.Value;

            foreach (KeyValuePair<int, int> score in longestStreak)
            {
                var bar = AddProgressbar(score.Value, maxValue);
                currentPanel.Controls.Add(bar);
                bar.Location = new Point(0, locationY);
                var label1 = AddLabel(score.Value.ToString(), false, bar.Width, locationY + 5);
                var label2 = AddLabel(ChildrenNames[score.Key], false, bar.Width + 50, locationY + 5);
                currentPanel.Controls.Add(label1);
                currentPanel.Controls.Add(label2);
                locationY += bar.Height + barDistance;
            }

            currentPanel.Height = locationY;
            return currentPanel;
        }

        private static Dictionary<int, int> LongestStreak(List<Model.ChildUser> ChildUsers)
        {
            var result = new Dictionary<int, int>();

            foreach (Model.ChildUser child in ChildUsers)
            {
                int longestStreak = 0;
                int currentStreak = 0;

                string query = string.Format("SELECT concrete_chore.status FROM chore INNER JOIN concrete_chore ON " +
                    "chore.chore_id = concrete_chore.chore_id WHERE child_id={0} AND (concrete_chore.[status]=4 OR " +
                    "concrete_chore.[status]=3) ORDER BY concrete_chore.approval_date ASC", child.ChildID);
                DatabaseFunctions.DatabaseConnection.Open();

                //Creates the SqlCommand and executes it
                SqlCommand command = new SqlCommand(query, DatabaseFunctions.DatabaseConnection);
                SqlDataReader reader = command.ExecuteReader();

                //Reads all lines in the datareader
                while (reader.Read())
                {
                    int status = (int)reader[0];
                    if (status == 3)
                    {
                        currentStreak++;
                        if (currentStreak > longestStreak)
                        {
                            longestStreak = currentStreak;
                        }
                    }
                    else
                    {
                        currentStreak = 0;
                    }
                }
                reader.Close();
                DatabaseFunctions.DatabaseConnection.Close();

                result.Add(child.ChildID, longestStreak);
            }
            result = SortIntDics(result);
            return result;
        }

        public static Panel LoadCompletionRate(Point location, int width, Dictionary<int, string> ChildrenNames, List<Model.ChildUser> ChildUsers)
        {
            Panel currentPanel = new Panel
            {
                Location = location,
                Width = width
            };
            int barDistance = 5;
            int locationY = 0;
            var completionRateApproved = CompletionRateApproved(ChildUsers);

            foreach (KeyValuePair<int, int> score in completionRateApproved)
            {
                var bar = AddProgressbar(score.Value, 100);
                currentPanel.Controls.Add(bar);
                bar.Location = new Point(0, locationY);
                var label1 = AddLabel(score.Value.ToString() + "%", false, bar.Width, locationY + 5);
                var label2 = AddLabel(ChildrenNames[score.Key], false, bar.Width + 50, locationY + 5);
                currentPanel.Controls.Add(label1);
                currentPanel.Controls.Add(label2);
                locationY += bar.Height + barDistance;
            }

            currentPanel.Height = locationY;
            return currentPanel;
        }

        private static Dictionary<int, int> CompletionRateApproved(List<Model.ChildUser> ChildUsers)
        {
            var result = new Dictionary<int, int>();

            foreach (Model.ChildUser c in ChildUsers)
            {
                double CR;
                int sumOverdue = 0;
                int sumApproved = 0;
                int CRrounded;

                string query = string.Format("SELECT chore.chore_id FROM chore INNER JOIN concrete_chore ON " +
                    "chore.chore_id = concrete_chore.chore_id WHERE child_id={0} AND concrete_chore.[status]=4", c.ChildID);
                DatabaseFunctions.DatabaseConnection.Open();

                //Creates the SqlCommand and executes it
                SqlCommand command = new SqlCommand(query, DatabaseFunctions.DatabaseConnection);
                SqlDataReader reader = command.ExecuteReader();

                //Reads all lines in the datareader
                while (reader.Read())
                {
                    int noget = (int)reader[0];
                    sumOverdue++;
                }
                reader.Close();

                query = string.Format("SELECT chore.chore_id FROM chore INNER JOIN concrete_chore ON " +
                    "chore.chore_id = concrete_chore.chore_id WHERE child_id={0} AND concrete_chore.[status]=3", c.ChildID);

                //Creates the SqlCommand and executes it
                command = new SqlCommand(query, DatabaseFunctions.DatabaseConnection);
                reader = command.ExecuteReader();

                //Reads all lines in the datareader
                while (reader.Read())
                {
                    int noget = (int)reader[0];
                    sumApproved++;
                }
                reader.Close();
                DatabaseFunctions.DatabaseConnection.Close();

                if ((sumOverdue + sumApproved) != 0)
                {
                    CR = (double)sumOverdue / (sumOverdue + sumApproved) * 100;
                    CR = 100 - Math.Round(CR);
                }
                else
                {
                    CR = 0;
                }

                CRrounded = (int)CR;

                result.Add(c.ChildID, CRrounded);
            }
            result = SortIntDics(result);
            return result;
        }

        public static Panel LoadTotalChoresApproved(Point location, int width, Dictionary<int, string> ChildrenNames, List<Model.ChildUser> ChildUsers)
        {
            Panel currentPanel = new Panel
            {
                Location = location,
                Width = width
            };
            int barDistance = 5;
            int locationY = 0;
            var totalChoresApproved = TotalChoresApproved(ChildUsers);
            var first = totalChoresApproved.First();
            int maxPoints = first.Value;

            foreach (KeyValuePair<int, int> score in totalChoresApproved)
            {
                var bar = AddProgressbar(score.Value, maxPoints);
                currentPanel.Controls.Add(bar);
                bar.Location = new Point(0, locationY);
                var label1 = AddLabel(score.Value.ToString(), false, bar.Width, locationY + 5);
                var label2 = AddLabel(ChildrenNames[score.Key], false, bar.Width + 50, locationY + 5);
                currentPanel.Controls.Add(label1);
                currentPanel.Controls.Add(label2);
                locationY += bar.Height + barDistance;
            }

            currentPanel.Height = locationY;
            return currentPanel;
        }

        private static Dictionary<int, int> TotalChoresApproved(List<Model.ChildUser> ChildUsers)
        {
            var result = new Dictionary<int, int>();

            foreach (Model.ChildUser c in ChildUsers)
            {
                int sum = 0;
                string query = string.Format("SELECT chore.chore_id FROM chore INNER JOIN concrete_chore ON " +
                    "chore.chore_id = concrete_chore.chore_id WHERE child_id={0} AND concrete_chore.[status]=3", c.ChildID);
                DatabaseFunctions.DatabaseConnection.Open();

                //Creates the SqlCommand and executes it
                SqlCommand command = new SqlCommand(query, DatabaseFunctions.DatabaseConnection);
                SqlDataReader reader = command.ExecuteReader();

                //Reads all lines in the datareader
                while (reader.Read())
                {
                    int noget = (int)reader[0];
                    sum++;
                }
                reader.Close();
                DatabaseFunctions.DatabaseConnection.Close();
                result.Add(c.ChildID, sum);
            }
            result = SortIntDics(result);
            return result;
        }

        public static Panel LoadTotalPoints(Point location, int width, Dictionary<int, string> ChildrenNames, List<Model.ChildUser> ChildUsers)
        {
            Panel currentPanel = new Panel
            {
                Location = location,
                Width = width
            };
            int barDistance = 5;
            int locationY = 0;
            var totalPoints = TotalPoints(ChildUsers);

            var first = totalPoints.First();
            int maxPoints = first.Value;

            foreach (KeyValuePair<int, int> score in totalPoints)
            {
                var bar = AddProgressbar(score.Value, maxPoints);
                currentPanel.Controls.Add(bar);
                bar.Location = new Point(0, locationY);
                var label1 = AddLabel(score.Value.ToString(), false, bar.Width, locationY + 5);
                var label2 = AddLabel(ChildrenNames[score.Key], false, bar.Width + 50, locationY + 5);
                currentPanel.Controls.Add(label1);
                currentPanel.Controls.Add(label2);
                locationY += bar.Height + barDistance;
            }

            currentPanel.Height = locationY;
            return currentPanel;
        }

        private static Dictionary<int, int> TotalPoints(List<Model.ChildUser> ChildUsers)
        {
            var result = new Dictionary<int, int>();

            foreach (Model.ChildUser child in ChildUsers)
            {
                int sum = 0;
                string query = string.Format("SELECT points FROM chore INNER JOIN concrete_chore ON " +
                    "chore.chore_id = concrete_chore.chore_id WHERE child_id={0} AND concrete_chore.[status]=3", child.ChildID);
                DatabaseFunctions.DatabaseConnection.Open();

                //Creates the SqlCommand and executes it
                SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.DatabaseConnection);
                SqlDataReader reader = cmd.ExecuteReader();

                //Reads all lines in the datareader
                while (reader.Read())
                {
                    sum += (int)reader[0];
                }
                reader.Close();
                DatabaseFunctions.DatabaseConnection.Close();
                result.Add(child.ChildID, sum);
            }
            result = SortIntDics(result);
            return result;
        }

        private static Dictionary<int, int> SortIntDics(Dictionary<int, int> input)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            foreach (KeyValuePair<int, int> points in input.OrderByDescending(key => key.Value))
            {
                result.Add(points.Key, points.Value);
            }
            return result;
        }

        private static ProgressBar AddProgressbar(int value, int maximum)
        {
            ProgressBar test = new ProgressBar
            {
                Maximum = maximum,
                Value = value,
                Name = "myProgressbar",
                Height = 25,
                Width = 250
            };
            return test;
        }

        private static Control AddLabel(string labelText, bool bold, int posX, int posY)
        {
            var label = new Label
            {
                Text = labelText,
                Location = new Point(posX, posY),
                AutoSize = true,
            };
            if (!bold)
            {
                label.Font = Properties.Settings.Default.StandardFont;
                return label;
            }
            if (bold)
            {
                label.Font = Properties.Settings.Default.StandardFontBold;
                return label;
            }
            return label;
        }
    }
}