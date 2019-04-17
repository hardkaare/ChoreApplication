using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChoreApplication
{

    class ChoreUI
    {
        public ParentInterface UI = new ParentInterface();


        public ChoreUI()
        {
            UI.dynamicPanel1.BackColor = System.Drawing.Color.AliceBlue;
        }

        public void InitializeUI()
        {
            UI.ResetUI();
            
        }
    }


}
