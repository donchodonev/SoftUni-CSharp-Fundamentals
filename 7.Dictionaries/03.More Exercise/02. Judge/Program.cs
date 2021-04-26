using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> users = new Dictionary<string, int>();

            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "no more time")
            {
                string[] inputArgs = input.Split(" -> ");

                string userName = inputArgs[0];
                string contestName = inputArgs[1];
                int contestPoints = int.Parse(inputArgs[2]);

                bool pointsAdd = true;
                int difference = 0;

                if (contests.ContainsKey(contestName))
                {
                    if (contests[contestName].ContainsKey(userName))
                    {
                        if (contests[contestName][userName] < contestPoints)
                        {
                            difference = contestPoints - contests[contestName][userName];
                            contests[contestName][userName] = contestPoints;
                            pointsAdd = false;
                        }
                        else
                        {
                            pointsAdd = false;
                        }
                    }
                    else
                    {
                        contests[contestName].Add(userName, contestPoints);
                    }
                }
                else
                {
                    contests.Add(contestName, new Dictionary<string, int> ());
                    contests[contestName].Add(userName, contestPoints);
                }

                //update users

                if (users.ContainsKey(userName) && pointsAdd)
                {
                    users[userName] += contestPoints;
                }
                else if (users.ContainsKey(userName) && pointsAdd == false)
                {
                    users[userName] += difference;
                }
                else
                {
                    users.Add(userName, contestPoints);
                }

                input = Console.ReadLine();
            }

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count()} participants");

                int userPlace = 1;

                foreach (var contestUsers in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key)) // order by users' points, then by name
                {
                    Console.WriteLine($"{userPlace}. {contestUsers.Key} <::> {contestUsers.Value}");
                    userPlace++;
                }
            }

            int userPlace2 = 1;

            Console.WriteLine("Individual standings:");

            foreach (var user in users.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{userPlace2}. {user.Key} -> {user.Value}");
                userPlace2++;
            }
        }
    }
}
