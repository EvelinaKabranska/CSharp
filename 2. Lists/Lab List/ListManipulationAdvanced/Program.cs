using System;
using System.Linq;
using System.Collections.Generic;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string comand = string.Empty;
            while ((comand = Console.ReadLine()) != "end")
            {
                string[] comandSp = comand.Split(" ");

                switch (comandSp[0])
                {
                    case "Contains":
                        {
                            int num = int.Parse(comandSp[1]);
                            foreach (var item in nums)
                            {
                                if(item==num)
                                {
                                    Console.WriteLine("Yes");
                                }
                                else
                                {
                                    Console.WriteLine("No such number");
                                }
                            }
                            
                            break;
                        }
                    case "PrintEven":
                        {
                            List<int> test = nums;
                            foreach (var item in test)
                            {
                              if(item%2==0)
                                {
                                    Console.Write($"{item} ");
                                }
                            }
                            break;
                        }
                    case "PrintOdd":
                        {
                            List<int> test = nums;
                            foreach (var item in test)
                            {
                                if (item % 2 != 0)
                                {
                                    Console.Write($"{item} ");
                                }
                            }

                            break;
                        }
                    case "GetSum":
                        {
                            Console.WriteLine(nums.Sum());
                            break;
                        }
                    case "Filter":
                        {
                            string cond = comandSp[1];
                            int num = int.Parse(comandSp[2]);
                            if(cond==">")
                            {
                                foreach (var item in nums)
                                {
                                    if(item>num)
                                    {
                                        Console.Write($"{item} ");
                                    }
                                }
                            }
                            else if (cond == "<")
                            {
                                foreach (var item in nums)
                                {
                                    if (item < num)
                                    {
                                        Console.Write($"{item} ");
                                    }
                                }
                            }
                            else if (cond == ">=")
                            {
                                foreach (var item in nums)
                                {
                                    if (item >= num)
                                    {
                                        Console.Write($"{item} ");
                                    }
                                }
                            }
                            else if (cond == "<=")
                            {
                                foreach (var item in nums)
                                {
                                    if (item <= num)
                                    {
                                        Console.Write($"{item} ");
                                    }
                                }
                            }
                            break;
                        }
                    
                }
            }
         
        }
    }
}
