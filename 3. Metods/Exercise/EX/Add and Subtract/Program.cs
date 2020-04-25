using System;

namespace Add_and_Subtract
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = 0;
            int sub = 0;

            sum= Sum(a, b);
            sub = Subtract(sum, c);

            Console.WriteLine(sub);
        }
        static int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static int Subtract(int sum, int c)
        {
            int subtract = sum - c;
            return subtract;
        }
    }
}
