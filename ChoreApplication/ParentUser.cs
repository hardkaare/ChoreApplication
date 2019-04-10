using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreApplication
{
    class ParentUser : User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Lastname { get; set; }

        public ParentUser(string email, string password, string lastName, string firstName, int pincode) : base(firstName, pincode)
        {
            Email = email;
            Password = password;
            Lastname = lastName;

        }

        public override string ToString()
        {
            return $"Parent with the last name {Lastname} has registered with E-mail: {Email} and password {Password}.";
        }
    }


}
