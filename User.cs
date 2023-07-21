using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17version1._1
{
    internal class User
    {
        public User(string LastName, string Name, string MiddleName, string NumberTelephone, string Email)
        {
            this.lastName = LastName;
            this.name = Name;
            this.middleName = MiddleName;
            this.number = NumberTelephone;
            this.email = Email;
        }
        public User() { }
        public int ModelSQLID { get; set; }
        private string lastName;
        private string name;
        private string middleName;
        private string number;
        private string email;
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string MiddleName { get { return middleName; } set { middleName = value; } }
        public string NumberTelephone { get { return number; } set { number = value; } }
        public string Email { get { return email; } set { email = value; } }
    }
}
