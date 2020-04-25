namespace WildFarm.Food
{
   public abstract class FoodCs
    {
        public FoodCs(int quantity)
        {
            this.Quantity = quantity;
        }
        public int Quantity { get; private set; }
    }
}
