using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int cmdCount = int.Parse(Console.ReadLine());

            Dictionary<string, string> userAndLP = new Dictionary<string, string>();

            for (int i = 0; i < cmdCount; i++)
            {
                string[] command = Console.ReadLine().Split();



                if (command[0].Equals("register"))
                {
                    string userName = command[1];
                    string licensePlate = command[2];

                    if (userAndLP.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {userAndLP[userName]}");
                    }
                    else
                    {
                        userAndLP.Add(userName, licensePlate);
                        Console.WriteLine($"{userName} registered {licensePlate} successfully");
                    }
                }
                else
                {
                    string userName = command[1];

                    if (userAndLP.ContainsKey(userName))
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                        userAndLP.Remove(userName);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                }
            }


            foreach (var item in userAndLP)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
