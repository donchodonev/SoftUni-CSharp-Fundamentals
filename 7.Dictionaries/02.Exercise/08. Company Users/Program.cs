using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyAndEmpID = new Dictionary<string, List<string>>();

            string[] inputArgs = Console.ReadLine().Split(" -> ");

            while (inputArgs.Length > 1)
            {
                string companyName = inputArgs[0];
                string employeeID = inputArgs[1];

                if (companyAndEmpID.ContainsKey(companyName))
                {
                    if (!companyAndEmpID[companyName].Contains(employeeID))
                    {
                        companyAndEmpID[companyName].Add(employeeID);
                    }
                }
                else
                {
                    companyAndEmpID.Add(companyName, new List<string> { employeeID });
                }

                inputArgs = Console.ReadLine().Split(" -> ");
            }

            companyAndEmpID = companyAndEmpID.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in companyAndEmpID)
            {
                Console.WriteLine($"{item.Key}");

                foreach (var empID in item.Value)
                {
                    Console.WriteLine($"-- {empID}");
                }
            }
        }
    }
}
