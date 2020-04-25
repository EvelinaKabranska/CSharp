using System;

namespace Print_number_in_reverse_order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] line = new int[n];

            for (int i = 0; i < n; i++)

            {
                int number = int.Parse(Console.ReadLine());
                line[i] = number;
            }
            for (int j = line.Length - 1; j >= 0; j--)
            {
                Console.Write(line[j] + " ");
            }
        }
    }
}
