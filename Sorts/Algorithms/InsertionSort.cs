using System;
using System.Collections.Generic;

namespace Sorts.Algorithms
{
    public class InsertionSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public override void Sort(List<T> collection)
        {
            Collection = collection;

            for (int i = 1; i < collection.Count; i++)
            {
                T item = collection[i]; // save current item
                int j = i;

                // while count of left items more than 1
                // and [item] not less than previos items in left collection.
                while (j > 0 && collection[j - 1].CompareTo(item) == 1)
                {
                    Swap(j - 1, j);
                    j--;
                }
            }
        }
    }
}
