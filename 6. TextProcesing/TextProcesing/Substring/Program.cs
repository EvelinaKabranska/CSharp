using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string SecoundString = Console.ReadLine();
            firstString = firstString.ToLower();
            SecoundString = SecoundString.ToLower();

            while (SecoundString.Contains(firstString))
            {
                SecoundString = SecoundString.Replace(firstString, string.Empty);

            }
            Console.WriteLine(SecoundString);


        }
    }
}
