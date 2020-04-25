using System;
using System.Linq;
using System.Collections.Generic;
namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayer = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < 100; i++)
            {
                if (firstPlayer[0] > secondPlayer[0])
                {
                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.Add(secondPlayer[0]);
                    secondPlayer.RemoveAt(0);
                    firstPlayer.RemoveAt(0);

                }
                else if (firstPlayer[0] == secondPlayer[0])
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
                else if (firstPlayer[0] < secondPlayer[0])
                {
                    secondPlayer.Add(secondPlayer[0]);
                    secondPlayer.Add(firstPlayer[0]);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);

                }
                int sumFirstPlayer = firstPlayer.Sum();
                int sumSecondPlayer = secondPlayer.Sum();
                if (sumFirstPlayer == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {sumSecondPlayer}");
                    break;
                }
                if (sumSecondPlayer == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {sumFirstPlayer}");
                    break;
                }
            }
        }
    }
}
