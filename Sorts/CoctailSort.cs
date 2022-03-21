using System;
using System.Collections.Generic;

namespace Sorts
{
    public class CoctailSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public CoctailSort(List<T> list) : base(list) { }


        public override void Sort()
        {
            int left = 0, right = _list.Count - 1;

            while (left < right)
            {
                MoveRight(left, right--);
                MoveLeft(right, left++);
            }

            SortedCollection = _list;
        }

        private void MoveLeft(int start, int end)
        {
            for (int i = start; i > end; i--)
            {
                if (_list[i].CompareTo(_list[i - 1]) == -1)
                {
                    Swap(i, i - 1);
                }
            }
        }

        private void MoveRight(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                if (_list[i].CompareTo(_list[i + 1]) == 1)
                {
                    Swap(i, i + 1);
                }
            }
        }
    }
}
