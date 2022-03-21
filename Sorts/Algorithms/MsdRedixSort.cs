using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorts.Algorithms
{
    public class MsdRedixSort : SortBase<int>
    {
        private List<List<int>>? _numberClasses;


        public MsdRedixSort(List<int> list) : base(list) { }


        public override void Sort()
        {
            int numOfDigs = (int)Math.Log10(_list.Max()) + 1;

            SortedCollection = SortCollection(_list, numOfDigs - 1);

        }

        private List<int> SortCollection(List<int> list, int step)
        {
            _numberClasses = InitNumberClassesCollections();

            FillNumberClasses(list, step);

            list.Clear();

            foreach (List<int> group in _numberClasses)
            {
                if (group.Count > 1 && step > 0)
                {
                    list.AddRange(SortCollection(group, step - 1));
                }
                else
                    list.AddRange(group);
            }

            return list;
        }

        private static List<List<int>> InitNumberClassesCollections()
        {
            List<List<int>> numberClasses = new();

            for (int i = 0; i < 10; i++)
                numberClasses.Add(new List<int>());

            return numberClasses;
        }

        private void FillNumberClasses(List<int> list, int step)
        {
            for (int j = 0; j < list.Count; j++)
            {
                int rank = Convert.ToInt32(
                    Math.Truncate(list[j]  %
                    Math.Pow(10, step + 1) /
                    Math.Pow(10, step)));

                _numberClasses[rank].Add(list[j]);
            }
        }
    }
}
