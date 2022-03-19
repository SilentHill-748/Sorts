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

            // This code slower, but I'm test quality of completion.
            var result = heap.Order().ToArray();

            for (int i = 0, j = result.Length - 1; i < result.Length; i++, j--)
                _array[i] = result[j];
        }
    }
}
