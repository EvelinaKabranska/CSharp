using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(" ").ToArray();
            var sumAr = new List<int>();
            int sum = 0;

            if(names[0].Length>names[1].Length)
            {
                for (int i = 0; i < names[1].Length; i++)
                {
                    char a = names[0][i];
                    char b = names[1][i];
                    int c = a * b;

                    sumAr.Add(c);
                }
                for (int i = names[1].Length; i < names[0].Length; i++)
                {
                    char a = names[0][i];
                    sumAr.Add(a);
                }
            }
            else if(names[0].Length < names[1].Length)
            {
                for (int i = 0; i < names[0].Length; i++)
                {
                    char a = names[0][i];
                    char b = names[1][i];
                    int c = a * b;

                    sumAr.Add(c);
                }
                for (int i = names[0].Length ; i < names[1].Length; i++)
                {
                    char a = names[1][i];
                    sumAr.Add(a);
                }
            }
            else
            {
                for (int i = 0; i < names[1].Length; i++)
                {
                    char a = names[0][i];
                    char b = names[1][i];
                    int c = a * b;

                    sumAr.Add(c);
                }
            }

            sum = sumAr.Sum();
            Console.WriteLine(sum);
        }
    }
}
