namespace InheritanceEx
{ 
    using System;
    using System.Text;

    public class Person
    {
        private string name;
        private int age;

        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
            
        }
        public string Name { get; set; }
        public virtual int Age {
            get => this.age;
            protected set
            {
                if(value<0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Name: {this.Name}, Age: {this.age}");
            return stringBuilder.ToString();
        }

    }
}
