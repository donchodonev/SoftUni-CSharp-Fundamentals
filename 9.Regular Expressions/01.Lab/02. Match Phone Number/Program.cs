using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359(\s|-)2(\1)\d{3}(\1)\d{4}\b";

            string numbers = Console.ReadLine();

            MatchCollection matches = Regex.Matches(numbers, pattern);

            Console.WriteLine(String.Join(", ",matches.Select(x => x.Value)));
        }
    }
}
