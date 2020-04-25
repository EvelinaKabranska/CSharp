namespace WildFarm.Animal
{
    using Food;
    public abstract class Bird:AnimalCs
    {
        public Bird(string name, double weight, double wingSize)
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }
           
        public double WingSize{get;set;}

        public override string ToString()
        {
            return base.ToString() + $"{WingSize}, {Weight + FootEaten * WeightPerFood}, {FootEaten}]";
        }
    }
}
