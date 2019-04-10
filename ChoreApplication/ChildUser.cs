using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreApplication
{
    class ChildUser : User
    {
        public int Points { get; set; }

        public ChildUser(string firstName, int pincode) : base(firstName, pincode)
        {
            Points = 0;
        }

        public override string ToString()
        {
            return $"{FirstName} has {Points} points.";
        }
    }
}
