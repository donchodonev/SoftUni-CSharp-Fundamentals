using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numInput = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 0;
            bool isSpecial = false;
            for (int num = 1; num <= numInput; num++)
            {
                number = num;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", number, isSpecial);
                sum = 0;
                num = number;
            }
        }
    }
}
