using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ChoreApplication.Functions.ParentFunctions
{
    internal abstract class ChoreFunctions
    {
        private static Dictionary<int, string> _statusValues = new Dictionary<int, string>
            {
                { 1, "Active" },
                { 2, "Approval pending" },
            };

        private static Panel LoadChore(Model.Chore chore, Dictionary<int, string> _childrenNames, int width, int yLocation, string status, string type)
        {
            int yLoc = 5;
            int LabelDistance = 2;

            string choreName = chore.Name;
            string choreAssignment = "Assigned to: " + _childrenNames[chore.Assignment];
            string choreStatus = "Status: " + status;
            string choreType = "Type: " + type;

            var choreNameLabel = AddLabel(choreName, true, 5, yLoc);
            yLoc += choreNameLabel.Height + LabelDistance;
            var choreAssignmentLabel = AddLabel(choreAssignment, false, 10, yLoc);
            yLoc += choreNameLabel.Height + LabelDistance;
            var choreStatusLabel = AddLabel(choreStatus, false, 10, yLoc);
            yLoc += choreNameLabel.Height + LabelDistance;
            var choreTypeLabel = AddLabel(choreType, false, 10, yLoc);
            yLoc += choreNameLabel.Height + LabelDistance;
            var panelHeight = choreNameLabel.Height + choreAssignmentLabel.Height + choreStatusLabel.Height + choreTypeLabel.Height;

            Panel currentPanel = new Panel
            {
                Name = "panel" + chore.ID.ToString(),
                Location = new Point(1, yLocation),
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(width, panelHeight),
                AutoSize = true,
            };

            currentPanel.Controls.Add(choreNameLabel);
            currentPanel.Controls.Add(choreAssignmentLabel);
            currentPanel.Controls.Add(choreStatusLabel);
            currentPanel.Controls.Add(choreTypeLabel);

            currentPanel.Controls.Add(AddEditChoreButton(330, currentPanel.Height / 2, chore));
            currentPanel.Controls.Add(AddDeleteChoreButton(365, currentPanel.Height / 2, chore));

            return currentPanel;
        }

        public static Panel LoadRepeatableChore(Model.Repeatable chore, Dictionary<int, string> _childrenNames, int width, int yLocation)
        {
            string status = "Active";
            string type = "Repeatable";

            Panel currentPanel = LoadChore(chore, _childrenNames, width, yLocation, status, type);

            return currentPanel;
        }

        public static Panel LoadReocurringChore(Model.Reocurring chore, Dictionary<int, string> _childrenNames, int width, int yLocation)
        {
            string status = "Active";
            string type = "Reocurring";

            Panel currentPanel = LoadChore(chore, _childrenNames, width, yLocation, status, type);

            return currentPanel;
        }

        public static Panel LoadConcreteChore(Model.Concrete chore, Dictionary<int, string> _childrenNames, int width, int yLocation)
        {
            string status = _statusValues[chore.Status];
            string type = "Concrete";

            Panel currentPanel = LoadChore(chore, _childrenNames, width, yLocation, status, type);

            return currentPanel;
        }

        private static Control AddApproveChoreButton(int locationX, int locationY, Model.Chore chore)
        {
            var approveButton = new Button
            {
                Location = new Point(locationX, locationY - 15),
                Size = new Size(30, 30),
                Tag = chore,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.thumbs_up,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            approveButton.Cursor = Cursors.Hand;
            approveButton.FlatAppearance.BorderSize = 0;
            approveButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
            approveButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            approveButton.Click += new EventHandler(ApproveChoreButton_Click);
            return approveButton;
        }

        private static Control AddDenyChoreButton(int locationX, int locationY, Model.Chore chore)
        {
            var denyButton = new Button
            {
                Location = new Point(locationX, locationY - 15),
                Size = new Size(30, 30),
                Tag = chore,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.thumb_down,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            denyButton.Cursor = Cursors.Hand;
            denyButton.FlatAppearance.BorderSize = 0;
            denyButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
            denyButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            denyButton.Click += new EventHandler(DenyChoreButton_Click);
            return denyButton;
        }

        private static Control AddEditChoreButton(int locationX, int locationY, Model.Chore chore)
        {
            var editChoreButton = new Button
            {
                Location = new Point(locationX, locationY - 15),
                Size = new Size(30, 30),
                Tag = chore,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.pencil,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            editChoreButton.Cursor = Cursors.Hand;
            editChoreButton.FlatAppearance.BorderSize = 0;
            editChoreButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            editChoreButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            editChoreButton.Click += new EventHandler(EditChoreButton_Click);
            return editChoreButton;
        }

        private static Control AddDeleteChoreButton(int locationX, int locationY, Model.Chore chore)
        {
            var deleteChoreButton = new Button
            {
                Location = new Point(locationX, locationY - 15),
                Size = new Size(30, 30),
                Tag = chore,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = global::ChoreApplication.Properties.Resources.delete,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };
            deleteChoreButton.Cursor = Cursors.Hand;
            deleteChoreButton.FlatAppearance.BorderSize = 0;
            deleteChoreButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            deleteChoreButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;
            deleteChoreButton.Click += new EventHandler(DeleteChoreButton_Click);
            return deleteChoreButton;
        }

        private static void ApproveChoreButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Model.Concrete currentChore = (Model.Concrete)clickedButton.Tag;
            currentChore.Status = 3;
            currentChore.ApprovalDate = DateTime.Now;
            currentChore.Update();

            var currentChild = Model.ChildUser.Load("child_id=" + currentChore.Assignment);
            currentChild[0].Points += currentChore.Points;
            currentChild[0].Update();
            Model.Notification.Insert(currentChild[0].ID, "Chore Approved", $"The chore {currentChore.Name} has been approved." +
                $"\n{currentChore.Points.ToString()} points has been added to your account");
            //LoadAmountOfNotifications();
            //LoadChores();
        }

        private static void DenyChoreButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Model.Concrete currentChore = (Model.Concrete)clickedButton.Tag;
            var currentChild = Model.ChildUser.Load("child_id=" + currentChore.Assignment);

            if (currentChore.Type == "rep")
            {
                currentChore.Delete();
            }
            else
            {
                currentChore.DueDate = DateTime.Now.AddDays(1);
                currentChore.Status = 1;
                currentChore.Reminder = 0;
                currentChore.Update();
            }
            Model.Notification.Insert(currentChild[0].ID, "Chore Denied", $"The chore {currentChore.Name} has been denied.");
            //LoadAmountOfNotifications();
            //LoadChores();
        }

        private static void EditChoreButton_Click(object sender, System.EventArgs e)
        {
            //this.Enabled = false; //Disable ParentUI
            Button clickedButton = (Button)sender;
            try
            {
                Model.Concrete selectedChore = (Model.Concrete)clickedButton.Tag;
                var editSelectedChoreUI = new UI.ParentUI.EditChoreUI(selectedChore);
                editSelectedChoreUI.Show();
                //editSelectedChoreUI.FormClosing += ChoreNavigationButton_Click;
            }
            catch
            {
                try
                {
                    Model.Reocurring selectedChore = (Model.Reocurring)clickedButton.Tag;
                    var editSelectedChoreUI = new UI.ParentUI.EditChoreUI(selectedChore);
                    editSelectedChoreUI.Show();
                    //editSelectedChoreUI.FormClosing += ChoreNavigationButton_Click;
                }
                catch
                {
                    try
                    {
                        Model.Repeatable selectedChore = (Model.Repeatable)clickedButton.Tag;
                        var editSelectedChoreUI = new UI.ParentUI.EditChoreUI(selectedChore);
                        editSelectedChoreUI.Show();
                        //editSelectedChoreUI.FormClosing += ChoreNavigationButton_Click;
                    }
                    catch
                    {
                        MessageBox.Show("Could not edit chore: Conversion failed", "Error");
                    }
                }
            }
        }

        private static void DeleteChoreButton_Click(object sender, System.EventArgs e)
        {
            Button clickedButton = (Button)sender;
            var confirmDelete = MessageBox.Show("Are you sure you want to delete this chore?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                try
                {
                    Model.Concrete selectedChore = (Model.Concrete)clickedButton.Tag;
                    selectedChore.Delete();
                    //LoadChores();
                }
                catch
                {
                    try
                    {
                        Model.Reocurring selectedChore = (Model.Reocurring)clickedButton.Tag;
                        selectedChore.Delete();
                        //LoadChores();
                    }
                    catch
                    {
                        try
                        {
                            Model.Repeatable selectedChore = (Model.Repeatable)clickedButton.Tag;
                            selectedChore.Delete();
                            //LoadChores();
                        }
                        catch
                        {
                            MessageBox.Show("Could not delete selected chore: Conversion failed", "Error");
                        }
                    }
                }
            }
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