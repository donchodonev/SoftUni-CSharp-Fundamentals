using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<string> phrases = new List<string> { "Excellent product."
                , "Such a great product."
                , "I always use that product."
                , "Best product of its category."
                , "Exceptional product."
                , "I can’t live without this product." };

            List<string> events = new List<string> { "Now I feel good."
                , "I have succeeded with this product."
                , "Makes miracles. I am happy of the results!"
                , "I cannot believe but now I feel awesome."
                , "Try it yourself, I am very satisfied."
                , "I feel great!" };

            List<string> authors = new List<string> { "Diana"
                , "Petya"
                , "Stella"
                , "Elena"
                , "Katya"
                , "Iva"
                , "Annie"
                , "Eva" };

            List<string> cities = new List<string> { "Burgas"
                , "Sofia"
                , "Plovdiv"
                , "Varna"
                , "Ruse" };

            for (int i = 0; i < n; i++)
            {
                Random random = new Random();

                int randomNum = random.Next(0, n);

                Console.WriteLine($"{phrases[randomNum]} {events[randomNum]} {authors[randomNum]} - {cities[randomNum]}");
            }
        }
    }
}
