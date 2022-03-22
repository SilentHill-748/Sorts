using System;
using System.Collections.Generic;

namespace Sorts.Algorithms
{
    public class QuickSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public override void Sort(List<T> collection)
        {
            Collection = collection;
            Sort(0, collection.Count - 1);
        }

        private void Sort(int left, int right)
        {
            if (left >= right) return;

            int pivot = Partition(left, right);
            Sort(left, pivot);
            Sort(pivot + 1, right);
        }

        private int Partition(int left, int right)
        {
            Random rnd = new();
            T pivotVal = Collection[rnd.Next(left, right + 1)];

            while (left < right)
            {
                while (Collection[left].CompareTo(pivotVal) == -1)
                    left++;

                while (Collection[right].CompareTo(pivotVal) == 1)
                    right--;

                if (left < right)
                    Swap(left, right);

                // Ignore duplicates
                if (Collection[left].CompareTo(Collection[right]) == 0)
                    right--;
            }

            return left;
        }
    }
}
