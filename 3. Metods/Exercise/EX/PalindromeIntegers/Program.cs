using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                string comand = Console.ReadLine();
                while (comand != "END")
                {
                    CheckPalindron(comand);
                    comand = Console.ReadLine();
                }
            }
            static void CheckPalindron(string comand)
            {
                string reverse = string.Empty;
                for (int i = comand.Length - 1; i >= 0; i--)
                {
                    reverse += comand[i];
                }
                if (reverse == comand)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
