using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string metal = Console.ReadLine();

            Dictionary<string, int> metalQuantity = new Dictionary<string, int>();

            while (metal != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (metalQuantity.ContainsKey(metal))
                {
                    metalQuantity[metal] += quantity;
                }
                else
                {
                    metalQuantity.Add(metal, quantity);
                }

                metal = Console.ReadLine();
            }

            foreach (var metalQuantityPair in metalQuantity)
            {
                Console.WriteLine($"{metalQuantityPair.Key} -> {metalQuantityPair.Value}");
            }
        }
    }
}
