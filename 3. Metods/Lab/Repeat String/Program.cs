using System;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            Repeat(times, text);
        }
        static void Repeat(int times, string text)
        {
            for (int i = 1; i <= times; i++)
                Console.Write(text);
        }
    }
}
