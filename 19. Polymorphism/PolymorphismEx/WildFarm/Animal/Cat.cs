namespace WildFarm.Animal
{
    using Food;
    public class Cat : Feline
    {
        
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
         protected override void ValidateFood(FoodCs food)
        {
            string type = food.GetType().Name;
            if(type!=nameof(Vegetable)&& type != nameof(Meat))
            {
                Throw (food);
            }
        }
        protected override double WeightPerFood => 0.30;
    }
}
