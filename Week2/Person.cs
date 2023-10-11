using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class Person
    {
        protected string firstName;
        protected string lastName;
        protected string id;

        public string FirstName => firstName;
        public string LastName => lastName;

        public Person(string firstName, string lastName, string id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        }

        public virtual string GetInfo()
        {
            return "First name: " + firstName + " Last name: " + lastName;
        }
    }
}
