using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> emails = new List<string>();

            string input = Console.ReadLine();

            string emailsPattern = @"\b[A-Za-z0-9]+([\.\-_]?[A-Za-z0-9])*\@[A-Za-z0-9-]{2,}(\.[A-Za-z0-9-]{2,})+\b";

            MatchCollection validEmails = Regex.Matches(input, emailsPattern);

            foreach (Match email in validEmails)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
