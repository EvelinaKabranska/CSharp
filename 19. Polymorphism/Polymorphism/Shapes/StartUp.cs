namespace Shapes
{
    using System;
   public class StartUp
    {
       public static void Main()
        {
            var circle = new Circle(6);
            var rectangle = new Rectangle(4, 5);

            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());

            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());

            circle.Draw();
            rectangle.Draw();
        }
    }
}
