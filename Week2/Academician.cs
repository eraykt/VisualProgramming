using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class Academician : Person
    {
        private string branch;

        public Academician(string firstName, string lastName, string id, string branch) : base(firstName, lastName, id)
        {
            this.branch = branch;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " Branch: " + branch;
        }

    }
}
