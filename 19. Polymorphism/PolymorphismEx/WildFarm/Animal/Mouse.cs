namespace WildFarm.Animal
{
    using Food;

    public class Mouse : Mammal
    {
       
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
        
        protected override void ValidateFood(FoodCs food)
        {
            string type = food.GetType().Name;
            if(type!=nameof(Vegetable)&& type != nameof(Fruit))
            {
                Throw (food);
            }
        }
        protected override double WeightPerFood => 0.10;
        public override string ToString()
        {
            return base.ToString() + $"{Weight + FootEaten * WeightPerFood}, {LivingRegion}, {FootEaten}]";

        }
    }
}
