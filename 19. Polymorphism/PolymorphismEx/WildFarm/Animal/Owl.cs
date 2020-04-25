namespace WildFarm.Animal
{
    using Food;
    public class Owl : Bird
    {
        
        public Owl(string name, double weight,  double wingSize) 
            : base(name, weight,  wingSize)
        {
        }
        protected override double WeightPerFood => 0.25;
        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
        protected override void ValidateFood(FoodCs food)
        {
            string type = food.GetType().Name;
            if (type != nameof(Meat))
            {
                Throw(food);
            }
        }
    }
}
