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
    public partial class EditChoreUI : Form
    {
        private Chore _chore;
        private int _choreType = 0;
        public EditChoreUI(Chore chore)
        {
            InitializeComponent();
            _chore = ChoreType(chore);

            switch (_choreType)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
         

        }
        
        public Chore ChoreType(Chore chore)
        {
            if(chore.GetType() == typeof(Concrete))
            {
                // do shit.
                MessageBox.Show("Concrete.");
                _choreType = 1;
                return (Concrete)chore;
            }
            else if(chore.GetType() == typeof(Reocurring))
            {
                // do some other shit.
                MessageBox.Show("Reoc.");
                _choreType = 2;
                return (Reocurring)chore;
            }
            else if(chore.GetType() == typeof(Repeatable))
            {
                // do some third shit. 
                MessageBox.Show("Rep.");
                _choreType = 3;
                return (Repeatable)chore;
            }
            else
            {
                return null;
            }
        }

    }
}
