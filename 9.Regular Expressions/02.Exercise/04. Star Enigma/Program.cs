using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            //get the ASCI reduce Count int value

            string starCharCountPattern = @"[starSTAR]";

            int n = int.Parse(Console.ReadLine());

            List<string> attackedPlantesNames = new List<string>();
            List<string> destroyedPlantesNames = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();

                MatchCollection reduceCountMatches = Regex.Matches(encryptedMessage, starCharCountPattern);

                int reduceCount = reduceCountMatches.Count;

                //decrypt message

                StringBuilder decryptedMessage = new StringBuilder();

                foreach (var character in encryptedMessage)
                {
                    decryptedMessage.Append((char)(character - reduceCount));
                }

                //extract info

                string infoPattern = @"@(?<planet>[A-Za-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<attackType>[AD]*)![^@\-!:>]*(->)(?<soldiers>\d+)";

                //if there's no match just re-run the for loop

                if (!Regex.IsMatch(decryptedMessage.ToString(), infoPattern))
                {
                    continue;
                }

                Match extractedInfo = Regex.Match(decryptedMessage.ToString(), infoPattern);

                string planetName = extractedInfo.Groups["planet"].Value;
                string attackType = extractedInfo.Groups["attackType"].Value;

                if (attackType == "A")
                {
                    attackedPlantesNames.Add(planetName);
                }
                else
                {
                    destroyedPlantesNames.Add(planetName);
                }
            }

            //print attacked planets count and names

            Console.WriteLine($"Attacked planets: {attackedPlantesNames.Count}");

            foreach (string planet in attackedPlantesNames.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            //print destroyed planets count and names

            Console.WriteLine($"Destroyed planets: {destroyedPlantesNames.Count}");

            foreach (string planet in destroyedPlantesNames.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
