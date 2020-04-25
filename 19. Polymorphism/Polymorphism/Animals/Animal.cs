namespace Animals
{
   public class Animal
    {
        public string Name { get; set; }
        public string FavoriteFood { get; set; }

        public Animal (string name, string favoriteFood)
        {
            this.Name = name;
            this.FavoriteFood = favoriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavoriteFood}";
        }
    }
}
