using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger numOfBalls = BigInteger.Parse(Console.ReadLine());

            BigInteger bestSnowballValue = 0;
            BigInteger bestSnowballSnow = 0;
            BigInteger bestSnowballTime = 0;
            BigInteger bestSnowballQuality = 0;

            for (BigInteger i = 1; i <= numOfBalls; i++)
            {
                BigInteger snowballSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballTime = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballQuality = BigInteger.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, (int)snowballQuality);

                if (snowballValue > bestSnowballValue)
                {
                    bestSnowballValue = snowballValue;
                    bestSnowballQuality = snowballQuality;
                    bestSnowballTime = snowballTime;
                    bestSnowballSnow = snowballSnow;
                }

                if (i == numOfBalls)
                {
                    Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");
                }
            }
        }
    }
}
