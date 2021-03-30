using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            IsPassValid(password);
        }

        static bool IsInRange(string password)
        {
            bool isInRange;

            if (password.Length >= 6 && password.Length <= 10)
            {
                isInRange = true;
            }
            else
            {
                isInRange = false;
            }

            return isInRange;
        }

        static bool IsOfLettersAndDigits(string password)
        {

            bool isOfLettersAndDigits = false;

            foreach (var item in password)
            {
                if (
                    ((int)item >= (int)'a' && (int)item <= (int)'z') ||
                    ((int)item >= (int)'A' && (int)item <= (int)'Z') ||
                    ((int)item >= (int)'0' && (int)item <= (int)'9')
                   )
                {
                    isOfLettersAndDigits = true;
                }
                else
                {
                    isOfLettersAndDigits = false;
                    break;
                }
            }

            return isOfLettersAndDigits;
        }

        static bool HasAtLeastTwoDigits(string password)
        {

            int digitsCount = 0;

            bool hasAtLeastTwoDigits = false;

            foreach (var item in password)
            {
                if ((int)item >= (int)'0' && (int)item <= (int)'9')
                {
                    digitsCount++;
                }
            }

            if (digitsCount > 1)
            {
                hasAtLeastTwoDigits = true;
            }

            return hasAtLeastTwoDigits;
        }

        static void IsPassValid(string password)
        {
            bool isPasswordValid = true;

            while (isPasswordValid)
            {
                if (!IsInRange(password))
                {
                    isPasswordValid = false;
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }

                if (!IsOfLettersAndDigits(password))
                {
                    isPasswordValid = false;
                    Console.WriteLine("Password must consist only of letters and digits");
                }

                if (!HasAtLeastTwoDigits(password))
                {
                    isPasswordValid = false;
                    Console.WriteLine("Password must have at least 2 digits");
                }

                if (isPasswordValid)
                {
                    Console.WriteLine("Password is valid");
                    break;
                }
            }
        }
    }
}
