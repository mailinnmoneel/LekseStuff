using System;
using System.Collections.Generic;

namespace LekseStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var adress1 = new Adress("Tullekoppveien", 64, 3158, "Andebu");
            var adress2 = new Adress("Sjakkmesterveien,", 69, 3238, "Larvik");
            Person person1 = new Person("Marie", "marie@getacademy.no", 32, adress1);
            Person person2 = new Person("Terje", "Terje@getacademy.no", 42, adress2);

            List<Person> awesomepersons = new List<Person>();
            awesomepersons.Add(person1);
            awesomepersons.Add(person2);
         

            PrintMethod(awesomepersons);
        }

         static public void PrintMethod( List<Person> awesomepersons)
        {
            foreach (Person People in awesomepersons) 
            {
                Console.WriteLine($"Hello, my name is {People.Name}!");
                Console.WriteLine($"I am {People.Age} years old, and i live in {People.Adress1.FullAdress}"); //Husk å dotte masse :) 
                Console.WriteLine($"my email address is: {People.Email}");
            }
        }
    }
}
