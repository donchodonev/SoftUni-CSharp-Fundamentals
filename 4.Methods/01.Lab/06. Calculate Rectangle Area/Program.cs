using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double rectangleArea = GetRectangleArea(width, height);

            Console.WriteLine(rectangleArea);
        }

        static double GetRectangleArea(double width, double height)
        {
            double rectangleArea = width * height;

            return rectangleArea;
        }
    }

}
