using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace University
{
    public abstract class User
    {
        private string firstName;
        private string lastName;
        private string password;
        private string email;
        private int id;

        public User()
        {

        }

        public User(string fn, string ln, string p, string e, int i)
        {
            firstName = fn;
            lastName = ln;
            password = p;
            email = e;
            id = i;
        }

        public string FullName { get { return firstName + " " + lastName; } }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Id
        {
            get { return id; }

        }

        public override string ToString()
        {
            string result = "";
            result += FullName;
            result += "\n";
            result += $"email: {email}";

            return result;

        }
    }
}
