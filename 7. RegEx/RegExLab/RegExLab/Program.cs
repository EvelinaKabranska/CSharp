using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace RegExLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string regular = @"\b[A-Z][a-z]+\b \b[A-Z][a-z]+\b";

            string names = Console.ReadLine();

            MatchCollection matchNames = Regex.Matches(names, regular);

            foreach (Match item in matchNames)
            {
                Console.Write(item.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
