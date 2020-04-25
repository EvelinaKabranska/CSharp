using System;
using System.Linq;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var trafic = new Queue<string>();
            string cars = "";
            int count = 0;
            while (cars!="end")
            {
                cars = Console.ReadLine();    
                if (cars == "green")
                {
                    
                    for (int i = 0; i <number ; i++)
                    {
                        if(trafic.Count>0)
                        { 
                        Console.WriteLine($"{trafic.Dequeue()} passed!");
                        count++;
                        }
                    }
                }
                else
                { 
                trafic.Enqueue(cars);
                }
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
