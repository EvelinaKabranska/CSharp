using System;
using System.Collections.Generic;
using System.Linq;
namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = string.Empty;
            var vipnames = new HashSet<string>();
            var otherNames = new HashSet<string>();
           
            while ((comand = Console.ReadLine()) != "PARTY")
            {
                if (char.IsDigit(comand[0]))
                {
                    vipnames.Add(comand);
                }
                else
                {
                    otherNames.Add(comand);
                }
            }

            while ((comand = Console.ReadLine()) != "END" )
            {
                    vipnames.Remove(comand);
                    otherNames.Remove(comand);
            }
                int count = vipnames.Count + otherNames.Count;
                Console.WriteLine(count);

                
                foreach (var name in vipnames)
                {
                    Console.WriteLine(name);
                }
                foreach (var name in otherNames)
                {
                    Console.WriteLine(name);
                }
        }
    }
}
