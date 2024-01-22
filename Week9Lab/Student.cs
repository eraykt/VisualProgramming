using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9Lab
{
    public class Student
    {
        public string name;
        public int grade;

        public override string ToString()
        {
            return name + ":" + grade;
        }
    }
}
