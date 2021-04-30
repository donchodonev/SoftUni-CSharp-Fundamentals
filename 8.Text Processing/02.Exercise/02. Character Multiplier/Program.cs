using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static int Multiplier(string firstString, string secondString)
        {
            var sum = 0;

            var longestWord = firstString;
            var shortestWord = secondString;

            if (firstString.Length < secondString.Length)
            {
                shortestWord = firstString;
                longestWord = secondString;
            }
            else if (firstString.Length > secondString.Length)
            {
                longestWord = firstString;
                shortestWord = secondString;
            }

            for (var i = 0; i < shortestWord.Length; i++)
            {
                var multiply = shortestWord[i] * longestWord[i];
                sum += multiply;
            }

            for (var v = shortestWord.Length; v < longestWord.Length; v++)
            {
                var additon = longestWord[v];
                sum += additon; ;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var firstString = input[0];

            var secondString = input[1];

            var sum = Multiplier(firstString, secondString);

            Console.WriteLine(sum);
        }
    }
}
