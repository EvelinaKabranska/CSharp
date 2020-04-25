using System;
using System.Collections.Generic;
using System.Linq;

public class LegendaryFarming
{
    public static void Main()
    {
        var materials = Console.ReadLine().ToLower().Split().ToList();

        Dictionary<string, int> legendary = new Dictionary<string, int>();

        legendary["shards"] = 0;
        legendary["fragments"] = 0;
        legendary["motes"] = 0;

        SortedDictionary<string, int> junk = new SortedDictionary<string, int>();
        bool end = false;

        while (!end)
        {
            for (int i = 0; i < materials.Count - 1; i += 2)
            {
                var quantity = int.Parse(materials[i]);
                var materialKind = materials[i + 1];

                if (materialKind == "shards")
                {
                    legendary["shards"] += quantity;
                    end = CheckTheResult(legendary, junk);
                    if (end) break;
                }
                else if (materialKind == "fragments")
                {
                    legendary["fragments"] += quantity;
                    end = CheckTheResult(legendary, junk);
                    if (end) break;
                }
                else if (materialKind == "motes")
                {
                    legendary["motes"] += quantity;
                    end = CheckTheResult(legendary, junk);
                    if (end) break;
                }
                else
                {
                    if (!junk.ContainsKey(materialKind))
                    {
                        junk[materialKind] = 0;
                    }
                    junk[materialKind] += quantity;
                }
            }

            if (end) break;
            materials = Console.ReadLine().ToLower().Split().ToList();
        }
    }

    public static bool CheckTheResult(Dictionary<string, int> legendary, SortedDictionary<string, int> junk)
    {
        var winner = "";
        var remainder = 0;

        foreach (var item in legendary)
        {
            if (item.Value >= 250)
            {
                winner = item.Key;
                remainder = item.Value - 250;
                legendary[winner] = remainder;

                PrintResult(legendary, junk, winner);
                return true;
            }
        }
        return false;
    }

    public static void PrintResult(Dictionary<string, int> legendary, SortedDictionary<string, int> junk, string winner)
    {
        var winnerName = "";

        if (winner == "shards")
        {
            winnerName = "Shadowmourne";
        }
        else if (winner == "fragments")
        {
            winnerName = "Valanyr";
        }
        else if (winner == "motes")
        {
            winnerName = "Dragonwrath";
        }

        Console.WriteLine("{0} obtained!", winnerName);
        foreach (var kvp in legendary.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
        }
        foreach (var kvp in junk)
        {
            Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
        }
    }
}













