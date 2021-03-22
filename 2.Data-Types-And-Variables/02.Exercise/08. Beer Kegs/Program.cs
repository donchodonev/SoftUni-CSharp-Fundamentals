using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfKegs = int.Parse(Console.ReadLine());
            double biggestKegSize = 0.0;
            string biggestKegName = "";

            for (int i = 0; i < numOfKegs; i++)
            {
                string kegName = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());
                double kegVolume = Math.PI * (kegRadius * kegRadius) * kegHeight;

                if (biggestKegSize < kegVolume)
                {
                    biggestKegSize = kegVolume;
                    biggestKegName = kegName;
                }
            }
            Console.WriteLine(biggestKegName);
        }
    }
}
