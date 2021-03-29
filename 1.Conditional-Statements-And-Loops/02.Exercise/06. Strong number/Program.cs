using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int inputInInt = int.Parse(input);

            var inputToChar = input.ToCharArray();

            int totalOfEachNumFactorial = 0;

            int iterator = 0;

            int counter = 1;

            int factorial = 1;

            //spin the cycle for as many digits as the input num has
            while (counter <= inputToChar.Length)
            {

                //get a digit from the num starting from the left-most position
                int digit = int.Parse(inputToChar[iterator].ToString());
                //calculate factorial
                for (int i = 1 ; i <= digit; i++)
                {
                    factorial *= i;
                }
                //add sum of factorial of this digit to the total sum
                totalOfEachNumFactorial += factorial;
                //reset counters
                iterator++;
                counter++;
                //set factorial start position to 1
                factorial = 1;
            }
            //output
            if (inputInInt == totalOfEachNumFactorial)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
