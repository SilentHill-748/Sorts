using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorts.Algorithms
{
    public class MergeSort<T> : SortBase<T>
        where T: IComparable<T>
    {
        public MergeSort(List<T> list) : base(list) { }


        public override void Sort()
        {
            SortedCollection = Sort(_list);
        }

        private List<T> Sort(List<T> collection)
        {
            if (collection.Count == 1)
                return collection;

            int mid = collection.Count / 2;

            var left = collection.Take(mid).ToList();
            var right = collection.Skip(mid).ToList();

            return Merge(Sort(left), Sort(right));
        }

        private static List<T> Merge(List<T> left, List<T> right)
        {
            var result = new List<T>();
            int leftPointer = 0;
            int rightPointer = 0;
            int length = left.Count + right.Count;

            for (int i = 0; i < length; i++)
            {
                if (leftPointer < left.Count && rightPointer < right.Count)
                {
                    if (left[leftPointer].CompareTo(right[rightPointer]) == -1)
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                    else
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                }
                else
                {
                    if (rightPointer < right.Count)
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                    else
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                }
            }

            return result;
        }
    }
}
