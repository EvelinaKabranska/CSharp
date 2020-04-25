using System;
using System.Linq;
using System.Collections.Generic;
namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .Reverse().ToList();

            for (int i = 0; i < arrays.Count; i++)
            {
                List<string> final = arrays[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var item in final)
                {
                    Console.Write($"{item} ");
                }
                    
                }
            }
        }
    }

