using System;
using System.Collections.Generic;

namespace Sorts.Algorithms
{
    public class InsertionSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public InsertionSort(List<T> list) : base(list) { }


        public override void Sort()
        {
            for (int i = 1; i < _list.Count; i++)
            {
                T item = _list[i]; // save current item
                int j = i;

                // while count of left items more than 1
                // and [item] not less than previos items in left collection.
                while (j > 0 && _list[j - 1].CompareTo(item) == 1)
                {
                    Swap(j - 1, j);
                    j--;
                }
            }

            SortedCollection = _list;
        }
    }
}
