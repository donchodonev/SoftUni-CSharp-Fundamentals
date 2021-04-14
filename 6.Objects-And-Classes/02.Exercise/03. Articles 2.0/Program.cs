using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List <Article> articles = new List<Article>(5);

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine()
                        .Split(", ")
                        .ToList();

                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article article = new Article(title, content, author);

                articles.Add(article);
            }

            string sortType = Console.ReadLine();

            if (sortType == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }
            else if (sortType == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }
            else
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }

            foreach (var item in articles)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}