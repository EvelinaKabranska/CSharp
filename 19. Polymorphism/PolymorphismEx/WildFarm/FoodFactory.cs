namespace WildFarm.Food
{
    using System;
    public static class FoodFactory
    {
        public static FoodCs Create(string[] agrs)
        {
            string type = agrs[0];

            switch (type)
            {
                case "Vegetable":
                    return new Vegetable(int.Parse(agrs[1]));
                case "Fruit":
                    return new Fruit(int.Parse(agrs[1]));
                case "Meat":
                    return new Meat(int.Parse(agrs[1]));
                case "Seeds":
                    return new Seeds(int.Parse(agrs[1]));
                default:
                    throw new ArgumentException($"{type} is not a valid Food type.");
            }
        }
    }
}
