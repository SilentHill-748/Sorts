using System;

namespace Sorts
{
    public class InsertionSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public InsertionSort(T[] array) : base(array) { }


        public override void Sort()
        {
            for (int i = 1; i < _array.Length; i++)
            {
                T item = _array[i]; // save current item
                int j = i;

                // while count of left items more than 1
                // and [item] not less than previos items in left collection.
                while (j > 0 && _array[j - 1].CompareTo(item) == 1)
                {
                    Swap(j - 1, j);
                    j--;
                }
            }
        }
    }
}
