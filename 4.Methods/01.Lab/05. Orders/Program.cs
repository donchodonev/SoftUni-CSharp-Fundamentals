using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"{PricePerQty(productName, quantity):F2}");
        }
        static double PricePerQty(string productName, int quantity)
        {
            double coffeePrice = 1.50;
            double waterPrice = 1.00;
            double cokePrice = 1.40;
            double snacksPrice = 2.00;

            double price = 0.00;

            if (productName == "coffee")
            {
                price = quantity * coffeePrice;
            }
            else if (productName == "water")
            {
                price = quantity * waterPrice;
            }
            else if (productName == "coke")
            {
                price = quantity * cokePrice;
            }
            else
            {
                price = quantity * snacksPrice;
            }

            return price;
        }
    }
}
