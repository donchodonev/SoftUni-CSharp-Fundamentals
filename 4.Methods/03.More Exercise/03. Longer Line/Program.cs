using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                double x2 = double.Parse(Console.ReadLine());
                double y2 = double.Parse(Console.ReadLine());

                double x11 = double.Parse(Console.ReadLine());
                double y11 = double.Parse(Console.ReadLine());
                double x22 = double.Parse(Console.ReadLine());
                double y22 = double.Parse(Console.ReadLine());

                double lineA = LongerLine(x1, y1, x2, y2);
                double lineB = LongerLine(x11, y11, x22, y22);

                if (lineA >= lineB)
                {
                    PrintCloserPoint(x1, y1, x2, y2);
                }
                else
                {
                    PrintCloserPoint(x11, y11, x22, y22);
                }
        }

        static double LongerLine(double x1, double y1, double x2, double y2)
        {
            double line = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return line;
        }

        static void PrintCloserPoint(double x1, double y1, double x2, double y2)
        {
            if (Math.Abs(x1) + Math.Abs(y1) <= Math.Abs(x2) + Math.Abs(y2))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}
