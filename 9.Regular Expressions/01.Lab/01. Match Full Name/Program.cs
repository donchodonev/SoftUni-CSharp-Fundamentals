using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+\b \b[A-Z][a-z]+\b";

            string names = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(names, pattern);

            foreach (Match match in matchedNames)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
