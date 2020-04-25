using System;
using System.Linq;

namespace TextProcesing

{
    class Program
    {
        static string Rverce(string text)
        {

            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

        static void Main(string[] args)
        {
            string comand = "";
            while ((comand = Console.ReadLine()) != "end")
            {

                Console.WriteLine($"{comand} = {Rverce(comand)}");
            }
        }
    }
}
