using System;
using System.Linq;
using System.Collections.Generic;

namespace Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] full = new int[count];

            for (int i = 0; i < count; i++)
            {
                int sum = 0;
                string name = Console.ReadLine();
                int nameLength = name.Length;
                foreach (var item in name)
                {
                    char letter = item;
                    if (letter == 'a' || letter=='e' || letter== 'u' || letter == 'o' || letter == 'i' || letter == 'E' || letter == 'U' || letter == 'I' || letter == 'O' || letter == 'A' )
                    {
                        sum += letter * nameLength;
                    }
                    else
                    {
                        sum += letter / nameLength;
                    }
                    full[i] = sum;
                }
            }
            Array.Sort(full);
            Console.WriteLine(string.Join('\n', full));
        }
    }
}
