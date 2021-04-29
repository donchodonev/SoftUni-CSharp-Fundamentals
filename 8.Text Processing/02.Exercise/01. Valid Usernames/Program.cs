using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            for (int i = 0; i < usernames.Count; i++)
            {
                string username = usernames[i];

                for (int v = 0; v < username.Length; v++)
                {
                    if (username.Length < 3 
                        || 
                        username.Length >= 16)
                    {
                        usernames.RemoveAt(i);
                        i--;
                        break;
                    }
                    else if (!char.IsLetterOrDigit(username[v]) 
                        && username[v] != '_' 
                        && username[v] != '-')
                    {
                        usernames.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }

            foreach (var username in usernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
