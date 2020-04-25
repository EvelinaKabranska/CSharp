using System;
using System.Linq;
using System.Collections.Generic;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(1);
            
            if(num>1)
            {
                int[] current = { 1,1 };
                Console.WriteLine(String.Join(' ', current));

                if (num > 2)
                {
                    for (int i = 2; i < num; i++)
                    {
                        int[] NextRow = new int[current.Length+1];
                        
                        NextRow[0] = 1;
                        NextRow[i] = 1;

                        for (int j = 1; j < NextRow.Length-1; j++)
                        {
                            NextRow[j] = current[j - 1] + current[j];
                        }
                        Console.WriteLine(string.Join(' ', NextRow));

                        current = NextRow;
                    }
                }
            }
        }
    }
}
