using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> participants = new Dictionary<string, int>();

            List<string> validParticipant = new List<string>(Console.ReadLine().Split(", "));

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = string.Empty;

                int distance = 0;

                foreach (var item in input)
                {
                    if (char.IsLetter(item))
                    {
                        name += item.ToString();
                    }
                    else if (char.IsDigit(item))
                    {
                        distance += int.Parse(item.ToString());
                    }
                }

                if (validParticipant.Contains(name))
                {
                    if (participants.ContainsKey(name))
                    {
                        participants[name] += distance;
                    }
                    else
                    {
                        participants.Add(name, distance);
                    }
                }

                input = Console.ReadLine();
            }

            participants = participants.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);

            int printIndex = 1;

            foreach (var item in participants)
            {
                if (printIndex == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                    printIndex++;
                }
                else if (printIndex == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                    printIndex++;
                }
                else if (printIndex == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                    printIndex++;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
