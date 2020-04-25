namespace WildFarm.Animal
{
    using Food;
    using System;

    public abstract class AnimalCs
    {
        public  AnimalCs(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
          
        }

        protected abstract double WeightPerFood { get; }
        public string Name { get; private set;}
        public double Weight { get; private set; }
        public int FootEaten { get; private set; }
        public abstract string ProduceSound();

        public virtual void EatFood(FoodCs food)
        {
            ValidateFood(food);
            this.FootEaten += food.Quantity;
        }
        protected abstract void ValidateFood(FoodCs food);
        protected void Throw(FoodCs food)
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
