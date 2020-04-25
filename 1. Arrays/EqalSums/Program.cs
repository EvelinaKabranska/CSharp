using System;
using System.Linq;
namespace EqalSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftsum = 0;
            int rightsum = a.Sum();

            for (int i = 0; i < a.Length; i++)
            {
                rightsum = rightsum - a[i];

                if (leftsum == rightsum)
                {
                    Console.WriteLine(i);
                    return;

                }

                leftsum = leftsum + a[i];


            }
            Console.WriteLine("no");
        }
    }
}
