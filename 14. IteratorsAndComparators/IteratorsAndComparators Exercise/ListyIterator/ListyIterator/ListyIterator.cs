using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> 
    {
        public List<T> elements;

        int curentIndex;

        public ListyIterator(params T[] elements)
        {
            this.elements = new List<T>(elements);
        }

        public bool Move()
        {
            if(curentIndex < elements.Count-1)
            {
                curentIndex++;
                return true;
            }
            return false;
        }
        public bool HasNext() => curentIndex + 1 < elements.Count;
        public void Print()
        {
            if(elements.Count==0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(elements[curentIndex]);

        }


    }
 }

