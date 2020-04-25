using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                  .Split(" ")
                  .ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                string curent = words[i];
                int lenght = curent.Length;
                for (int j = 0; j < lenght; j++)
                {
                    Console.Write(curent);
                }

            }
        }
    }
}
