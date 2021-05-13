using System;
using System.Text.RegularExpressions;

namespace _4._Santa_s_Secret_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Regex nameAndBehaviour = new Regex(@"@(?<name>[A-Za-z][A-Za-z]+)[^\@\-!:>]*!(?<behaviour>[GN])!");

            while (input != "end")
            {
                string decryptedMessage = string.Empty;

                foreach (var character in input)
                {
                    decryptedMessage += (char)(character - key);
                }

                if (nameAndBehaviour.Match(decryptedMessage).Success)
                {
                    if (nameAndBehaviour.Match(decryptedMessage).Groups["behaviour"].Value == "G")
                    {
                        Console.WriteLine($"{nameAndBehaviour.Match(decryptedMessage).Groups["name"].Value}");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
