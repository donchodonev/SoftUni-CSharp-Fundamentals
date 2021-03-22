using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {

            int initialPower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            int targetsPoked = 0;
            int power = initialPower;

            while (true)
            {

                if (initialPower / 2 == power && exhaustion != 0)
                {
                    power /= exhaustion;
                }

                if (power >= distance)
                {
                    power -= distance;
                    targetsPoked++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(targetsPoked);
        }
    }
}
