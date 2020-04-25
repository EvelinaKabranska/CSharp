using System;

namespace EX
{
    class Program
    {
        static int minNum = int.MaxValue;
        static int currentNum;
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                currentNum = int.Parse(Console.ReadLine());
                Check(currentNum);
            }
            Console.WriteLine(minNum);
        }
        static void Check(int currentNum)
        {
            if (minNum > currentNum)
            {
                minNum = currentNum;
            }
        }
    }
}
