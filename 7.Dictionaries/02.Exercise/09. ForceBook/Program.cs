using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceMemberKVP = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (!input.Contains("Lumpawaroo"))
            {
                if (input.Contains("|"))
                {
                    string[] inputArgs = input
                        .Split(" | ", StringSplitOptions.RemoveEmptyEntries);


                    string forceSide = inputArgs[0];
                    string user = inputArgs[1];

                    bool userDoesNotExist = true;

                    foreach (var force in forceMemberKVP)
                    {
                        if (!force.Value.Contains(user))
                        {
                            userDoesNotExist = true;
                        }
                        else
                        {
                            userDoesNotExist = false;
                            break;
                        }
                    }

                    if (userDoesNotExist)
                    {
                        forceMemberKVP.Add(forceSide, new List<string> { user });
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] inputArgs = input
                         .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    string user = inputArgs[0];
                    string forceSide = inputArgs[1];

                    bool userExists = false;

                    foreach (var force in forceMemberKVP)
                    {
                        if (force.Value.Contains(user))
                        {
                            userExists = true;
                            force.Value.Remove(user);
                            forceMemberKVP[forceSide].Add(user);
                            Console.WriteLine($"{user} joins the {forceSide} side!");
                        }
                    }
                    //check if user does NOT exist
                    if (!userExists)
                    {
                        forceMemberKVP[forceSide].Add(user);
                        Console.WriteLine($"{user} joins the {forceSide} side!");
                    }
                }

                input = Console.ReadLine();
            }

            Dictionary<string, List<string>> filteredDictionary = forceMemberKVP
                 .OrderByDescending(x => x.Value.Count)
                 .ThenBy(x => x.Key)
                 .ToDictionary(x => x.Key, x => x.Value);

            foreach (var side in filteredDictionary)
            {
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                    foreach (var member in side.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"! {member}");
                    }
                }
            }
        }
    }
}
