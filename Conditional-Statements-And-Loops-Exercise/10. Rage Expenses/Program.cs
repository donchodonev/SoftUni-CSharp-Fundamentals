using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {

            //input

            int gamesLost = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            //trash count calculation

            int headsetTrashCount = gamesLost / 2;
            int mouseTrashCount = gamesLost / 3;
            int keyboardTrashCount = gamesLost / 6;
            int displayTrashCount = keyboardTrashCount / 2;

            //trashing expenses calculation

            double rageExpenses = (headsetTrashCount * headsetPrice) + (mousePrice * mouseTrashCount) + (keyboardTrashCount * keyboardPrice) + (displayPrice * displayTrashCount);

            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");

        }
    }
}
