using System;
using System.Collections.Generic;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int longLenght = 1;
            int curLenght = 1;
            int longStart = 0;
            int curStart = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i]==numbers[i-1])
                {
                    curLenght++;
                    if(curLenght>longLenght)
                    {
                        longLenght = curLenght;
                        longStart = curStart;
                    }
                }
                else
                {
                    curLenght = 1;
                    curStart = i;
                }
            }

            for (int i = longStart; i < longStart+longLenght; i++)
            {
                Console.Write(numbers[i]+" ");
            }

           
        }
    }
}
