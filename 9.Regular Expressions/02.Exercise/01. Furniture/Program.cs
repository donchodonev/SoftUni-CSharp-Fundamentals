using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _01._Furniture
{
    class Order
    {
        public Order(string name, decimal cost, int quantity)
        {
            Name = name;
            Cost = cost;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
    }
    class Program
    {
        public static decimal Total(List<Order> listOfOrders)
        {
            decimal total = 0;

            foreach (Order item in listOfOrders)
            {
                total += (item.Cost * item.Quantity);
            }

            return total;
        }
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";

            string input = Console.ReadLine();

            List<Order> orders = new List<Order>();

            while (input != "Purchase")
            {
                Match validPurchase = Regex.Match(input, pattern);

                if (validPurchase.Success)
                {
                    string name = validPurchase.Groups["name"].Value;
                    decimal price = decimal.Parse(validPurchase.Groups["price"].Value);
                    int quantity = int.Parse(validPurchase.Groups["quantity"].Value);

                    if (quantity != 0)
                    {
                        orders.Add(new Order(name, price, quantity));
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");

            foreach (Order order in orders)
            {
                Console.WriteLine($"{order.Name}");
            }

            Console.WriteLine($"Total money spend: {Total(orders):F2}");
        }
    }
}

