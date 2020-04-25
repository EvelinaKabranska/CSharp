namespace WildFarm.Animal
{
    using Food;

    public class Hen : Bird
    {
        
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
            
        }
        
        public override string ProduceSound()
        {
            return "Cluck";
        }
        protected override void ValidateFood(FoodCs food)
        { 
        }
        protected override double WeightPerFood => 0.35;


    }
}
