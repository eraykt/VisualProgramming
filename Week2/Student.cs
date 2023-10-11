using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class Student : Person
    {
        private int year;

        public Student(string firstName, string lastName, string id, int year) : base(firstName, lastName, id)
        {
            this.year = year;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " year :" + year;
        }
    }
}
