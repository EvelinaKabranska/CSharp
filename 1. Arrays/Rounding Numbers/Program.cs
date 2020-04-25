using System;
using System.Linq;


namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
           double[] nums = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                int N_rounded = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{nums[i]} => {N_rounded}");

            }
        }
    }
}
