using System;
using System.Collections.Generic;

namespace Sorts.Algorithms
{
    public class CoctailSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public override void Sort(List<T> collection)
        {
            Collection = collection;
            int left = 0, right = collection.Count - 1;

            while (left < right)
            {
                MoveRight(left, right--);
                MoveLeft(right, left++);
            }
        }

        private void MoveLeft(int start, int end)
        {
            for (int i = start; i > end; i--)
            {
                if (Collection[i].CompareTo(Collection[i - 1]) == -1)
                {
                    Swap(i, i - 1);
                }
            }
        }

        private void MoveRight(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                if (Collection[i].CompareTo(Collection[i + 1]) == 1)
                {
                    Swap(i, i + 1);
                }
            }
        }
    }
}
