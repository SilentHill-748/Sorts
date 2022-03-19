using System;
using System.Linq;

using DataStructures;

namespace Sorts
{
    public class HeapSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public HeapSort(T[] array) : base(array) { }


        public override void Sort()
        {
            BinaryHeap<T> heap = new(_array);
            _array = heap.Order().ToArray();
        }
    }
}
