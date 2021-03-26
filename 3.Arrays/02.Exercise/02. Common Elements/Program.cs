using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] firstString = Console.ReadLine().Split();
            string[] secondString = Console.ReadLine().Split();

            foreach (var item in firstString)
            {
                foreach (var item2 in secondString)
                {
                    if (item2 == item)
                    {
                        Console.Write($"{item2} ");
                    }
                }
            }
        }
    }
}
