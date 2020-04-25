using System;
using System.Linq;
namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {

                int temp = numbers[0];
                for (int j = 0; j < numbers.Length-1; j++)
                {
                    numbers[j] = numbers[j+1];
                }
                numbers[numbers.Length-1] = temp;

            }
            Console.WriteLine("{0}",string.Join(" ",numbers));
                
                
        }
    }
}
