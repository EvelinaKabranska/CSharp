using System;
using System.Linq;
using System.Collections.Generic;

namespace ExList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToList();

            int capacity = int.Parse(Console.ReadLine());

            string comand = Console.ReadLine();
            string[] splitComand = comand.Split();

            while (comand != "end")
            {
                if (splitComand[0] == "Add")
                {
                    int stringToNum = int.Parse(splitComand[1]);
                    numbers.Add(stringToNum);
                }
                else
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int stringToNum = int.Parse(splitComand[0]);
                        if ((stringToNum + numbers[i]) <= capacity)
                        {
                            numbers[i] += stringToNum;
                            break;
                        }
                    }
                }
                comand = Console.ReadLine();
                splitComand = comand.Split();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
