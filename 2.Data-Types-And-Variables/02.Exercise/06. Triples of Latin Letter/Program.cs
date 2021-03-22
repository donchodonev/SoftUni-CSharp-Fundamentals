using System;

namespace _06._Triples_of_Latin_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //97 = ascii 'a'
            for (int firstLetter = (int)'a'; firstLetter < (int)'a' + n; firstLetter++)
            {
                for (int secondLetter = (int)'a'; secondLetter < (int)'a' + n; secondLetter++)
                {
                    for (int thirdLetter = (int)'a'; thirdLetter < (int)'a' + n; thirdLetter++)
                    {
                        Console.WriteLine();
                        Console.Write((char)firstLetter);
                        Console.Write((char)secondLetter);
                        Console.Write((char)thirdLetter);
                    }
                }
            }
        }
    }
}
