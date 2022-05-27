using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Abbas", "Hikmet", "Nezrin", "Zehra"};
            string[] surnames = { "Ceferov", "Abbasov", "Abbasqizi", "Abbaszade" };
            byte[] ages = new byte[] { 45, 10, 34, 50 };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]} {surnames[i]} {ages[i]}");
            }

            string word = "Hello";
            int age = 55;
            char letter = 'A';

            //Human human1 = new Human();

            //human1.Name = "Abbas";
            //human1.Surname = "Abbasov";
            //human1.Age = 55;

            //Human human1 = new Human()
            //{
            //    Name = "Abbas",
            //    Surname = "Abbasov",
            //    Age = 55
            //};

            Human human1 = new Human();
            human1.Name = "Abdulla";
            human1.Surname = "Soyadsiz";


            Console.WriteLine(human1.Name);
            Console.WriteLine(human1.Surname);
            Console.WriteLine(human1.Age);

            Human[] humans = new Human[5];


            humans[0] = human1;

            humans[1] = new Human()
            {
                Name = "Nezrin",
                Surname = "Abbaszade",
                Age = 39
            };

            humans[2] = new Human();

            humans[2].Name = "Totu";
            humans[2].Surname = "Abbasoglu";
            humans[2].Age = 78;

            for (int i = 0; i < humans.Length; i++)
            {
                if (humans[i] != null)
                    Console.WriteLine(humans[i].GetFullName());
            }

            Console.WriteLine("==================================================");
            Human human5 = new Human("Abbas","Qulamov");
            Console.WriteLine(human5.GetFullName());

        }
    }
}
