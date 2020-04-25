using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsExercises
{
    class Program
    {


        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            string[] Phrases = { "Now I feel good.",
                "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"};

            string[] Events =  { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };

            string[] Authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] Cities  = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random num = new Random();

            for (int i = 0; i < number; i++)
            {

                string PhraseIndex = Phrases[num.Next(0, Phrases.Length)];
                string EventIndex = Events[num.Next(0, Events.Length)];
                string AuthorIndex = Authors[num.Next(0, Authors.Length)];
                string CityIndex = Cities[num.Next(0, Cities.Length)];


                Console.WriteLine(PhraseIndex + " " + EventIndex + " " + AuthorIndex + " - " + CityIndex);
            }

        }
    }
}