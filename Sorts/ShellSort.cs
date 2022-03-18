using System;

namespace Sorts
{
    public class ShellSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public ShellSort(T[] array) : base(array) { }


        public override void Sort()
        {
            int step = _array.Length / 2;

            while (step > 0)
            {
                for (int i = step; i < _array.Length; i++)
                {
                    int j = i;

                    while ((j >= step) && _array[j - step].CompareTo(_array[j]) == 1)
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
