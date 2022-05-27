using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("P227");
            student1.Name = "Elvin";
            student1.Surname = "Abbasov";

            Student student2 = new Student();



            Student student3 = new Student("Abbas", "Hikmetov", "P227", 45);

            student3.ShowInfo();

            //Console.WriteLine($"{student3.Name} {student3.Surname} {student3.GroupNo} {student3.Age}");

            Product product1 = new Product("Coca cola 1L")
            {
                DiscountPercent = 0,
                Price = 2
            };

            Product product2 = new Product("Milla 1L");
            product2.Price = 3;
            product2.DiscountPercent = 20;

            product1.Price = 5;
            product1.Price += 1;

            Product[] products = new Product[3];

            products[0] = product1;
            products[1] = product2;
            products[2] = new Product("Ayran 1L")
            {
                DiscountPercent = 30,
                Price = 20
            };

            Console.WriteLine("Products");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Name);
                Console.WriteLine(products[i].GetDiscountedPrice());
                //if (products[i].DiscountPercent > 0)
                //{
                //    var price = products[i].Price * (100 - products[i].DiscountPercent) / 100;
                //    Console.WriteLine(price);
                //}
                //else
                //{
                //    Console.WriteLine(products[i].Price);
                //}
            }


        }
    }
}
