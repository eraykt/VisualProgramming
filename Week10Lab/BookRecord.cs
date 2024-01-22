using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Lab
{
    public class BookRecord
    {
        public int id;
        public int userid;
        public string name;
        public string author;
        public int pageCount;

        public BookRecord(string name, string author, int pageCount)
        {
            this.name = name;
            this.author = author;
            this.pageCount = pageCount;
        }
    }
}
