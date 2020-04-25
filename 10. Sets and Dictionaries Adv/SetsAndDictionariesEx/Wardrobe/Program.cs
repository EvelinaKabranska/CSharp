using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int number = int.Parse(Console.ReadLine());

            for (int index = 0; index < number; index++)
            {
                string[] clothesLine = Console.ReadLine().Split(" -> ");
                string color = clothesLine[0];
                string[] clothes = clothesLine[1].Split(",");

                if (wardrobe.ContainsKey(color) == false)
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (string item in clothes)
                {
                    if (wardrobe[color].ContainsKey(item) == false)
                    {
                        wardrobe[color].Add(item, 0);
                    }

                    wardrobe[color][item]++;
                }
            }

            string[] wanted = Console.ReadLine().Split();
            string colorNeeded = wanted[0];
            string itemNeeded = wanted[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                Dictionary<string, int> clothesLine = color.Value;

                foreach (var item in clothesLine)
                {
                    string output = $"* {item.Key} - {item.Value}";

                    if (colorNeeded == color.Key && itemNeeded == item.Key)
                    {
                        output += " (found!)";
                    }

                    Console.WriteLine(output);
                }
            }
        }
    }
}