using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DigitsLettersOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var numbers = new StringBuilder();
            var letters = new StringBuilder();
            var other = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char chartext = text[i];

                if (char.IsDigit(chartext))
                {
                    numbers.Append(chartext);
                }
                else if (char.IsLetter(chartext))
                {
                    letters.Append(chartext);
                }
                else
                {
                    other.Append(chartext);
                }
            }
            Console.WriteLine($"{numbers}\n{letters}\n{other}");


        }
    }
}
