using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChoreApplication.Functions
{
    /// <summary>
    /// This class contains static methods for loading or creating various UI clusters that are shared for both child and parent UI.
    /// This includes notifications and leaderboard. Shared UI clusters that contain event handlers are not included here.
    /// </summary>
    internal abstract class UIFunctions
    {

        #region Notification

        /// <summary>
        /// Creates a panel for a single notification. Adds a label for title and description.
        /// </summary>
        /// <param name="notification">The notification that is to be displayed</param>
        /// <param name="width">Width of the returned panel</param>
        /// <param name="yLocation">Y-location for the returned panel</param>
        /// <returns>Panel to show in UI</returns>
        public static Panel LoadNotification(Model.Notification notification, int width, int yLocation)
        {
            int labelDistance = 0;
            int yLoc = 5;

            //Defines title and description
            var notificationTitle = notification.Title;
            var notificationDescription = notification.Description;

            //Makes a label for title and description
            var notificationTitleLabel = UI.UILibrary.StandardElements.AddLabel(notificationTitle, true, new Point(5, yLoc));
            yLoc += notificationTitleLabel.Height + labelDistance;
            var notificationDescriptionLabel = UI.UILibrary.StandardElements.AddLabel(notificationDescription, false, new Point(10, yLoc));

            //Creates the panel
            var panelHeight = notificationTitleLabel.Height + notificationDescriptionLabel.Height;
            var individualNotificationPanel = UI.UILibrary.StandardElements.AddPanel(new Point(1, yLocation), width, panelHeight);

            //Adds labels to panel
            individualNotificationPanel.Controls.Add(notificationTitleLabel);
            individualNotificationPanel.Controls.Add(notificationDescriptionLabel);

            return individualNotificationPanel;
        }

        #endregion

        #region Leaderboard

        /// <summary>
        /// Creates a panel for the longest streak statistic with a progress bar and each child displayed.
        /// </summary>
        /// <param name="location">Location of the returned panel</param>
        /// <param name="width">Width  of the returned panel</param>
        /// <param name="ChildrenNames">Dictionary with each child's ID and associated name</param>
        /// <param name="ChildUsers">List of all child users</param>
        /// <returns></returns>
        public static Panel LoadLongestStreak(Point location, int width, Dictionary<int, string> ChildrenNames, List<Model.ChildUser> ChildUsers)
        {
            //Create the panel
            Panel currentPanel = new Panel
            {
                Location = location,
                Width = width
            };

            //Set relative locations/distances
            int barDistance = 5;
            int locationY = 0;

            //Calculates the longest streak for each child and associates the value with the child's ID
            var longestStreak = LongestStreak(ChildUsers);

            //Defines the best streak
            var first = longestStreak.First();
            int maxValue = first.Value;

            //Creates and displays a progressbar and label for each child
            foreach (KeyValuePair<int, int> score in longestStreak)
            {
                //Progressbar value is set to the child's streak compared to the highest streak amongst the children 
                var bar = AddProgressbar(score.Value, maxValue, locationY);
                currentPanel.Controls.Add(bar);

                //The child's score and name are added as labels
                var label1 = UI.UILibrary.StandardElements.AddLabel(score.Value.ToString(), false, new Point(bar.Width, locationY + 5));
                var label2 = UI.UILibrary.StandardElements.AddLabel(ChildrenNames[score.Key], false, new Point(bar.Width + 50, locationY + 5));
                currentPanel.Controls.Add(label1);
                currentPanel.Controls.Add(label2);
                locationY += bar.Height + barDistance;
            }

            currentPanel.Height = locationY;
            return currentPanel;
        }

        /// <summary>
        /// Calculates the longest streak for each child in the given list.
        /// </summary>
        /// <param name="ChildUsers">List of childusers to calculate</param>
        /// <returns>A dictionary<int, int> with child ID as key and longest streak as value</returns>
        private static Dictionary<int, int> LongestStreak(List<Model.ChildUser> ChildUsers)
        {
            var result = new Dictionary<int, int>();

            //Calculates score
            foreach (Model.ChildUser child in ChildUsers)
            {
                //Defines longest and current streak
                int longestStreak = 0;
                int currentStreak = 0;

                //Creates query that selects all the child's chores that are approved or overdue, ordered by date
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

                    //If the chores is approved currentStreak is incremented
                    if (status == 3)
                    {
                        currentStreak++;

                        //If currentStreak is higher than it's been before longestStreak is set
                        if (currentStreak > longestStreak)
                        {
                            longestStreak = currentStreak;
                        }
                    }
                    else
                    {
                        //Resets currentStreak if an overdue chore occures
                        currentStreak = 0;
                    }
                }
                //Clean up
                reader.Close();
                DatabaseFunctions.DatabaseConnection.Close();

                result.Add(child.ChildID, longestStreak);
            }

            //Sorts the dictionary by value and returns it
            result = SortIntDics(result);
            return result;
        }

        /// <summary>
        /// Creates a panel for the completion rate statistic with a progress bar and each child displayed.
        /// </summary>
        /// <param name="location">Location of the returned panel</param>
        /// <param name="width">Width  of the returned panel</param>
        /// <param name="ChildrenNames">Dictionary with each child's ID and associated name</param>
        /// <param name="ChildUsers">List of all child users</param>
        /// <returns>Panel</returns>
        public static Panel LoadCompletionRate(Point location, int width, Dictionary<int, string> ChildrenNames, List<Model.ChildUser> ChildUsers)
        {
            //Create the panel
            Panel currentPanel = new Panel
            {
                Location = location,
                Width = width
            };

            //Sets relative location of progressbars
            int barDistance = 5;
            int locationY = 0;

            //Loads a dictionary with calculated completionrate for each child
            var completionRateApproved = CompletionRateApproved(ChildUsers);

            //Displays a progressbar for each child in the dictionary
            foreach (KeyValuePair<int, int> score in completionRateApproved)
            {
                //Adds a progressbar with data displayed in percentages
                var bar = AddProgressbar(score.Value, 100, locationY);
                currentPanel.Controls.Add(bar);

                //Adds labels with the current childs name and completion rate
                var label1 = UI.UILibrary.StandardElements.AddLabel(score.Value.ToString() + "%", false, new Point(bar.Width, locationY + 5));
                var label2 = UI.UILibrary.StandardElements.AddLabel(ChildrenNames[score.Key], false, new Point(bar.Width + 50, locationY + 5));
                currentPanel.Controls.Add(label1);
                currentPanel.Controls.Add(label2);
                locationY += bar.Height + barDistance;
            }

            currentPanel.Height = locationY;
            return currentPanel;
        }

        /// <summary>
        /// Calculates the completion rate for each child in the list in percentage
        /// </summary>
        /// <param name="ChildUsers">List of the child users</param>
        /// <returns>Dictionary with each child's ID and associated CR</returns>
        private static Dictionary<int, int> CompletionRateApproved(List<Model.ChildUser> ChildUsers)
        {
            //Creates the dictionary with child ID as key and CR as value
            var result = new Dictionary<int, int>();

            //Calculates CR for each child and adds to the dictionary
            foreach (Model.ChildUser c in ChildUsers)
            {
                double CR;
                int sumOverdue = 0;
                int sumApproved = 0;
                int CRrounded;

                //Defines a query that selects all the child's overdue chores
                string query = string.Format("SELECT chore.chore_id FROM chore INNER JOIN concrete_chore ON " +
                    "chore.chore_id = concrete_chore.chore_id WHERE child_id={0} AND concrete_chore.[status]=4", c.ChildID);
                DatabaseFunctions.DatabaseConnection.Open();

                //Creates the SqlCommand and executes it
                SqlCommand command = new SqlCommand(query, DatabaseFunctions.DatabaseConnection);
                SqlDataReader reader = command.ExecuteReader();

                //Reads all lines in the datareader and increments sumOverdue
                while (reader.Read())
                {
                    int noget = (int)reader[0];
                    sumOverdue++;
                }
                reader.Close();

                //Defines a query that selects all the child's approved chores
                query = string.Format("SELECT chore.chore_id FROM chore INNER JOIN concrete_chore ON " +
                    "chore.chore_id = concrete_chore.chore_id WHERE child_id={0} AND concrete_chore.[status]=3", c.ChildID);

                //Creates the SqlCommand and executes it
                command = new SqlCommand(query, DatabaseFunctions.DatabaseConnection);
                reader = command.ExecuteReader();

                //Reads all lines in the datareader and increments sumApproved
                while (reader.Read())
                {
                    int noget = (int)reader[0];
                    sumApproved++;
                }
                reader.Close();
                DatabaseFunctions.DatabaseConnection.Close();

                //Calculates CR as int
                if ((sumOverdue + sumApproved) != 0)
                {
                    //Calculates CR and casts it as a double
                    CR = (double)sumOverdue / (sumOverdue + sumApproved) * 100;

                    //Rounds CR and subtracts from 100
                    CR = 100 - Math.Round(CR);
                }

                //If no chores are completed CR is set to 0
                else
                {
                    CR = 0;
                }

                //Casts rounded CR as int and adds to dictionary
                CRrounded = (int)CR;
                result.Add(c.ChildID, CRrounded);
            }
            result = SortIntDics(result);
            return result;
        }

        /// <summary>
        /// Creates a panel for the total chores approved statistic with a progress bar and each child displayed.
        /// </summary>
        /// <param name="location">Location of the returned panel</param>
        /// <param name="width">Width  of the returned panel</param>
        /// <param name="ChildrenNames">Dictionary with each child's ID and associated name</param>
        /// <param name="ChildUsers">List of all child users</param>
        /// <returns>Panel</returns>
        public static Panel LoadTotalChoresApproved(Point location, int width, Dictionary<int, string> ChildrenNames, List<Model.ChildUser> ChildUsers)
        {
            //Creates the panel
            Panel currentPanel = new Panel
            {
                Location = location,
                Width = width
            };

            //Sets relative locations for progressbars
            int barDistance = 5;
            int locationY = 0;

            //Calculates how many chores each child has done
            var totalChoresApproved = TotalChoresApproved(ChildUsers);

            //Finds the highest amount of chores a child has completed
            var first = totalChoresApproved.First();
            int maxPoints = first.Value;

            //Displays a progressbar for each child
            foreach (KeyValuePair<int, int> score in totalChoresApproved)
            {
                //Adds a progressbar for the child with data comparing it's TCA to the best child's TCA
                var bar = AddProgressbar(score.Value, maxPoints, locationY);
                currentPanel.Controls.Add(bar);

                //Adds a label with the child's TCA and name
                var label1 = UI.UILibrary.StandardElements.AddLabel(score.Value.ToString(), false, new Point(bar.Width, locationY + 5));
                var label2 = UI.UILibrary.StandardElements.AddLabel(ChildrenNames[score.Key], false, new Point(bar.Width + 50, locationY + 5));
                currentPanel.Controls.Add(label1);
                currentPanel.Controls.Add(label2);
                locationY += bar.Height + barDistance;
            }

            currentPanel.Height = locationY;
            return currentPanel;
        }

        /// <summary>
        /// Counts the amount of approved chores for each child
        /// </summary>
        /// <param name="ChildUsers">List of child users to count chores for</param>
        /// <returns>Dictionary with each child's ID and associated TCA</returns>
        private static Dictionary<int, int> TotalChoresApproved(List<Model.ChildUser> ChildUsers)
        {
            //Declares the dictionary with results. Key is child ID and value is TCA.
            var result = new Dictionary<int, int>();

            //Counts TCA and adds to dictionary
            foreach (Model.ChildUser c in ChildUsers)
            {
                int sum = 0;

                //Query that selects all the child's approved chores
                string query = string.Format("SELECT chore.chore_id FROM chore INNER JOIN concrete_chore ON " +
                    "chore.chore_id = concrete_chore.chore_id WHERE child_id={0} AND concrete_chore.[status]=3", c.ChildID);
                DatabaseFunctions.DatabaseConnection.Open();

                //Creates the SqlCommand and executes it
                SqlCommand command = new SqlCommand(query, DatabaseFunctions.DatabaseConnection);
                SqlDataReader reader = command.ExecuteReader();

                //Reads all lines in the datareader and increments sum
                while (reader.Read())
                {
                    int noget = (int)reader[0];
                    sum++;
                }
                reader.Close();
                DatabaseFunctions.DatabaseConnection.Close();
                result.Add(c.ChildID, sum);
            }

            //Sorts the dictionary after value
            result = SortIntDics(result);
            return result;
        }

        /// <summary>
        /// Creates a panel for the total points earned statistic with a progress bar and each child displayed.
        /// </summary>
        /// <param name="location">Location of the returned panel</param>
        /// <param name="width">Width  of the returned panel</param>
        /// <param name="ChildrenNames">Dictionary with each child's ID and associated name</param>
        /// <param name="ChildUsers">List of all child users</param>
        /// <returns>Panel</returns>
        public static Panel LoadTotalPoints(Point location, int width, Dictionary<int, string> ChildrenNames, List<Model.ChildUser> ChildUsers)
        {
            //Creates the panel
            Panel currentPanel = new Panel
            {
                Location = location,
                Width = width
            };

            //Sets relative location for each progressbar
            int barDistance = 5;
            int locationY = 0;

            //Loads dictionary with each child and their TPE
            var totalPoints = TotalPoints(ChildUsers);

            //Sets the highest amount of points a child has earned
            var first = totalPoints.First();
            int maxPoints = first.Value;

            //Displays a progressbar for each child
            foreach (KeyValuePair<int, int> score in totalPoints)
            {
                //Adds the progressbar comparing the childs TPE to the best child's TPE
                var bar = AddProgressbar(score.Value, maxPoints, locationY);
                currentPanel.Controls.Add(bar);

                //Adds a label with the childs TPE and name
                var label1 = UI.UILibrary.StandardElements.AddLabel(score.Value.ToString(), false, new Point(bar.Width, locationY + 5));
                var label2 = UI.UILibrary.StandardElements.AddLabel(ChildrenNames[score.Key], false, new Point(bar.Width + 50, locationY + 5));
                currentPanel.Controls.Add(label1);
                currentPanel.Controls.Add(label2);
                locationY += bar.Height + barDistance;
            }

            currentPanel.Height = locationY;
            return currentPanel;
        }

        /// <summary>
        /// Calculates each child total points earned.
        /// </summary>
        /// <param name="ChildUsers">List of child users to calculate TPA</param>
        /// <returns>Dictionary with each child's ID and TPA</returns>
        private static Dictionary<int, int> TotalPoints(List<Model.ChildUser> ChildUsers)
        {
            //Declares the dictionary with ID as key and value as TPA
            var result = new Dictionary<int, int>();

            //Calculates TPA for each child and adds to dictionary
            foreach (Model.ChildUser child in ChildUsers)
            {
                int sum = 0;

                //Query that selects points for all approved chores the child has done
                string query = string.Format("SELECT points FROM chore INNER JOIN concrete_chore ON " +
                    "chore.chore_id = concrete_chore.chore_id WHERE child_id={0} AND concrete_chore.[status]=3", child.ChildID);
                DatabaseFunctions.DatabaseConnection.Open();

                //Creates the SqlCommand and executes it
                SqlCommand cmd = new SqlCommand(query, DatabaseFunctions.DatabaseConnection);
                SqlDataReader reader = cmd.ExecuteReader();

                //Reads all lines in the datareader and adds points to sum
                while (reader.Read())
                {
                    sum += (int)reader[0];
                }
                reader.Close();
                DatabaseFunctions.DatabaseConnection.Close();
                result.Add(child.ChildID, sum);
            }

            //Sorts dictionary by value
            result = SortIntDics(result);
            return result;
        }

        /// <summary>
        /// Method that sorts a dictionary<int, int> by value
        /// </summary>
        /// <param name="input">Dictionary to be sorted</param>
        /// <returns>Sorted dictionary</returns>
        private static Dictionary<int, int> SortIntDics(Dictionary<int, int> input)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            //Adds a key/value pair to a new dictionary, starting with the highest value
            foreach (KeyValuePair<int, int> points in input.OrderByDescending(key => key.Value))
            {
                result.Add(points.Key, points.Value);
            }
            return result;
        }

        /// <summary>
        /// Creates a progressbar with predefined size
        /// </summary>
        /// <param name="value">Value of the progressbar</param>
        /// <param name="maximum">Maximum value of progressbar</param>
        /// <returns>Progressbar</returns>
        private static ProgressBar AddProgressbar(int value, int maximum, int yLoc)
        {
            ProgressBar pb = new ProgressBar
            {
                Maximum = maximum,
                Value = value,
                Name = "myProgressbar",
                Height = 25,
                Width = 250,
                Location = new Point(0, yLoc)
        };
            return pb;
        }

        #endregion

    }
}