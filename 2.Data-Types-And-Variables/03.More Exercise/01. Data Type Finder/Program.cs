using System;

namespace _01._Data_Type_Finder
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int intNum;
            float floatNum;
            char charChar;
            bool boolBool;

            while (input != "END")
            {
                if (int.TryParse(input, out intNum))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out floatNum))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out charChar))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out boolBool))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();
            }
        }
    }
}
