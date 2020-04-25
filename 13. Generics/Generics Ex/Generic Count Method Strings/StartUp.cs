using System;

namespace Generic_Count_Method_Strings
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            int count=int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < count; i++)
            {
                string line = Console.ReadLine();
                box.Values.Add(line); 
            }
            string currentItem = Console.ReadLine();
           int result= box.IsGreater(currentItem);
            Console.WriteLine(result);
        }
    }
}
