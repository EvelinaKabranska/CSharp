using System;
using System.Linq;
using System.Collections.Generic;
namespace final
{
    class Program
    {
     
        static void Main(string[] args)
        {
           int num = Math.Abs(int.Parse(Console.ReadLine()));
            int result = FindResult(num);
            Console.WriteLine(result); 
        }
        static int FindResult(int num)
        {
            int result = FindSumOfOdd(num) * FindSumOFEvens(num);
            return result;
        }
        static int FindSumOfOdd(int num)
        {
            int sum = 0;
            while(num>0)
            {
                int nextnum = num % 10;
                num /= 10;
                if(nextnum%2!=0)
                {
                    sum += nextnum;
                }
            }
            return sum;
        }
        static int FindSumOFEvens(int num)
        {
            int sum = 0;
            while(num>0)
            {
                int nextnum = num % 10;
                num /= 10;
                if(nextnum%2==0)
                {
                    sum += nextnum;
                }
            }
            return sum;
        }

    }
}
