namespace Restaurant
{
   public class Cake:Dessert
    {
        private const double grams = 250;
        private const double calories = 1000;
        private const decimal cakePrice =5;

        public Cake(string name)
          : base(name,0,0,0)
        {
            this.Name = name;
        }

        public override double Grams => grams;
        public override double Calories => calories;
        public override decimal Price => cakePrice;
    }
}
