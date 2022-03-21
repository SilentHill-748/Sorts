using System;
using System.Collections.Generic;
 
namespace Sorts.Algorithms
{
    public class ShellSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public ShellSort(List<T> list) : base(list) { }


        public override void Sort()
        {
            int step = _list.Count / 2;

            while (step > 0)
            {
                for (int i = step; i < _list.Count; i++)
                {
                    int j = i;

                    while ((j >= step) && _list[j - step].CompareTo(_list[j]) == 1)
                    {
                        Swap(j - step, j);
                        j -= step;
                    }
                }
                step /= 2;
            }

            SortedCollection = _list;
        }
    }
}
