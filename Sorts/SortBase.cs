using System;

namespace Sorts
{
    public abstract class SortBase<T>
        where T : IComparable<T>
    {
        private protected T[] _array;


        protected SortBase(T[] array)
        {
            _array = array;
        }


        public virtual void Sort()
        {
            // Bubble sort as default.
            for (int i = 0; i < _array.Length; i++)
                for (int j = 0; j < _array.Length - 1; j++)
                {
                    if (_array[j].CompareTo(_array[j + 1]) == 1)
                        Swap(j, j + 1);
                }
        }

        protected void Swap(int firstIndex, int secondIndex)
        {
            (_array[secondIndex], _array[firstIndex]) = (_array[firstIndex], _array[secondIndex]);
        }
    }
}
