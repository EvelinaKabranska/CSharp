using System;
using System.Linq;
using System.Collections.Generic;

namespace Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
               .Split(" ");

            var counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordInLowerCase = word.ToLower();

                if (!counts.ContainsKey(wordInLowerCase))
                {
                    counts.Add(wordInLowerCase, 0);
                }
               
                    counts[wordInLowerCase]++;
                
            }

            foreach (var wor in counts)
            {
                if (wor.Value % 2 != 0)
                {
                    Console.Write(wor.Key + " ");

                }
            }
        
        }
    }
}
