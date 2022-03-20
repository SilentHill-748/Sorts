using System;
using System.Collections.Generic;

namespace Sorts
{
    public class GnomeSort<T> : SortBase<T>
        where T: IComparable<T>
    {
        public GnomeSort(T[] array) : base(array) { }


        public override void Sort()
        {
            // Base gnome sort algorithm.
            //int i = 0;

            //while (i < _array.Length - 1)
            //{
            //    if (_array[i].CompareTo(_array[i + 1]) == 1)
            //    {
            //        Swap(i, i + 1);

            //        if (i > 0) 
            //            i--;

            //        continue;
            //    }

            //    i++;
            //}

            // Optimized gnome sort algorithm.
            int i = 0;
            int lastSortedIndex = 0; // index of a element that was sorted.

            while (i < _array.Length - 1)
            {
                if (lastSortedIndex == i)
                    lastSortedIndex = i + 1;

                if (_array[i].CompareTo(_array[i + 1]) == 1)
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