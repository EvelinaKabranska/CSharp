using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_Count_Method_Doubles
{
   public class Box<T>
        where T:IComparable
    {
        public List<T> Values { get; set; }

        public Box()
        {
            this.Values = new List<T>();
        }
        public int isGreater(T currentNumber)
        {
            int counter = 0;
            
            foreach (var item in this.Values)
            {
                if (item.CompareTo(currentNumber) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
