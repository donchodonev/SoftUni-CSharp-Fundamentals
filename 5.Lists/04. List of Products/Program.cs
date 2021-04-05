using System;
using System.Collections.Generic;


namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> items = new List<string>(4);

            for (int i = 0; i < n; i++)
            {
                items.Add(Console.ReadLine());
            }

            items.Sort();

            for (int v = 0; v < items.Count; v++)
            {
                Console.WriteLine($"{v + 1}.{items[v]}");
            }
        }
    }
}
