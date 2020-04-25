using System;
using System.Linq;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var together = new Dictionary<string, List<string>>();


            for (int i = 0; i < num; i++)
            {
                string word = Console.ReadLine();
                string Synonym = Console.ReadLine();

                if (!together.ContainsKey(word))
                {
                    together.Add(word, new List<string>());
                }
                together[word].Add(Synonym);
            }
            foreach (var dum in together)
            {
                Console.WriteLine($"{dum.Key} - {string.Join(", ", dum.Value)}");
            }
        }
    }
}
