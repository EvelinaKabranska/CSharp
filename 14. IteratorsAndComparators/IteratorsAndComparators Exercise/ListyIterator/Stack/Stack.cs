using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class Stack<T> : IEnumerable<T>
    {
        public List<T> numbers;
        public int currentIndex = -1;

        public Stack()
        {
            this.numbers = new List<T>();
        }

        public void Push(params T[] items)
        {
            foreach (var item in items)
            {
                numbers.Insert(++currentIndex, item);
            }
        }
        public void Pop()
        {
            if(currentIndex<0)
            {
                throw new InvalidOperationException("No elements");
            }
            currentIndex--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = currentIndex; i >=0; i--)
            {
                yield return numbers[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
       
    }
}
