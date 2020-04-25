using System;
using System.Linq;
namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letter = Console.ReadLine().Split(" ").ToArray();
            for (int i = letter.Length-1; i >=0; i--)
            {
                Console.Write(letter[i]+" ");
            }
        }
    }
}
