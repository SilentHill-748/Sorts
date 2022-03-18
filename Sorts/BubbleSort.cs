using System;

namespace Sorts
{
    public class BubbleSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public BubbleSort(T[] array) : base(array) { }
    }
}
