namespace WildFarm.Animal
{
    
   public abstract class Mammal:AnimalCs
    {

        public Mammal(string name, double weight, string livingRegion) 
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; set; }

        
    }
}
