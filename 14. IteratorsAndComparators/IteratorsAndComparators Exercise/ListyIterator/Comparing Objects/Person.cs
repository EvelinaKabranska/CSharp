using System;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
   public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;

        public Person(string Name,int Age, string Town)
        {
            this.name = Name;
            this.age = Age;
            this.town = Town;
        }
        public int CompareTo (Person other)
        {
            if (this.name.CompareTo(other.name) != 0)
            {
                return this.name.CompareTo(other.name);
            }

            if (this.age.CompareTo(other.age) != 0)
            {
                return this.age.CompareTo(other.age);
            }
            return this.town.CompareTo(other.town);
        }
    }
}
