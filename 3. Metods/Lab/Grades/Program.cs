using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeGrade(double.Parse(Console.ReadLine()));
        }
        static void TypeGrade(double grade)
        {
            if (grade >= 2 && grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            if (grade >= 3 && grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            if (grade >= 3.50 && grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            if (grade >= 4.50 && grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            if (grade >= 5.50 && grade <= 6)
            {
                Console.WriteLine("Excellent");
            }
        }

    }
}
