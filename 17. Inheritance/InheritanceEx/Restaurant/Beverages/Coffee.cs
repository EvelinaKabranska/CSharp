namespace Restaurant
{
    
    public class Coffee : HotBeverage
    {
        private const double coffeeMililiters = 50;
        private const decimal coffeePrice = 3.50M;
       

        public Coffee(string name,double caffeine)
            : base(name, 0, 0)
        {
            this.Caffeine = caffeine;
        }

        public override double Mililiters => coffeeMililiters;
        public override decimal Price => coffeePrice;
        public double Caffeine { get; set; }
    }
}
