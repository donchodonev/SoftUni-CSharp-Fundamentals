using System;
using System.Linq;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = Console.ReadLine();

            while (input != "find")
            {
                string decryptedMessage = string.Empty;

                int index = 0;

                for (int i = 0; i < input.Length; i++)
                {

                    if (index == keys.Length)
                    {
                        index = 0;
                    }

                    char addition = (char)(input[i] - keys[index]);

                    decryptedMessage += addition.ToString();

                    index++;
                }

                //get treasure name

                int treasureNameStartIndex = decryptedMessage.IndexOf('&') + 1;
                int treasureNameEndIndex = decryptedMessage.LastIndexOf('&');

                string treasure = decryptedMessage
                    .Substring(treasureNameStartIndex, treasureNameEndIndex - treasureNameStartIndex);

                //get treasure coordinates

                int coordinatesStartIndex = decryptedMessage.IndexOf('<') + 1;
                int coordinatesEndIndex = decryptedMessage.IndexOf('>');

                string coordinates = decryptedMessage
                    .Substring(coordinatesStartIndex, coordinatesEndIndex - coordinatesStartIndex);

                //print

                Console.WriteLine($"Found {treasure} at {coordinates}");

                input = Console.ReadLine();
            }
        }
    }
}
