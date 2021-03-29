using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            string message = "";
            int letterIndex = 0;


            for (int i = 0; i < inputCount; i++)
            {
                int letterNum = int.Parse(Console.ReadLine());
                string numString = letterNum.ToString();
                int numberOffset = 0;

                if (letterNum == 0) // 0 = interval
                {
                    message += " ";
                }
                else
                {
                    if (int.Parse(numString[0].ToString()) > 7)
                    {
                        numberOffset = ((int.Parse(numString[0].ToString()) - 2) * 3) + 1;
                    }
                    else
                    {
                        numberOffset = (int.Parse(numString[0].ToString()) - 2) * 3;
                    }
                    letterIndex = numberOffset + (numString.Length) - 1;
                    message += (char)(letterIndex + 97);
                }
            }
            Console.WriteLine(message);
        }
    }
}
