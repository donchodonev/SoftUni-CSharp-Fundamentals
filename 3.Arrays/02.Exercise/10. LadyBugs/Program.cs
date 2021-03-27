using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfTheField = int.Parse(Console.ReadLine());
            int[] initialIndexes = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] playground = new int[sizeOfTheField];
            foreach (var newIndex in initialIndexes)
            {
                if (newIndex >= 0 && newIndex < playground.Length)
                {
                    playground[newIndex] = 1;
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                int start = int.Parse(command.Split()[0]); 
                int end = int.Parse(command.Split()[2]); 
                string direction = command.Split()[1]; 

                if (ChekPosition(start, end, playground))
                {
                    if (playground[start] == 1)
                    {
                        if (direction == "left")
                        {
                            playground = LadybugFlightLeft(start, end, playground);
                        }
                        else if (direction == "right")
                        {
                            playground = LadybugFlightRight(start, end, playground);
                        }
                    }
                }

            }

            Console.WriteLine(string.Join(" ", playground));
        }

        static bool ChekPosition(int startPosition, int endPosition, int[] playground)
        {
            bool result = false;

            if ((startPosition <= playground.Length - 1 && startPosition >= 0))
                result = true;
            else
                result = false;

            return result;
        }

        static int[] LadybugFlightLeft(int startPosition, int endPosition, int[] playground)
        {
            int ladybugFlightLeft = startPosition - endPosition; 
            int flightToNewIndex = 0;


            if (endPosition == 0)
            {
                return playground;
            }

            if (endPosition < 0)
            {
                playground = LadybugFlightRight(startPosition, Math.Abs(endPosition), playground);
                return playground;
            }

            if (ladybugFlightLeft >= 0 && ladybugFlightLeft < playground.Length)
            {

                if (playground[ladybugFlightLeft] == 0)
                {
                    flightToNewIndex = ladybugFlightLeft; 
                    playground[startPosition] = 0; 
                    playground[flightToNewIndex] = 1; 
                }

                else
                {
                    flightToNewIndex = -1; 

               
                    for (int i = ladybugFlightLeft; i >= 0; i -= endPosition)
                    {

                        if (playground[i] != 1)
                        {
                            flightToNewIndex = i;
                            playground[startPosition] = 0;
                            playground[flightToNewIndex] = 1;
                            break; 
                        }
                    }

                    if (flightToNewIndex < 0)
                    {
                        playground[startPosition] = 0; 
                    }
                }
            }

            else
                playground[startPosition] = 0; 

            return playground;
        }

        static int[] LadybugFlightRight(int startPosition, int endPosition, int[] playground)
        {
            int ladybugFlightLeft = startPosition + endPosition; // стъпка надясно
            int flightToNewIndex = 0;


            if (endPosition == 0)
            {
                return playground;
            }

            if (endPosition < 0)
            {
                playground = LadybugFlightLeft(startPosition, Math.Abs(endPosition), playground);
                return playground;
            }

            if (ladybugFlightLeft >= 0 && ladybugFlightLeft < playground.Length)
            {

                if (playground[ladybugFlightLeft] == 0)
                {
                    flightToNewIndex = ladybugFlightLeft; 
                    playground[startPosition] = 0; 
                    playground[flightToNewIndex] = 1; 
                }
                
                else
                {
                    flightToNewIndex = -1; 


                    for (int i = ladybugFlightLeft; i < playground.Length; i += endPosition)
                    {

                        if (playground[i] != 1)
                        {
                            flightToNewIndex = i; 
                            playground[startPosition] = 0; 
                            playground[flightToNewIndex] = 1; 
                            break; 
                        }
                    }
                

                    if (flightToNewIndex < 0)
                    {
                        playground[startPosition] = 0; 
                    }
                }
            }

            else
                playground[startPosition] = 0; 

            return playground;
        }
    }
}
