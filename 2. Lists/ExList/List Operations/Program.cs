using System;
using System.Collections.Generic;
using System.Linq;
namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();


            string comand = Console.ReadLine();
            while (comand != "End")
            {
                string[] comandSplit = comand.Split();

                if (comandSplit[0] == "Add")
                {
                    numbers.Add(int.Parse(comandSplit[1]));
                }
                if (comandSplit[0] == "Insert")
                {
                    if ((int.Parse(comandSplit[2]) > numbers.Count))
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {
                        numbers.Insert(int.Parse(comandSplit[2]), int.Parse(comandSplit[1]));
                    }
                }
                if (comandSplit[0] == "Remove")
                {
                    if ((int.Parse(comandSplit[1]) > numbers.Count))
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {
                        numbers.RemoveAt(int.Parse(comandSplit[1]));
                    }
                }
                if (comandSplit[1] == "left")
                {
                    int times = int.Parse(comandSplit[2]);

                    for (int i = 0; i < times; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);

                    }

                }
                if (comandSplit[1] == "right")
                {
                    int times = int.Parse(comandSplit[2]);
                    for (int i = 0; i < times; i++)
                    {


                        numbers.Insert(0, numbers[numbers.Count - 1]);
                        numbers.RemoveAt(numbers.Count - 1);

                    }
                }


                comand = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
