using System;
namespace EncapsExe
{
    public class ClassBox
    {
        public static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Box box = null;
            
            try
            {
               box = new Box(length, width, height);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine($"Surface Area - { box.GetSerfaceArea():f2}");
            Console.WriteLine($"Lateral Surface Area - { box.GetLateralSerfaceArea():f2}");
            Console.WriteLine($"Volume - { box.GetVoliume():f2}");
        }
    }
}
