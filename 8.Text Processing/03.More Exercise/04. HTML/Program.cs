using System;
using System.Text;

namespace _04._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string articleContent = Console.ReadLine();

            string comment = Console.ReadLine();

            Console.WriteLine("<h1>");
            Console.WriteLine($"{title}");
            Console.WriteLine("</h1>");

            Console.WriteLine("<article>");
            Console.WriteLine($"{articleContent}");
            Console.WriteLine("</article>");

            while (comment != "end of comments")
            {
                Console.WriteLine($"<div>");
                Console.WriteLine(comment);
                Console.WriteLine($"</div>");

                comment = Console.ReadLine();
            }
        }
    }
}
