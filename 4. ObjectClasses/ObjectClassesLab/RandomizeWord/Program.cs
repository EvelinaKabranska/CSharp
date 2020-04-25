using System;
using System.Linq;

namespace RandomizeWord
{
    class Program
    {
        Random num = new Random();
        static void Main(string[] args)
        {

            var rand = new Random();
            var words = Console.ReadLine()
                .Split(' ')
                .ToArray();
            for (int i = 0; i < words.Length; i++)
            {
                int j = rand.Next(0, words.Length);
                if (words[i] != words[j])
                {
                    string old = words[i];
                    words[i] = words[j];
                    words[j] = old;
                }

            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

        }
    }
}
