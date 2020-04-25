using System;
using System.Linq;
using System.Collections.Generic;
namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();
                string[] splitedLine = line.Split();
                string comand = splitedLine[0];
                if (line == "end")
                {
                    break;
                }
                if (comand == "Delete")
                {
                    int a = int.Parse(splitedLine[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers.Remove(a);
                    }
                }
                if (comand == "Insert")
                {
                    int b = int.Parse(splitedLine[1]);
                    int c = int.Parse(splitedLine[2]);
                    numbers.Insert(c, b);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
