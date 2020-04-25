using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            Func<int, bool> fin = x => x % num != 0;
            Func<int[], string> print = x => string.Join(" ", x);
            Action<string> pr = x => Console.WriteLine(x);
            var remain = numbers.Reverse().Where(fin).ToArray();
            pr(print(remain));

        }
    }
}
