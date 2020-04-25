using System;
using System.Linq;
using System.Collections.Generic;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            var stack = new Stack<int>(nums);
            string comand = "";
           while((comand = Console.ReadLine().ToLower())!="end")
            {
                string[] comsp = comand.Split(" ");
                if (comsp[0]=="add")
                {
                    stack.Push(int.Parse(comsp[1]));
                    stack.Push(int.Parse(comsp[2]));
                }
                else if(comsp[0] == "remove")
                {
                    int rounds = int.Parse(comsp[1]);
                    
                    if((stack.Count)<rounds)
                    {
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < rounds; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
