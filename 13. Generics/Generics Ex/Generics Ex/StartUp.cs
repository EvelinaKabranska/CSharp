using System;

namespace Box
{
    public class StartUp
    {
      public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string command = Console.ReadLine();
                Box<string> box = new Box<string>(command);
                Console.WriteLine(box);
            }
        }
    }
}
