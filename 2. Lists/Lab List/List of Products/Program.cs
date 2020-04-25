using System;
using System.Collections.Generic;
using System.Linq;
namespace List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> produ = new List<string>(n);

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                produ.Add(product);
            }
            produ.Sort();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}.{produ[i]}");

            }
        }
    }
}
