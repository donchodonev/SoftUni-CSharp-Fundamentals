using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._ForceBook
{

    class Program
    {
        public static void AddUser(Dictionary<string, List<string>> dictionary, string side, string user)
        {
            if (dictionary.ContainsKey(side))
            {
                if (!dictionary[side].Contains(user))
                {
                    dictionary[side].Add(user);
                }
            }
            else
            {
                dictionary.Add(side, new List<string> { user });
            }
        }

        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceSideAndUsers = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {

                if (input.Contains("|")) // means we're adding a user
                {
                    string[] inputArgs = input.Split(" | ");

                    string side = inputArgs[0];
                    string user = inputArgs[1];

                    bool userExists = false;

                    foreach (var force in forceSideAndUsers)
                    {
                        if (force.Value.Contains(user))
                        {
                            userExists = true;
                        }
                    }

                    if (!userExists)
                    {
                        AddUser(forceSideAndUsers, side, user);
                    }
                }

                else if (input.Contains("->")) // means we're switching user sides
                {
                    string[] inputArgs = input.Split(" -> ");

                    string user = inputArgs[0];
                    string side = inputArgs[1];

                    string sideThatHasTheUser = string.Empty;

                    //find which side the user is on
                    foreach (var kvp in forceSideAndUsers)
                    {
                        if (kvp.Value.Contains(user))
                        {
                            sideThatHasTheUser = kvp.Key;

                            //remove him from that side

                            forceSideAndUsers[sideThatHasTheUser].Remove(user);

                            //add user according to input

                            AddUser(forceSideAndUsers, side, user);

                            break;
                        }
                    }

                    AddUser(forceSideAndUsers, side, user);
                    Console.WriteLine($"{user} joins the {side} side!");
                }

                input = Console.ReadLine();
                //end of while loop
            }

            //print

            foreach 
                (var item in forceSideAndUsers
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                )
            {
                if (item.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                }

                foreach (var member in item.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {member}");
                }
            }
        }
    }
}
