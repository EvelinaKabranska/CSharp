using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;


namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new SortedDictionary<string, int>();

            using var words = new StreamReader("words.txt");
            string word = string.Empty;
            var w = new List<string>();
            while ((word=words.ReadLine())!=null)
            {
                w.Add(word);
            }
            
            String pattern = @"[a-zA-Z']+";

            Regex regex = new Regex(pattern);

            using var text = new StreamReader("text.txt");

            string cur = string.Empty;
            while ((cur = text.ReadLine()) != null)
            {
                foreach (Match match in regex.Matches(cur))
                {
                    for (int i = 0; i < w.Count; i++)
                    {
                        string c = match.Value.ToLower();

                        if (c == w[i] && !(dictionary.ContainsKey(w[i])))
                        {
                            dictionary.Add(w[i], 1);
                        }
                        else if (c == w[i])
                        {
                            dictionary[w[i]]++;
                        }
                    }
                }
            }
            using var writer = new StreamWriter(@"../../../actualResult.txt");
            foreach (var item in dictionary.OrderByDescending(x => x.Key))
            {
                writer.WriteLine("{0} - {1}", item.Key, item.Value);
            }

            using var writer1 = new StreamWriter(@"../../../expectedResult.txt");
            foreach (var item in dictionary.OrderByDescending(x => x.Value))
            {
                writer1.WriteLine("{0} - {1}", item.Key, item.Value);
            }

        }

    }
}