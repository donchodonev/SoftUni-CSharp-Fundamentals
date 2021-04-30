using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            int pathLength = path.Length;

            int indexOfLastSlash = path.LastIndexOf('\\');

            string fileNameAndExt = string.Empty;

            string[] splitNameAndExt = path.Substring(indexOfLastSlash + 1, path.Length - indexOfLastSlash - 1).Split('.');

            string fileName = splitNameAndExt[0];
            string extension = splitNameAndExt[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
