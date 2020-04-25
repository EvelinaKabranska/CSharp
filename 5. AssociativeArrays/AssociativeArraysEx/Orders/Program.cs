using System;
using System.Linq;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var listProduct = new Dictionary<string, double[]>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "buy")
                {
                    break;
                }
                string[] inputProduct = input.Split().ToArray();
                string proguct = inputProduct[0];
                double price = double.Parse(inputProduct[1]);
                double quantity = double.Parse(inputProduct[2]);

                if (!listProduct.ContainsKey(proguct))
                {
                    listProduct.Add(proguct, new double[2]);
                }

                listProduct[proguct][0] = price;
                listProduct[proguct][1] += quantity;
            }
            foreach (var item in listProduct)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):f2}");
            }
        }
    }
}

