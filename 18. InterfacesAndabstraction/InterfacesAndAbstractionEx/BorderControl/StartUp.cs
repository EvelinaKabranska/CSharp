namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public  class StartUp
    {
      public  static void Main()
        {

            string line = string.Empty;
            string namep = "";
            int agep = 0;
            string idp = "";
            string model = "";
            string idr = "";

            List<Each> flow = new List<Each>(); 
            while ((line = Console.ReadLine())!= "End")
            {
               var lineS = line.Split().ToArray();
               
                if (lineS.Length>2)
                {
                     namep = lineS[0];
                    agep = int.Parse(lineS[1]);
                    idp = lineS[2];

                    flow.Add(new Each(namep,agep,idp));
                    
                }
                else
                {
                     model = lineS[0];
                     idr = lineS[1];

                    flow.Add(new Each(model, idr));
                }
                
            }

            string check = Console.ReadLine();

            foreach (var some in flow)
            {
                if (some.Id.EndsWith(check))
                {
                    Console.WriteLine(some.Id);
                }

            }
           
        }
    }
}
