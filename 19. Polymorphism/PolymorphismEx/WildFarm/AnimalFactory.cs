namespace WildFarm.Animal
{
    using System;

    public static class AnimalFactory
    {
        public static  AnimalCs  Create(string[] args)
        {
            string type = args[0];

            switch(type)
            {
                case "Owl":
                    return new Owl(args[1], double.Parse(args[2]), double.Parse(args[3]));
                case "Hen":
                    return new Hen(args[1], double.Parse(args[2]), double.Parse(args[3]));
                case "Mouse":
                    return new Mouse(args[1], double.Parse(args[2]), args[3]);
                case "Dog":
                    return new Dog(args[1], double.Parse(args[2]), args[3]);
                case "Cat":
                    return new Cat(args[1], double.Parse(args[2]), args[3], args[4]);
                case "Tiger":
                    return new Tiger(args[1], double.Parse(args[2]), args[3], args[4]);

                default:
                    throw new ArgumentException($"{type} is not a valid Animal type.");
            }
        }
    }
}
