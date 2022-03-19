using System;

namespace Sorts
{
    public class SelectionSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public SelectionSort(T[] array) : base(array) { }


        public override void Sort()
        {
            int minItemIndex;

            for (int i = 0; i < _array.Length - 1; i++)
            {
                minItemIndex = i;

                for (int j = i + 1; j < _array.Length; j++)
                {
                    if (_array[j].CompareTo(_array[minItemIndex]) == -1)
                        minItemIndex = j;
                }

                if (i != minItemIndex) 
                    Swap(i, minItemIndex);
            }
        }
    }
}
