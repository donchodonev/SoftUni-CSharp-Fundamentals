using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string calcAction = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (calcAction == "add")
            {
                Add(firstNum, secondNum);
            }
            else if (calcAction == "subtract")
            {
                Subtract(firstNum, secondNum);
            }
            else if (calcAction == "multiply")
            {
                Multiply(firstNum, secondNum);
            }
            else if (calcAction == "divide")
            {
                Divide(firstNum, secondNum);
            }
        }

        static void Add(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
        }
        static void Subtract(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum - secondNum);
        }
        static void Multiply(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum * secondNum);
        }
        static void Divide(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum / secondNum);
        }
    }
}
