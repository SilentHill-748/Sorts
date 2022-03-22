using System;
using System.Collections.Generic;
 
namespace Sorts.Algorithms
{
    public class ShellSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public override void Sort(List<T> collection)
        {
            Collection = collection;
            int step = collection.Count / 2;

            while (step > 0)
            {
                for (int i = step; i < collection.Count; i++)
                {
                    int j = i;

                    while ((j >= step) && collection[j - step].CompareTo(collection[j]) == 1)
                    {
                        Swap(j - step, j);
                        j -= step;
                    }
                }
                step /= 2;
            }
        }
    }
}
