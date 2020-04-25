using System;
using System.Linq;
using System.Collections.Generic;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            var capital = text.Where(x => char.IsUpper(x[0]));
            Console.WriteLine(string.Join(Environment.NewLine,capital));
        }
    }
}
