using System;
using System.Collections.Generic;
using System.Linq;

using DataStructures;

namespace Sorts.Algorithms
{
    public class HeapSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public override void Sort(List<T> collection)
        {
            Collection = new BinaryHeap<T>(collection).Order().ToList();
        }
    }
}
