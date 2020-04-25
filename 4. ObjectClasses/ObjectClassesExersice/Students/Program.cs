using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Linq;

namespace Students
{
    class Program
    {

        public class Student
        {
           public string FirstName {get; set;}
            public string SecName { get; set; }
            public double Grade { get; set; }

            public Student(string first,string sec,double gr)

            {
                FirstName = first;
                SecName = sec;
                Grade = gr;
            }
            public override string ToString()
            {
                return $"{FirstName} - {SecName}: {Grade:f2}";
            }

        };
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            var all = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                var studen = new Student(input[0], input[1], double.Parse(input[2]));

                all.Add(studen);
            }
            all = all.OrderByDescending(x =>  x.Grade).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, all));
        }
    }
}
