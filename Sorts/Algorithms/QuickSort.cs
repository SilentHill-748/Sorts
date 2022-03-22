using System;
using System.Collections.Generic;

namespace Sorts.Algorithms
{
    public class QuickSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public QuickSort(List<T> list) : base(list) { }


        public override void Sort()
        {
            Sort(0, _list.Count - 1);
            SortedCollection = _list;
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
            T pivotVal = _list[rnd.Next(left, right + 1)];

            while (left < right)
            {
                while (_list[left].CompareTo(pivotVal) == -1)
                    left++;

                while (_list[right].CompareTo(pivotVal) == 1)
                    right--;

                if (left < right)
                    (_list[right], _list[left]) = (_list[left], _list[right]);

                // Ignore duplicates
                if (_list[left].CompareTo(_list[right]) == 0)
                    right--;
            }

            return left;
        }
    }
}
