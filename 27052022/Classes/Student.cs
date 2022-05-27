using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    internal class Student
    {
        public Student()
        {

        }
        public Student(string groupNo)
        {
            GroupNo = groupNo;
        }

        public Student(string name,string surname,string groupNo,byte age)
        {
            Name = name;
            Surname = surname;
            GroupNo = groupNo;
            Age = age;
        }


        public string Name;
        public string Surname;
        public string GroupNo;
        public byte Age;


        public void ShowInfo()
        {
            Console.WriteLine($"FullName: {Name} {Surname} - GroupNo: {GroupNo} - Age: {Age}");
        }
    }
}
