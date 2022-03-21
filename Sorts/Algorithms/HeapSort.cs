using System;
using System.Collections.Generic;
using System.Linq;

using DataStructures;

namespace Sorts.Algorithms
{
    public class HeapSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public HeapSort(List<T> list) : base(list) { }


        public override void Sort()
        {
            SortedCollection = new BinaryHeap<T>(_list).Order().ToList();
        }
    }
}
