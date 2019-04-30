using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoreApplication.UI
{
    public partial class CreateRewardUI : Form
    {
        public CreateRewardUI()
        {
            InitializeComponent();
            LoadChildren();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadChildren()
        {
            var children = ChildUser.Load("");
          
            foreach (var name in children)
            {
                this.Assignment.Items.Add(name.FirstName);
            }
        }

        private void CreateReward_Click(object sender, EventArgs e)
        {
            var children = ChildUser.Load("");
            int id = 0;
            for (int i = 0; i < children.Count; i++)
            {
                if (children[i].FirstName == Assignment.Text)
                {
                    id = children[i].ChildId;
                }
            }
            //Reward.Insert
        }
    }
}
