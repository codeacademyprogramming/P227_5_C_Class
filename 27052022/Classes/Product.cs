using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    internal class Product
    {

        public Product(string name)
        {
            Name = name;
        }


        public string Name;
        public double Price;
        public double DiscountPercent;

        public double GetDiscountedPrice()
        {
            if (DiscountPercent > 0)
            {
                var discountedPrice = Price * (100 - DiscountPercent) / 100;
                return discountedPrice;
            }
            else
            {
                return Price;
            }
        }
    }
}
