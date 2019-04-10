using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreApplication
{
    class ParentUser : User
    {
        #region Properties
        // The following properties can only be set from the derived classes but everyone can get it. (reconsider this later.)
   
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public string Lastname { get; protected set; }

        #endregion

        #region Constructors

        public ParentUser(string email, string password, string lastName, string firstName, int pincode) : base(firstName, pincode)
        {
            Email = email;
            Password = password;
            Lastname = lastName;

        }

        #endregion

        #region Public Helpers
        public override string ToString()
        {
            return $"Parent with the last name {Lastname} has registered with E-mail: {Email} and password {Password}.";
        }

        #endregion

        #region Private Helpers
        #endregion
    }


}
