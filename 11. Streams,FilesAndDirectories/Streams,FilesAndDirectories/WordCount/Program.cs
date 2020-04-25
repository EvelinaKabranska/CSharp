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

            var spWords = words.ReadLine().Split(" ").ToArray();

            String pattern = @"[a-zA-Z']+";

            Regex regex = new Regex(pattern);

            using var text = new StreamReader("text.txt");

            string cur = string.Empty;
            while ((cur=text.ReadLine())!=null)
            {
                foreach (Match match in regex.Matches(cur))
                {
                    for (int i = 0; i <spWords.Length ; i++)
                    {
                        string c = match.Value.ToLower();

                        if(c==spWords[i]&&!(dictionary.ContainsKey(spWords[i])))
                        {
                            dictionary.Add(spWords[i], 1);
                        }
                        else if(c==spWords[i])
                        {
                            dictionary[spWords[i]]++;
                        }
                    }
                }
            }
            using var writer = new StreamWriter(@"../../../Output.txt");
            foreach (var item in dictionary.OrderByDescending(x=>x.Value))
            {
               writer.WriteLine("{0} - {1}", item.Key, item.Value);
            }

            

        }

    }
}