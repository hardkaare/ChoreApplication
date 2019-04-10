using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreApplication
{
    class User
    {
        public string FirstName { get; set; }
        public int Pincode { get; set; }

        public User(string firstName, int pincode)
        {
            FirstName = firstName;
            Pincode = pincode;
        }

        
    }
}
