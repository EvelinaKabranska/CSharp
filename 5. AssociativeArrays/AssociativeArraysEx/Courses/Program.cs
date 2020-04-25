using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            var cName = new Dictionary<string, List<string>>();
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputSp = input.Split(":").ToArray();
                string course = inputSp[0];
                course = course.Trim();
                string name = inputSp[1];
                name = name.Trim();
                if (!cName.ContainsKey(course))
                {
                    cName.Add(course, new List<string>());
                }
                cName[course].Add(name);
            }
            cName = cName
                .OrderByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in cName)
            {

                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                var list = item.Value.OrderBy(x => x);

                foreach (var ite2 in list)
                {
                    Console.WriteLine($"-- {ite2}");
                }

            }

        }
    }
}
