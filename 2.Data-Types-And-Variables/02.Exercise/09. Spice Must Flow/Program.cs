using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            long yield = long.Parse(Console.ReadLine());
            long daysPassed = 0;
            long yieldExtractedAndKept = 0;
            long workersCut = 26;

            while (yield >= 100)
            {
                yieldExtractedAndKept += (yield - workersCut);
                yield -= 10;
                daysPassed++;
            }

            yieldExtractedAndKept -= workersCut;

            if (yieldExtractedAndKept < 0)
            {
                yieldExtractedAndKept = 0;
            }

            Console.WriteLine(daysPassed);
            Console.WriteLine(yieldExtractedAndKept);
        }
    }
}
