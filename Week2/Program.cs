using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("herhangibir", "adam", "3");
            Student s1 = new Student("a", "b", "1", 2);
            Academician a1 = new Academician("beran", "bayar", "0", "tiyatro");

            //Console.WriteLine(p1.GetInfo());
            //Console.WriteLine(s1.GetInfo());
            //Console.WriteLine(a1.GetInfo());

            CompareNames(s1, a1);
        }

        static void CompareNames(Person p1, Person p2)
        {
            if (p1.FirstName.Length > p2.FirstName.Length)
            {
                Console.WriteLine(p1.FirstName + " daha uzun.");
            }

            else if (p1.LastName.Length == p2.LastName.Length)
            {
                Console.WriteLine("iki isim de esit.");
            }

            else
            {
                Console.WriteLine(p2.FirstName + " daha uzun.");
            }
        }
    }
}
