using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
           
            Bill(product, num);
           
        }
        static void Bill(string product, int num)
        {
            double sum = 0;
            if (product == "coffee")
            {
                sum = num * 1.50;
            }
            else if (product == "water")
            {
                sum = num * 1.00;
            }
            else if (product == "coke")
            {
                sum = num * 1.40;
            }
            else if (product == "snacks")
            {
                sum = num * 2.00;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
