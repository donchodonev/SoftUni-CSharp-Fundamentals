﻿using System;
using System.Globalization;

namespace _13._Holidays_Between_Two_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(),
           "d.M.yyyy", CultureInfo.InvariantCulture);

            DateTime endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);

            var holidaysCount = 0;

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1.0))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) 
                {
                    holidaysCount++; 
                }
            }
            Console.WriteLine(holidaysCount);
        }
    }
}
