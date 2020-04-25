using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            MiddleCar(word);
        }
        static void MiddleCar(string word)
        {
            int num = word.Length / 2;
            if (word.Length % 2 == 0)
            {
                Console.Write(word[num - 1]);
                Console.Write(word[num]);
            }
            else
            {
                Console.Write(word[num]);
            }
        }
    }
}
