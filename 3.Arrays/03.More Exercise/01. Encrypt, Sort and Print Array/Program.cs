using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] output = new int[n];
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < n; i++) //word
            {
                string input = Console.ReadLine();
                int currValue = 0;

                for (int v = 0; v < input.Length; v++) //letter
                {
                    bool isVowel = false;

                    for (int c = 0; c < vowels.Length; c++) //check if is vowel 
                    {

                        if (input[v].ToString().ToLower().Contains(vowels[c]))
                        {
                            isVowel = true;
                        }
                    }
                    if (isVowel)
                    {
                        currValue += (int)input[v] * input.Length;
                    }
                    else
                    {
                        currValue += (int)input[v] / input.Length;
                    }
                }

                output[i] = currValue;
            }

            Array.Sort(output);//sort array in ascending order

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
