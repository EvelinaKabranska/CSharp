using System;
using System.Linq;
namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
               .Split(" ")
               .Select(int.Parse)
               .ToArray();
            int sum = 0;
            bool yes = true;
            int index = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if(num[i]!=numbers[i])
                {
                    yes = false;
                    index = i;
                    break;
                }
                sum += num[i];
            }

            if(yes)
            { 
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }
        }
    }
}
