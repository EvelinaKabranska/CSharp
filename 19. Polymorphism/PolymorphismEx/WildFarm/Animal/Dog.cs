namespace WildFarm.Animal
{
    using Food;
    public class Dog : Mammal
    {
        
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }
        public override string ProduceSound()
        {
            return "Woof!";
        }
        protected override void ValidateFood(FoodCs food)
        {
            string type = food.GetType().Name;
            if (type != nameof(Meat))
            {
                Throw(food);
            }
        }
        protected override double WeightPerFood => 0.40;
        public override string ToString()
        {
            return base.ToString() + $"{Weight + FootEaten * WeightPerFood}, {LivingRegion}, {FootEaten}]";

        }
    }
}
