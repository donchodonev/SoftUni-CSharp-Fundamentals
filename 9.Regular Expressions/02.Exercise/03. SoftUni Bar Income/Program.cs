using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)\%[^|%$.]*<(?<product>\w+)>[^|%$.]*\|(?<count>\d+)\|[^|%$.]*?(?<price>\d+\.?\d*)\$";
            double totalIncome = 0.0;

            string input = Console.ReadLine();

            char[] trimChars = { '%', '<', '>', '|', '$' };

            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string name = match.Groups["customer"].Value;

                    string product = match.Groups["product"].Value;

                    int count = int.Parse(match.Groups["count"].Value);

                    double price = double.Parse(match.Groups["price"].Value);

                    double currentTotal = count * price;

                    totalIncome += currentTotal;

                    Console.WriteLine($"{name}: {product} - {currentTotal:F2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
