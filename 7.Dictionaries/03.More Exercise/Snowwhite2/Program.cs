using System;
using System.Collections.Generic;
using System.Linq;

namespace Snowwhite2
{
    class Dwarf
    {
        public Dwarf(string name, string color, int physics)
        {
            Name = name;
            Color = color;
            Physics = physics;
        }

        public string Name { get; set; }
        public int Physics { get; set; }
        public string Color { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Dwarf> dwarfs = new List<Dwarf>();

            string input = Console.ReadLine();

            while (input != "Once upon a time")
            {
                string[] inputArgs = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);

                Dwarf dwarf = new Dwarf(inputArgs[0], inputArgs[1], int.Parse(inputArgs[2]));

                Dwarf tempDwarf = dwarfs.Find(x => x.Name == dwarf.Name && x.Color == dwarf.Color);

                if (tempDwarf == null)
                {
                    dwarfs.Add(dwarf);
                }
                else
                {
                    tempDwarf.Physics = Math.Max(tempDwarf.Physics, dwarf.Physics);
                }

                input = Console.ReadLine();
            }

            foreach (var item in dwarfs
                .OrderByDescending(x => x.Physics)
                .ThenByDescending(x => dwarfs.Where(y => y.Color == x.Color).Count()))
            {
                Console.WriteLine($"({item.Color}) {item.Name} <-> {item.Physics}");
            }
        }
    }
}
