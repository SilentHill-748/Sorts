using System;
using System.Collections.Generic;

namespace Sorts.Algorithms
{
    public class GnomeSort<T> : SortBase<T>
        where T: IComparable<T>
    {
        public override void Sort(List<T> collection)
        {
            // Optimized gnome sort algorithm.
            Collection = collection;

            int i = 0;
            int lastSortedIndex = 0; // index of a element that was sorted.

            while (i < collection.Count - 1)
            {
                if (lastSortedIndex == i)
                    lastSortedIndex = i + 1;

                if (collection[i].CompareTo(collection[i + 1]) == 1)
                {
                    Swap(i, i + 1);

                    if (i > 0) i--;
                    continue;
                }

                i = lastSortedIndex;
            }
        }
    }
}