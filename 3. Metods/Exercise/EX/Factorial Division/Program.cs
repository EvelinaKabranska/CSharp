using System;

namespace Factorial_Division
{
    class Program
    {
        static double Factorial(int x)
        {
            double fin = 1;
            for (int i = 1; i <=x; i++)
            {
                fin *= i;
            }
            return fin;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double Fac1 = Factorial(a);
            double Fac2 = Factorial(b);
            double fiinn = Fac1 / Fac2;
            Console.WriteLine($"{fiinn:f2}");
            
        }
    }
}
