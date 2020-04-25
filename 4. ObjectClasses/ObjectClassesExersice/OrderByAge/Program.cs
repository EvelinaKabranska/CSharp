using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Linq;
namespace OrderByAge
{
    class Program
    {
        public class Info
        {
            public string Name { get; set; }
            public Int64 ID { get; set; }
            public int Age { get; set; }

            public Info(string name,Int64 id,int age)
            {
                Name = name;
                ID = id;
                Age = age;
            }
            public override string ToString()
            {
                return $"{Name} with ID: {ID} is {Age} years old.";
            }
        };
         
        static void Main(string[] args)
        {
            var fin = new List<Info>();

            string comand = string.Empty;
            while ((comand=Console.ReadLine())!="End")
            {
                string[] comSp = comand.Split(" ").ToArray();
                var input = new Info(comSp[0], int.Parse(comSp[1]),int.Parse(comSp[2]));
                fin.Add(input);
            }
            fin = fin.OrderBy(x => x.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, fin));
        }
    }
}
