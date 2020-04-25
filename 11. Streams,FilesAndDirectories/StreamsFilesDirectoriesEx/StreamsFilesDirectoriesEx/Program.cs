using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
namespace StreamsFilesDirectoriesEx
{
    class Program
    {
        private static string ReversedWords(string replacedSymbols)
        {
            return string.Join(" ", replacedSymbols.Split().Reverse());
        }

        private static string ReplaceSpecialCharacters(string line)
        {
            return line.Replace("-", "@")
                 .Replace("?", "@")
                 .Replace(",", "@")
                 .Replace(".", "@")
                 .Replace("!", "@");
        }

        static void Main(string[] args)
        {
            using var sent = new StreamReader("text.txt");
            int count = 1;
            string curent = string.Empty;
            while ((curent = sent.ReadLine()) != null)
            {
               
                    if(count%2!=0)
                    {
                        string replacedSymbols = ReplaceSpecialCharacters(curent);
                        string reversedWords = ReversedWords(replacedSymbols);

                        Console.WriteLine(reversedWords);
                    }
                count++;
            }
        }
    }
}
