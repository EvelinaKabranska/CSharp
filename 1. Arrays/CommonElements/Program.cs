using System;
using System.Linq;
using System.Collections.Generic;
namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> final = new List<string>();
            string[] firstArray = Console.ReadLine()
                 .Split(" ")
                 .ToArray();

            string[] secondArray = Console.ReadLine()
                 .Split(" ")
                 .ToArray();
            
            foreach (var thing in secondArray)
            {
                foreach (var item in firstArray)
                {
                    if(thing==item)
                    {
                        final.Add(thing);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",final));

        }
    }
}
