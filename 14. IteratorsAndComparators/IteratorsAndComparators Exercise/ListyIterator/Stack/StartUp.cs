using System;
using System.Linq;
using System.Collections.Generic;
namespace ListyIterator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            string comand = string.Empty;
            while ((comand=Console.ReadLine()) != "END")
            {
                string[] splitedComand = comand.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                if(splitedComand[0]== "Push")
                {
                    var numbers = splitedComand.Skip(1).Select(i => i.Split(',').First()).Select(int.Parse).ToArray();
                    stack.Push(numbers);
                }
                else if (splitedComand[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException ioe)
                    {
                        Console.WriteLine(ioe.Message);
                    }
                }
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
