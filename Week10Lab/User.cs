using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Lab
{
    public class User
    {
        public int id;
        public string email;
        public string password;
        public string name;
        public string adress;
        public int age;

        public User(string email, string password, string name, string adress, int age)
        {
            this.email = email;
            this.password = password;
            this.name = name;
            this.adress = adress;
            this.age = age;
        }
    }
}
