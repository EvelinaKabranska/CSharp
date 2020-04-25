using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            int secNum = int.Parse(Console.ReadLine());
            double result = Calculate(firstNum, secNum, oper);
            Console.WriteLine(result);
        }
        static double Calculate(int num1, int num2, string op)
        {
            double result = 0;
            switch (op)
            {
                case "+":
                    {
                        result = num1 + num2;
                        break;
                    }
                case "-":
                    {
                        result = num1 - num2;
                        break;
                    }
                case "*":
                    {
                        result = num1 * num2;
                        break;
                    }
                case "/":
                    {
                        result = num1 / num2;
                        break;
                    }
            }
            return result;
        }
    }
}
