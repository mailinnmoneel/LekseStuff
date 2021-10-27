using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LekseStuff
{
    class Person
    {
        public string Name;
        public string Email;
        public int Age;


        public Adress Adress1; //NB!

        public Person(string name, string email, int age, Adress adress)
        {
            Name = name;
            Email = email;
            Age = age;
            Adress1 = adress;
        }
    }
}
