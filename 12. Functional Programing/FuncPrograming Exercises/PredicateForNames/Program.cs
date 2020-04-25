using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split(" ").ToList();
            Predicate<string> com = x => { return x.Length <= lenght; };
            Func<List<string>,string> joinnn =x=> string.Join(Environment.NewLine,x);
            Action<string> print = x => Console.WriteLine(x);
            var fin = new List<string>();
            fin = names.FindAll(com);
            print(joinnn(fin));

        }
    }
}
