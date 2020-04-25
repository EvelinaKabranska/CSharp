using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();

            foreach (var cer in comand)
            {
                char a = cer;
                int b = (int)a;
                b += 3;
                a = (char)b;
                Console.Write(a);
            } 
        }
    }
}
