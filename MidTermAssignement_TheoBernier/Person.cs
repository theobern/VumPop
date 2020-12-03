using System;
using System.Collections.Generic;
using System.Text;

namespace MidTermAssignement_TheoBernier
{
    class Person
    {
        string firstName;
        string lastName;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FullName()
        {
            return this.firstName + " " + this.lastName;
        }

    }
}
