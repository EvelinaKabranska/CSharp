using System;
using System.Linq;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] array = { 1, 1 };
            int sum = 0;
            if (num == 2)
            {
                Console.WriteLine(1);
                Console.WriteLine(1);

            }
            for (int i = 2; i < num; i++)
            {
                sum = array[0] + array[1];
                int[] newArray = { array[1], sum };
                array = newArray;
            }

            Console.WriteLine(sum);
        }
    }
}
