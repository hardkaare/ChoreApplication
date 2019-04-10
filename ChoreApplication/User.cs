﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreApplication
{
    abstract class User
    {
        public string FirstName { get; protected set; }
        public int Pincode { get; protected set; }

        public User(string firstName, int pincode)
        {
            FirstName = firstName;
            Pincode = pincode;
        }

        
    }
}
