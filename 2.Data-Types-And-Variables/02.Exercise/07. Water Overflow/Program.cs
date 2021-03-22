using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int waterTankCurrentCapacity = 0;
            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                int waterToBePouredIntoTheTank = int.Parse(Console.ReadLine());
                if (waterToBePouredIntoTheTank + waterTankCurrentCapacity <= 255)
                {
                    waterTankCurrentCapacity += waterToBePouredIntoTheTank;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(waterTankCurrentCapacity);
        }
    }
}
