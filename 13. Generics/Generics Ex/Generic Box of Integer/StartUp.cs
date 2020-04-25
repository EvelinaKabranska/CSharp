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
                int num = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(num);
                Console.WriteLine(box);
            }
        }
    }
}
