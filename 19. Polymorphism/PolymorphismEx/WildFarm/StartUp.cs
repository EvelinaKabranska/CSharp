namespace WildFarm
{
    using System;
    using System.Collections.Generic;
    using Animal;
    using Food;
    public class StartUp
    {
        public static void Main()
        {
            List<AnimalCs> animals = new List<AnimalCs>();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {

                AnimalCs animal = AnimalFactory.Create(command.Split(" ", StringSplitOptions.RemoveEmptyEntries));
                animals.Add(animal);
                Console.WriteLine(animal.ProduceSound());

                FoodCs food = FoodFactory.Create(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

                try
                {
                    animal.EatFood(food);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            animals.ForEach(Console.WriteLine);
        }
        
    }
}
