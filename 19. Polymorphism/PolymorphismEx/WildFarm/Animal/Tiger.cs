namespace WildFarm.Animal
{
    using Food;
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }
        
        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
        protected override void ValidateFood(FoodCs food)
        {
            string type = food.GetType().Name;
            if (type != nameof(Meat))
            {
                Throw(food);
            }
        }
            protected override double WeightPerFood => 1.00;
    
    }
}
