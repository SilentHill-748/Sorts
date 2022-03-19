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

        private void MoveLeft(int start, int end)
        {
            for (int i = start; i > end; i--)
            {
                if (_array[i].CompareTo(_array[i - 1]) == -1)
                {
                    Swap(i, i - 1);
                }
            }
        }

        private void MoveRight(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                if (_array[i].CompareTo(_array[i + 1]) == 1)
                {
                    Swap(i, i + 1);
                }
            }
        }
    }
}
