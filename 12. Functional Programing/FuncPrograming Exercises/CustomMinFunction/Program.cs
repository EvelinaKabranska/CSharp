using System;
using System.Linq;
using System.Collections.Generic;

namespace CustomMinFunction
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] numbersArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> find = x =>
            {
                int minNum = int.MaxValue;
                foreach (var item in numbersArray)
                {
                    if (item < minNum)
                    {
                        minNum = item;
                    }
                }
                return minNum;
            };
            Action<int> print = x => Console.WriteLine(x);
            print(find(numbersArray));

        }
    }
}
