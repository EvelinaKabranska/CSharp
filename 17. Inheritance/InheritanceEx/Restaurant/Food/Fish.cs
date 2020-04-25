namespace Restaurant
{
   public class Fish: MainDish
    {
        private const double grams = 22;
        public Fish(string name, decimal price)
           : base(name, price, 0)
        {
            this.Grams = grams;
        }

        public override double Grams => grams;
    }
}
