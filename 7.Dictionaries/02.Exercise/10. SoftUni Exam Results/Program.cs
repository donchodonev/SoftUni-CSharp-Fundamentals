using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> userKVP = new Dictionary<string, int>();
            Dictionary<string, int> submissionKVP = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "exam finished")
            {
                string[] inputArgs = input.Split('-');

                if (inputArgs.Length == 3) //nobody being banned
                {
                    //get input data

                    string user = inputArgs[0];

                    string language = inputArgs[1];

                    int points = int.Parse(inputArgs[2]);

                    //add user data
                    if (userKVP.ContainsKey(user))
                    {
                        if (userKVP[user] < points)
                        {
                            userKVP[user] = points;
                        }
                    }
                    else
                    {
                        userKVP.Add(user, points);
                    }

                    //add language data
                    if (submissionKVP.ContainsKey(language))
                    {
                        submissionKVP[language]++;
                    }
                    else
                    {
                        submissionKVP.Add(language, 1);
                    }
                }
                else //someone is getting banned
                {
                    string[] banArgs = input.Split('-');

                    string banName = banArgs[0];

                    userKVP.Remove(banName);
                }

                input = Console.ReadLine();
            }

            //print

            Console.WriteLine("Results:");

            foreach (var item in userKVP.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var item in submissionKVP.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}

