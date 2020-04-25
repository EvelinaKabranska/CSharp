using System;
using System.Linq;
namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int half = numbers.Length / 2;

            int quarter = half / 2;

            int[] sum = new int[half];

            for (int p = 0; p <= 1; p++)
            {
                for (int i = 0; i < quarter; i++)
                {
                    int first = ((quarter - 1) + (-i)) + (p * (half + quarter));
                    int sec = quarter + i + (p * quarter);
                    sum[i + (p * quarter)] = numbers[first] + numbers[sec];
                }
            }
           
            Console.WriteLine(string.Join(' ',sum));

        }
    }
}
