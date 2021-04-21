using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> keyItems = new Dictionary<string, int>();
            Dictionary<string, int> junkItems = new Dictionary<string, int>();

            keyItems["shards"] = 0;
            keyItems["fragments"] = 0;
            keyItems["motes"] = 0;

            bool noItem = true;

            while (noItem)
            {

                string itemName = string.Empty;
                int itemQuantity = 0;
                string firstItem = string.Empty;

                for (int i = 0; i < input.Length && noItem; i++)
                {
                    if (i % 2 == 0)
                    {
                        itemQuantity = int.Parse(input[i]);
                        continue;
                    }
                    else
                    {
                        itemName = input[i].ToLower();
                    }


                    if (keyItems.ContainsKey(itemName))
                    {
                        keyItems[itemName] += itemQuantity;
                    }
                    else
                    {
                        if (junkItems.ContainsKey(itemName))
                        {
                            junkItems[itemName] += itemQuantity;
                        }
                        else
                        {
                            junkItems.Add(itemName, itemQuantity);
                        }
                    }


                    foreach (var item in keyItems)
                    {
                        if (item.Key == "shards" && item.Value >= 250)
                        {
                            Console.WriteLine($"Shadowmourne obtained!");
                            noItem = false;
                            firstItem = item.Key;
                            break;
                        }
                        else if (item.Key == "fragments" && item.Value >= 250)
                        {
                            Console.WriteLine($"Valanyr obtained!");
                            firstItem = item.Key;
                            noItem = false;
                            break;
                        }
                        else if (item.Key == "motes" && item.Value >= 250)
                        {
                            Console.WriteLine($"Dragonwrath obtained!");
                            firstItem = item.Key;
                            noItem = false;
                            break;
                        }
                    }
                }

                if (noItem == false)
                {
                    keyItems[firstItem] -= 250;
                    break;
                }
                else
                {
                    input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                }
            }

            keyItems = keyItems.OrderByDescending(item => item.Value)
                .ThenBy(item => item.Key)
                .ToDictionary(item => item.Key,item => item.Value);

            junkItems = junkItems.OrderBy(item => item.Key)
                .ToDictionary(item => item.Key,item => item.Value);

            foreach (var item in keyItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
