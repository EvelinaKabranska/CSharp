using System;
using System.Numerics;

namespace BigFactoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;

            for (int i = 1; i <= N; i++)
            {

                factoriel = factoriel * i;

            }
            Console.WriteLine(factoriel);
        }
    }
}
