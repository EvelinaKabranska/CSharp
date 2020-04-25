using System;

namespace Generic_Count_Method_Doubles
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            for (int i = 0; i < count; i++)
            {
                double num = double.Parse(Console.ReadLine());
                box.Values.Add(num);
            }
            double currentNumber = double.Parse(Console.ReadLine());
            int result = box.isGreater(currentNumber);
            Console.WriteLine(result);
        }
    }
}
