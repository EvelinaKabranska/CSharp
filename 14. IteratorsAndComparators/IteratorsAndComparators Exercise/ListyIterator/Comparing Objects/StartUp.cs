using System;
using System.Linq;
using System.Collections.Generic;

namespace ListyIterator
{
    public class StartUp
    {
       public static void Main()
        {
            var people = new List<Person>();
            string comand = string.Empty;

            while ((comand=Console.ReadLine())!="END")
            {
                var tokens = comand.Split().ToArray();
                people.Add(new Person(tokens[0], int.Parse(tokens[1]), tokens[2]));
            }

            int index = int.Parse(Console.ReadLine())-1;

            Person person = people[index];

            int equalcounter = 0;
            int nonequalcounter = 0;

            foreach (var man in people)
            {
                if(man.CompareTo(person)==0)
                {
                    equalcounter++;
                }
                else
                {
                    nonequalcounter++;
                }
            }
            if(equalcounter>1)
            {
                Console.WriteLine($"{equalcounter} {nonequalcounter} {equalcounter + nonequalcounter}");
            }
            else
            {
                Console.WriteLine("No matches");
            }

        }
    }
}
