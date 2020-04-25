using System;
using System.Linq;

namespace proba
{
    class Program
    {
        static void Main(string[] args)
        {
            int border = int.Parse(Console.ReadLine());
            int[,] matrix = new int[border, border];

            for (int i = 0; i < border; i++)
            {
                int[] rows = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < border; j++)
                {
                    matrix[i, j] = rows[j];
                }
            }

            string comand = string.Empty;
            while (comand != "END")
            {
                string[] comandSp = comand.Split(" ").ToArray();
                if (comandSp[0] == "Add")
                {

                    int num1 = int.Parse(comandSp[1]);
                    int num2 = int.Parse(comandSp[2]);
                    int num3 = int.Parse(comandSp[3]);
                    if (num1 >= 0 && num1 < border && num2 >= 0 && num2 < border)
                    {
                        matrix[num1, num2] += num3;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (comandSp[0] == "Subtract")
                {
                    int num1 = int.Parse(comandSp[1]);
                    int num2 = int.Parse(comandSp[2]);
                    int num3 = int.Parse(comandSp[3]);


                    if (num1 >= 0 && num1 < border && num2 >= 0 && num2 < border)
                    {
                        matrix[num1, num2] -= num3;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                comand = Console.ReadLine();
            }
            for (int i = 0; i < border; i++)
            {
                for (int j = 0; j < border; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
