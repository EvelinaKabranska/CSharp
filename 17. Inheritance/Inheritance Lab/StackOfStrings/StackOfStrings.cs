namespace CustomStack
{
    using System.Collections.Generic;
    using System.Linq;

    public class StackOfStrings:Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public void PushRange(IEnumerable<string> data)
        {
            foreach (var item in data)

            {
                this.Push(item);
            }
        }

    }
}