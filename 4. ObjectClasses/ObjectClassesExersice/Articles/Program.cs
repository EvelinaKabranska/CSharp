using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Linq;
namespace Articles
{

    
    class Program
    {
        class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(",").Select(x => x.Trim()).ToArray();

            int num = int.Parse(Console.ReadLine());

            var article = new Article
            {
                Title = input[0],
                Content = input[1],
                Author = input[2]

            };

            for (int i = 0; i < num; i++)
            {
                var newInput = Console.ReadLine()
                    .Split(':')
                    .Select(s => s.Trim())
                    .ToList();

                if (newInput[0] == "Edit")
                {
                    article.Content = newInput[1];
                }
                else if (newInput[0] == "ChangeAuthor")
                {
                    article.Author = newInput[1];
                }
                else if (newInput[0] == "Rename")
                {
                    article.Title = newInput[1];
                }
            }

            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
        }
    }
}
