using System;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder output = new StringBuilder();

            int skip = 0;

            for (int i = 0 + skip; i < text.Length; i++)
            {
                if (text[i].ToString() == ">")
                {
                    skip += int.Parse(text[i+1].ToString());

                    output.Append(text[i].ToString());

                    continue;
                }
                else if (skip > 0)
                {
                    skip--;

                    continue;
                }
                else
                {
                    output.Append(text[i].ToString());
                }
            }

            Console.WriteLine(output);
        }
    }
}
