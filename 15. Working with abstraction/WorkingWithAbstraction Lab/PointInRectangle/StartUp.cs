namespace PointInRectangle
{
    using System;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            var rectangleBorders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point topleft = new Point(rectangleBorders[0], rectangleBorders[1]);
            Point bottomRight = new Point(rectangleBorders[2], rectangleBorders[3]);
            Rectangle rectangle = new Rectangle(topleft, bottomRight);

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                var pointer = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var point = new Point(pointer[0], pointer[1]);
               if(rectangle.Contains(point))
                {
                    Console.WriteLine("True");
                }
               else
                {
                    Console.WriteLine("False");
                }
            }
        }
    }
}
