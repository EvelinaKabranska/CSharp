using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
         
            
            var cur = new List<char>();
            foreach (var item in comand)
            {
                cur.Add(item);
            }

            for (int i = 1; i < cur.Count; i++)
            {
                char cure = cur[i];
                char prev = cur[i - 1];

                if(cure==prev)
                {
                    cur.RemoveAt(i);
                    i--;
                }
            }
            foreach (var item in cur)
            {
                Console.Write(item);
            }


        }
    }
    }

