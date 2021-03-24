using System;
using System.Linq;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine((char)63); // get char of num

            int key = int.Parse(Console.ReadLine());
            int numOfInputs = int.Parse(Console.ReadLine());
            char[] message = new char[numOfInputs];

            for (int i = 0; i < numOfInputs; i++)
            {
                message[i] = (char)(char.Parse(Console.ReadLine()));
            }

            for (int k = 0; k < message.Length; k++)
            {
                Console.Write(message[k] + (char)key);
            }

            for (int k = 0; k < message.Length; k++)
            {
                Console.Write((char)(message[k] + key));
            }
        }
    }
}
