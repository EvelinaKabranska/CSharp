namespace Telephony
{
    using System;
    using System.Linq;
   public  class StartUp
    {
       public  static void Main()
        {
            string[] numbers = Console.ReadLine().Split().ToArray();
            string[] urls = Console.ReadLine().Split().ToArray();

            var smart = new Smartphone(numbers,urls);
            Console.WriteLine(smart);

        }
    }
}