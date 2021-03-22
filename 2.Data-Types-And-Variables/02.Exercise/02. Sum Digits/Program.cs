using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int numSum = 0;

            string numString = number.ToString();

            for (int i = 0; i < numString.Length; i++)
            {
                numSum += int.Parse(numString[i].ToString());
            }

            Console.WriteLine(numSum);
        }
    }
}
