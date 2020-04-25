using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = Final(num, power);
            Console.WriteLine(result);
        }
        static double Final(double num, double power)
        {
            return Math.Pow(num, power);
        }
    }
}
