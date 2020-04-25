using System;
using System.Collections.Generic;
using System.Linq;

namespace RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();
            for (int i = 0; i < num; i++)
            {
                string nam = Console.ReadLine();
                names.Add(nam);
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
