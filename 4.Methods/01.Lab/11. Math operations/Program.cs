using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string calcAction = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            if (calcAction == "+")
            {
                Add(firstNum, secondNum);
            }
            else if (calcAction == "-")
            {
                Subtract(firstNum, secondNum);
            }
            else if (calcAction == "*")
            {
                Multiply(firstNum, secondNum);
            }
            else if (calcAction == "/")
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
