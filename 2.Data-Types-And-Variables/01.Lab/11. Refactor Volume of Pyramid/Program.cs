using System;

namespace _11._Refactor_heightolume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double Length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double Width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double Height = double.Parse(Console.ReadLine());
            double Volume = (Length * Width * Height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", Volume);
        }
    }
}
