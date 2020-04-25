using System;
using System.Linq;
using System.Collections.Generic;
namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            Greater(num1, num2, type);
        }
        static void Greater(string num1, string num2, string type)
        {
            if (type == "int")
            {
                int num11 = int.Parse(num1);
                int num12 = int.Parse(num2);
                if (num11 >= num12)
                {
                    Console.WriteLine(num11);
                }
                else
                {
                    Console.WriteLine(num12);
                }
            }
            if (type == "string")
            {
                if (num1.CompareTo(num2) >= 0)
                {
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine(num2);
                }
            }
            if (type == "char")
            {
                char a = char.Parse(num1);
                char b = char.Parse(num2);

                if (a>b)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}
