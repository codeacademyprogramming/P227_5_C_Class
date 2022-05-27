using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Human
    {
        public Human()
        {
            Age = 10;
        }

        public Human(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name;
        public string Surname;
        public byte Age;


        public void ShowInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");
        }

        public string GetFullName()
        {
            string fullName =  Name + " " + Surname;
            return fullName;
        }
    }
}
