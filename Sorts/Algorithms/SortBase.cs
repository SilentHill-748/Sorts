using System;
using System.Collections.Generic;

namespace Sorts.Algorithms
{
    public abstract class SortBase<T>
        where T : IComparable<T>
    {
        private protected List<T> _list;


        protected SortBase(List<T> list)
        {
            _list = list;
        }


        public List<T> SortedCollection { get; protected set; }


        public virtual void Sort()
        {
            // Bubble sort as default.
            for (int i = 0; i < _list.Count; i++)
                for (int j = 0; j < _list.Count - 1; j++)
                {
                    if (_list[j].CompareTo(_list[j + 1]) == 1)
                        Swap(j, j + 1);
                }

            SortedCollection = _list;
        }

        protected void Swap(int firstIndex, int secondIndex)
        {
            (_list[secondIndex], _list[firstIndex]) = (_list[firstIndex], _list[secondIndex]);
        }
    }
}
