using System;
using System.Collections.Generic;

namespace Sorts.Algorithms
{
    public class SelectionSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public SelectionSort(List<T> list) : base(list) { }


        public override void Sort()
        {
            int minItemIndex;

            for (int i = 0; i < _list.Count - 1; i++)
            {
                minItemIndex = i;

                for (int j = i + 1; j < _list.Count; j++)
                {
                    if (_list[j].CompareTo(_list[minItemIndex]) == -1)
                        minItemIndex = j;
                }

                if (i != minItemIndex) 
                    Swap(i, minItemIndex);
            }

            SortedCollection = _list;
        }
    }
}
