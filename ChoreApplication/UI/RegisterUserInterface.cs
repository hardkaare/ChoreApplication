using System;
using System.Windows.Forms;

namespace ChoreApplication.UI
{
    public partial class RegisterUserInterface : Form
    {
        public RegisterUserInterface()
        {
            InitializeComponent();
        }

        private void RegisterUserInterface_Load(object sender, EventArgs e)
        {
        }

        private void UploadPictureBox_Click(object sender, EventArgs e)
        {
            UploadPicture();
        }

        /// <summary>
        /// Visning af tooltip når picturebox hovererers
        /// </summary>
        private void UploadPictureBox_Hover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.Show("Click to upload picture", this, uploadPictureBox.Location.X, uploadPictureBox.Location.Y + 60, 3000);
        }

        private void UploadPicture()
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png|All files(*.*)|*.*"
                };

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var imageLocation = dialog.FileName;
                    uploadPictureBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void RegisterUser_Click(object sender, EventArgs e)
        {

        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}