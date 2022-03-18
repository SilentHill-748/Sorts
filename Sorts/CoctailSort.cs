using System;

namespace Sorts
{
    public class CoctailSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public CoctailSort(T[] array) : base(array) { }


        public override void Sort()
        {
            int left = 0, right = _array.Length - 1;

            while (left < right)
            {
                MoveRight(left, right--);
                MoveLeft(right, left++);
            }
        }

        private int MoveLeft(int start, int end)
        {
            int swaps = 0;

            for (int i = start; i > end; i--)
            {
                if (_array[i].CompareTo(_array[i - 1]) == -1)
                {
                    swaps++;
                    Swap(i, i - 1);
                }
            }

            return swaps;
        }

        private int MoveRight(int start, int end)
        {
            int swaps = 0;

            for (int i = start; i < end; i++)
            {
                if (_array[i].CompareTo(_array[i + 1]) == 1)
                {
                    swaps++;
                    Swap(i, i + 1);
                }
            }

            return swaps;
        }
    }
}
