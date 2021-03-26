using System;
using System.Linq;
namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers [i] = int.Parse(Console.ReadLine());
            }

            for (int k = numbers.Length - 1; k >= 0; k--)
            {
                Console.Write(numbers[k] + " ");
            }
        }
    }
}
