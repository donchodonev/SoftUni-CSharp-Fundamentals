using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            bool isFound = false;

            //get the right password which is equal to the username but reversed

            for (int i = username.Length - 1; i >= 0 ; i--)
            {
                password += username[i];
            }

            //check if password is true

            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();
                if (input == password)
                {
                    isFound = true;
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                if (i < 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }

            //if password is still not true after 4 login attemps
            if (!isFound)
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}
