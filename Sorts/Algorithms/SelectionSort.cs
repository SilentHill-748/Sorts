using System;
using System.Collections.Generic;

namespace Sorts.Algorithms
{
    public class SelectionSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public override void Sort(List<T> collection)
        {
            Collection = collection;
            int minItemIndex;

            for (int i = 0; i < collection.Count - 1; i++)
            {
                minItemIndex = i;

                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(collection[minItemIndex]) == -1)
                        minItemIndex = j;
                }

                if (i != minItemIndex) 
                    Swap(i, minItemIndex);
            }
        }
    }
}
