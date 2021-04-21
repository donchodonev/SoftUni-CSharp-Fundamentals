using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Orders
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            while (input.Length > 1)
            {
                string productName = input[0];
                double productPrice = double.Parse(input[1]);
                int productQty = int.Parse(input[2]);

                if (products.ContainsKey(productName))
                {
                    products[productName][1] += productQty;

                    if (products[productName][0] != productPrice)
                    {
                        products[productName][0] = productPrice;
                    }
                }
                else
                {
                    products.Add(productName, new List<double>{productPrice,productQty});
                }

                input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value[0]*product.Value[1]:F2}");
            }
        }
    }
}
