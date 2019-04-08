using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreApplication
{
    class Concrete : Chore
    {
        //Properties
        private string dueDate { get; set; }
        private string status { get; set; }
        private string approvalDate { get; set; }

        //Constructor
        public Concrete(string _dueDate, string _status, string _approvalDate) : 
            base("Rengør værelse", "Der skal ryddes op, tørres støv af og støvsuges", 10, "Mikkel")
        {
            dueDate = _dueDate;
            status = _status;
            approvalDate = _approvalDate;
        }

    }
}
