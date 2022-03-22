using System;
using System.Collections.Generic;

namespace Sorts.Algorithms
{
    public abstract class SortBase<T>
        where T : IComparable<T>
    {
        public List<T> Collection { get; protected set; }


        // Bubble sort as default.
        public virtual void Sort(List<T> collection)
        {
            Collection = collection;

            for (int i = 0; i < Collection.Count; i++)
                for (int j = 0; j < Collection.Count - 1; j++)
                {
                    if (Collection[j].CompareTo(Collection[j + 1]) == 1)
                        Swap(j, j + 1);
                }
        }

        protected void Swap(int firstIndex, int secondIndex)
        {
            (Collection[secondIndex], Collection[firstIndex]) = 
                (Collection[firstIndex], Collection[secondIndex]);
        }
    }
}
