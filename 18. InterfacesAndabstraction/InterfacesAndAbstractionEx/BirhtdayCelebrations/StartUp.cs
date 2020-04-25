namespace BirhtdayCelebrations
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
   public class StartUp
    {
      public  static void Main()
        {

            List<Each> flow = new List<Each>();
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "End")
            {
                var lineS = line.Split().ToArray();

                if (lineS[0] == "Citizen")
                {
                    Each each = new Each(lineS[0], lineS[4]);
                    flow.Add(each);
                }
                else if(lineS[0] == "Pet")
                {
                    Each each = new Each(lineS[0], lineS[2]);
                    flow.Add(each);
                }
            }

            string check = Console.ReadLine();

            foreach (var some in flow)
            {
                if (some.Date.EndsWith(check))
                {
                    Console.WriteLine(some.Date);
                }

            }
        }
    }
}
