using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    public class Person
    {
        public string Name;
        public int Age;
       public Person(string name,int age)
        {
            this.Name=name;
            this.Age = age;
        }
    }      
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                var info = Console.ReadLine().Split(", ").ToArray();
                string name = info[0];
                int age = int.Parse(info[1]);
               var person = new Person(name,age);
                people.Add(person);
            }
            string limit = Console.ReadLine();
            int Age = int.Parse(Console.ReadLine());
            
            Func<Person, bool> predicate; 

            if(limit=="older")
            {
                predicate = x => x.Age >= Age;
            }
            else if(limit=="younger")
            {
                predicate = x => x.Age < Age;
            }
            else
            {
                predicate = x => true;
            }

            var filteredPeople = people.Where(predicate);
            var format = Console.ReadLine();

            foreach (var person in filteredPeople)
            {
               
                if (format =="name age")
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
                else if (format == "name")
                {
                    Console.WriteLine(person.Name);
                }
               else if (format == "age")
                {
                    Console.WriteLine(person.Age);
                }
            }
        }
    }
}
