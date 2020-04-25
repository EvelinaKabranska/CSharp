using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TextProcesingEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(", ").ToArray();
            var valid = new List<string>();

            foreach (var item in names)
            {
                if (item.Length >= 3 && item.Length <= 16)
                {
                    bool validUsernames = ValidUserNames(item);

                    if (validUsernames)
                    {
                        valid.Add(item);
                    }
                }
            }


            Console.WriteLine(string.Join(Environment.NewLine, valid));
        }
        private static bool ValidUserNames(string user)
        {
            foreach (var symbol in user)
            {
                if (char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
