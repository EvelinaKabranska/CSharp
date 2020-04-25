using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class Lake : IEnumerable<int>
    {
        private int[] stones;
        public Lake(int[] Stones)
        {
            this.stones = Stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stones.Length; i += 2)
            {
                yield return stones[i];
            }
            int backwardsStartIndex = stones.Length % 2 == 0 ? stones.Length - 1 : stones.Length - 2;

            for (int i = backwardsStartIndex; i > 0; i -= 2)
            {
                yield return stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
