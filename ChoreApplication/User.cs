﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChoreApplication
{
    public abstract class User
    {
        #region Properties
        
        public int Id { get; private set; }

        // Derived classes can set the firstname and the public can get it. 
        public string FirstName { get; protected set; }

        // Everyone can get the pincode (reconsider this later). Derived classes can set it.
        public string Pincode { get; protected set; }

        #endregion

        #region Constructors

        // The base constructor for ParentUser and ChildUser. Makes sure every object of ParentUser and ChildUser has a firstname and pincode.
        public User(int id, string firstName, string pincode)
        {
            Id = id;
            FirstName = firstName;
            Pincode = pincode;
        }
        #endregion
        #region Public methods
        
        #endregion
    }
}
