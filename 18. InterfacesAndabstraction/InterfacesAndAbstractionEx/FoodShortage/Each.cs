namespace Food
{
    using System.Linq;
    using System;
   public class Each : IFormat
    {
        private string name;
        private int food;

        public Each(string name,int food)
        {
            this.Name = name;
            this.Food = food;
          
        }
        
        public string Name { get; }
        public int Food { get; }
    }
}
