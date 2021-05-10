using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _05._Nether_Realms
{
    class Demon
    {
        public Demon(string name, double health, double damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public string Name { get; set; }
        public double Health { get; set; }
        public double Damage { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //initialise demons list

            List<Demon> demons = new List<Demon>();

            //read names from console

            string[] names = Console.ReadLine().Split(new[] {',',' '}, StringSplitOptions.RemoveEmptyEntries);

            //patterns

            string allNumsPattern = @"([-+]?\d+\.?\d+)|([+-]?\d+)";

            string allSymbolsPattern = @"\/|\*";

            string allLettersPattern = @"[^0-9+\-*\/\.]";

            foreach (var demonName in names)
            {
                //get demon damage

                MatchCollection numMatches = Regex.Matches(demonName, allNumsPattern);
                MatchCollection divisionAndMultiplicationMatches = Regex.Matches(demonName, allSymbolsPattern);

                double demonDamage = 0.0;

                foreach (Match num in numMatches)
                {
                    demonDamage += double.Parse(num.Value);
                }

                foreach (Match symbol in divisionAndMultiplicationMatches)
                {
                    foreach (var character in symbol.ToString())
                    {
                        if (character.ToString() == "*")
                        {
                            demonDamage *= 2.0;
                        }
                        else if (character.ToString() == "/")
                        {
                            demonDamage /= 2.0;
                        }
                    }
                }

                //get demon health

                MatchCollection letters = Regex.Matches(demonName, allLettersPattern);

                double demonHealth = 0;

                foreach (Match charArray in letters)
                {
                    foreach (var character in charArray.ToString())
                    {
                        demonHealth += character;
                    }
                }

                //add demon to list

                demons.Add(new Demon(demonName,demonHealth,demonDamage));
            }

            //print demons

            foreach (Demon demon in demons.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
            }
        }
    }
}