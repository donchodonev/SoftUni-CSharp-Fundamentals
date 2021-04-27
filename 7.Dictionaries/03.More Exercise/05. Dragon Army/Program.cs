using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> dragons = new Dictionary<string, Dictionary<string, string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);


                string type = input[0];
                string name = input[1];
                int damage = 0;
                int health = 0;
                int armor = 0;

                if (input[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = int.Parse(input[2]);
                }
                //
                if (input[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(input[3]);
                }
                //
                if (input[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(input[4]);
                }
                ////adding dragon
                ///

                if (dragons.ContainsKey(type))
                {
                    if (dragons[type].ContainsKey(name))
                    {
                        dragons[type][name] = $"{damage}:{health}:{armor}";
                    }
                    else
                    {
                        dragons[type].Add(name, $"{damage}:{health}:{armor}");
                    }
                }
                else
                {
                    dragons.Add(type, new Dictionary<string, string> { { name, $"{damage}:{health}:{armor}" } });
                }
            }

            foreach (var dragonType in dragons)
            {

                double totalDamage = 0;
                double totalHealth = 0;
                double totalArmor = 0;

                foreach (var dragon in dragonType.Value)
                {
                    string[] dragonStats = dragon.Value.Split(':');

                    totalArmor += int.Parse(dragonStats[2]);
                    totalDamage += int.Parse(dragonStats[0]);
                    totalHealth += int.Parse(dragonStats[1]);
                }

                totalArmor /= dragonType.Value.Count();
                totalHealth /= dragonType.Value.Count();
                totalDamage /= dragonType.Value.Count();

                Console.WriteLine($"{dragonType.Key}::({totalDamage:F2}/{totalHealth:F2}/{totalArmor:F2})");

                foreach (var dragon in dragonType.Value.OrderBy(x => x.Key))
                {
                    string[] dragonStats = dragon.Value.Split(':');

                    int dragonDamage = int.Parse(dragonStats[0]);
                    int dragonHealth = int.Parse(dragonStats[1]);
                    int dragonArmor = int.Parse(dragonStats[2]);


                    Console.WriteLine($"-{dragon.Key} -> damage: {dragonDamage}" +
                        $", health: {dragonHealth}" +
                        $", armor: {dragonArmor}");
                }
            }
        }
    }
}
