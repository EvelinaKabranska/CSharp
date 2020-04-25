namespace Food
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
   public class StartUp
    {
      public  static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            List<Each> flow = new List<Each>();
            

            for (int i = 0; i < num; i++)
            {
                string[] lineS = Console.ReadLine().Split().ToArray(); 

                if (lineS.Length==4)
                {
                    Each each = new Each(lineS[0],10);
                    flow.Add(each);
                }
                else if(lineS.Length == 3)
                {
                    Each each = new Each(lineS[0],5);
                    flow.Add(each);
                }
            }

            string name = string.Empty;
            int sum = 0;

            while ((name = Console.ReadLine()) != "End")
            {
                foreach (var item in flow)
                {
                    if (name == item.Name)
                    {
                        sum += item.Food;
                    }
                }
                
            }
            Console.WriteLine(sum);
         
        }
    }
}
