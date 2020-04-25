using System;
using System.Collections.Generic;
using System.Linq;


namespace CountCharsInString
{
    class Program
    {

        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            text = text.Replace(" ", String.Empty);
            var count = new Dictionary<char, int>();

            foreach (var cha in text)
            {
                if (!count.ContainsKey(cha))
                {
                    count.Add(cha, 0);
                }
                count[cha]++;
            }
            foreach (var item in count)
            {

                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
