using System;
using System.Linq;
namespace Lady_Bugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] index = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] positions = command.Split(" ").ToArray();

            }

        }
    }
}
