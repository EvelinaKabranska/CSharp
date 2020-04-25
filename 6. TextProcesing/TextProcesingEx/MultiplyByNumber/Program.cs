using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MultiplyByNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            StringBuilder builder = new StringBuilder();
            int onMind = 0;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(num[i].ToString());
                int result = currentDigit * b + onMind;
                builder.Append(result % 10);
                onMind = result / 10;
            }

            if (onMind != 0)
            {
                builder.Append(onMind);
            }
            string resultNum = string.Join("", builder.ToString().Reverse()).TrimStart('0');
            if (resultNum == string.Empty)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(resultNum);
            }
        }
    }
}