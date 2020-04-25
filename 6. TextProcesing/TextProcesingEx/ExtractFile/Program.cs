using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var link = Console.ReadLine().Split(@"\").ToArray();

            string file = link[link.Length-1];

            var Sp = file.Split(".").ToArray();

            Console.WriteLine($"File name: {Sp[0]}");
            Console.WriteLine($"File extension: {Sp[1]}");
        }
    }
}
