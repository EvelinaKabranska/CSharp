namespace BorderControl
{
    using System.Linq;
    using System;
    class Each : IFormat
    {
        private string name;
        private string model;
        private int age;
        private string id;

        public Each(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;

        }
        public Each(string model,string id)
        {
            this.model = model;
            this.Id = id;
        }


        public string Model { get; }

        public string Name { get; }

        public int Age { get; }

        public string Id  { get; }

        
    }
}
