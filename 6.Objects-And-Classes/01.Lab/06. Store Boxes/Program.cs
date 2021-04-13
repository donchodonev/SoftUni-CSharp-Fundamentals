using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }


    class Box
    {
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal BoxPrice { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            List<Item> items = new List<Item>(10);

            List<Box> boxes = new List<Box>(10);


            while (input.Count > 1)
            {
                Item item = new Item();
                Box box = new Box();

                item.Name = input[1];
                item.Price = decimal.Parse(input[3]);

                box.ItemQuantity = int.Parse(input[2]);
                box.SerialNumber = int.Parse(input[0]);
                box.Item = item;
                box.BoxPrice = item.Price * box.ItemQuantity;

                items.Add(item);
                boxes.Add(box);

                input = Console.ReadLine()
                    .Split()
                    .ToList();
            }

            List<Box> boxesSorted = boxes.OrderByDescending(x => x.BoxPrice).ToList();

            foreach (Box box in boxesSorted)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:F2}");
            }
        }
    }
}
