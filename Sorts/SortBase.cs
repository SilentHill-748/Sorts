using System;

namespace Sorts
{
    public class SortBase<T>
        where T : IComparable<T>
    {
        private protected T[] _array;


        protected SortBase(T[] array)
        {
            _array = array;
        }


        protected void Swap(int firstIndex, int secondIndex)
        {
            T temp = _array[firstIndex];
            _array[firstIndex] = _array[secondIndex];
            _array[secondIndex] = temp;
        }
    }
}
