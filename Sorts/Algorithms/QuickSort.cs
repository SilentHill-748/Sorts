using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts.Algorithms
{
    public class QuickSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public QuickSort(List<T> list) : base(list) { }


        public override void Sort()
        {
            SortedCollection = Sort(_list);
        }

        public List<T> Sort(List<T> list)
        {
            if (list.Count < 2)
                return list;

            Random rnd = new();
            int pivotIndex = rnd.Next(list.Count);

            List<T> left = new();
            List<T> right = new();

            for (int i = 0; i < list.Count; i++)
            {
                if (i == pivotIndex)
                    continue;

                if (list[i].CompareTo(list[pivotIndex]) <= 0)
                    left.Add(list[i]);
                else
                    right.Add(list[i]);
            }

            var sortedLeft = Sort(left);
            var sortedRight = Sort(right);

            sortedLeft.Add(list[pivotIndex]);
            sortedLeft.AddRange(sortedRight);

            return sortedLeft;
        }


        // Dosn't work in collections, which contains duplicates.

        //private void Sort(List<T> collection, int left, int right)
        //{
        //    if (left < right)
        //    {
        //        int partition = Partition(collection);
        //        Sort(collection, 0, partition);
        //        Sort(collection, partition + 1, right);
        //    }
        //}

        //private static int Partition(List<T> list)
        //{
        //    int left = 0;
        //    int right = list.Count - 1;
        //    int pivot = new Random().Next(right + 1);

        //    while (left < right)
        //    {
        //        while (list[left].CompareTo(list[pivot]) == -1)
        //            left++;

        //        while (list[right].CompareTo(list[pivot]) == 1)
        //            right--;

        //        (list[right], list[left]) = (list[left], list[right]);
        //    }

        //    return right;
        //}
    }
}
