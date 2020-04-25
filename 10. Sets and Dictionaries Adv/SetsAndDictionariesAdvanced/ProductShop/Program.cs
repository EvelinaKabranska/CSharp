using System;
using System.Linq;
using System.Collections.Generic;

namespace ProductShop
{
    public class Product
    {
        public string PrdName {get; set;}
        public double PrdPrice { get; set; }

    }
    class Program
    {

        static void Main(string[] args)
        {
          var cataloge = new SortedDictionary<string, List<Product>> ();
            string comand = string.Empty;

            while ((comand = Console.ReadLine()) != "Revision")
            {
                string[] Spcomand = comand.Split(", ").ToArray();

                if (!cataloge.ContainsKey(Spcomand[0]))
                {
                    cataloge.Add(Spcomand[0], new List<Product>());
                }
                var pr = new Product();
                pr.PrdName = Spcomand[1];
                pr.PrdPrice = double.Parse(Spcomand[2]);
                cataloge[Spcomand[0]].Add(pr);
            }

            foreach (var item in cataloge)
            {
                Console.WriteLine($"{item.Key} ->");
                foreach (var i in item.Value)
                {
                    Console.WriteLine($"Product: {i.PrdName}, Price: {i.PrdPrice}");
                }
                

            }

        }
    }
}