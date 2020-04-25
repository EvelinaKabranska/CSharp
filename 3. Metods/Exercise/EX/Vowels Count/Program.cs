using System;

namespace Vowels_Count
{
    class Program
    {
        static int count;
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            word = word.ToLower();
            CheckVowels(word);
            Console.WriteLine(count);
        }
        static void CheckVowels(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'u' || word[i] == 'y' || word[i] == 'o' || word[i] == 'i')
                {
                    count++;
                }
            }
        }
    }
}
