using System;
using System.Collections.Generic;

namespace Sorts.Algorithms
{
    public class BubbleSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public BubbleSort(List<T> list) : base(list) { }
    }
}
