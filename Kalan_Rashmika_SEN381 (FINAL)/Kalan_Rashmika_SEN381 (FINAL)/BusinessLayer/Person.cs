using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public abstract class Person
    {
        private string firstName, lastName, phone, email;
        private string iD;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string ID { get => iD; set => iD = value; }

        public Person()
        {

        }

        public Person(string iD,string fname, string lname, string phone, string email)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.phone = phone;
            this.email = email;
            this.iD = iD;
        }

        public Person(string fname, string lname, string phone, string email)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.phone = phone;
            this.email = email;
        }

        protected Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }

}
