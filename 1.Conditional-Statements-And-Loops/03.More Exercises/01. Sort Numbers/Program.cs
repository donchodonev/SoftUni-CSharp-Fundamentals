using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int maxNum = Math.Max((Math.Max(num1, num2)),Math.Max(num1,num3));
            int minNum = Math.Min((Math.Min(num1, num2)), Math.Min(num1, num3));

            //print max num

            Console.WriteLine(maxNum);

            //print num between max and min

            if (num1 == num2 || num1 == num3) 
            {
                Console.WriteLine(num1);
            }
            else if (num2 == num1 || num2 == num3)
            {
                Console.WriteLine(num2);
            }
            else if (num3 == num1 || num3 == num2)
            {
                Console.WriteLine(num3);
            }
            else
            {
                if (num1 < maxNum && num1 > minNum)
                {
                    Console.WriteLine(num1);
                }
                else if (num2 < maxNum && num2 > minNum)
                {
                    Console.WriteLine(num2);
                }
                else if (num3 < maxNum && num3 > minNum)
                {
                    Console.WriteLine(num3);
                }
            }
            //print minNum
            Console.WriteLine(minNum);
        }
    }
}
