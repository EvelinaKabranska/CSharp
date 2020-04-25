using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
namespace Students
{
    class Program
    {
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string City { get; set; }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "end")
            {
                string[] tokens = line.Split(" ");

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string city = tokens[3];
                bool a = false;
                foreach (var item in students)
                {
                    if (item.FirstName == firstName && item.LastName == lastName)
                    {

                        item.Age = age;
                        item.City = city;
                        a = true;

                    }
                }

                if (a == false)
                {
                    Student student = new Student();
                    {
                        student.FirstName = firstName;
                        student.LastName = lastName;
                        student.Age = age;
                        student.City = city;
                    };

                    students.Add(student);
                }
            }
            string filterCity = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.City == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}

