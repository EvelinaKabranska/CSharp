using System;
using System.Linq;
using System.Collections.Generic;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string comand = string.Empty;
            while ((comand = Console.ReadLine())!="end")
            {
                string[] comandSp = comand.Split(" ");

                switch (comandSp[0])
                {
                    case "Add":
                        {
                            int num = int.Parse(comandSp[1]);
                            nums.Add(num);
                            break;
                        }
                    case "Remove":
                        {
                            int num = int.Parse(comandSp[1]);
                            nums.Remove(num);
                            break;
                        }
                    case "RemoveAt":
                        {
                            int num = int.Parse(comandSp[1]);
                            nums.RemoveAt(num);
                            break;
                        }
                    case "Insert":
                        {
                            int num = int.Parse(comandSp[1]);
                            int num2 = int.Parse(comandSp[2]);
                            nums.Insert(num2, num);
                            break;
                        }
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
