using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorts
{
    public class LsdRedixSort : SortBase<int>
    {
        public LsdRedixSort(List<int> list) : base(list) { }


        public override void Sort()
        {
            List<List<int>> numberClasses = InitNumberClasses();

            int numOfDigs = (int)Math.Log10(_list.Max()) + 1;

            FillNumberClasses(numberClasses, numOfDigs);

            SortedCollection = _list;
        }

        private void FillNumberClasses(List<List<int>> numberClasses, int numOfDigs)
        {
            for (int i = 0; i < numOfDigs; i++)
            {
                for (int j = 0; j < _list.Count; j++)
                {
                    int rank = Convert.ToInt32(
                        Math.Truncate(
                            _list[j] % 
                            Math.Pow(10, i + 1) / 
                            Math.Pow(10, i)));

                    numberClasses[rank].Add(_list[j]);
                }

                _list = GetNewArray(numberClasses);
            }
        }

        private static List<List<int>> InitNumberClasses()
        {
            var numberClasses = new List<List<int>>();

            for (int i = 0; i < 10; i++)
                numberClasses.Add(new List<int>());

            return numberClasses;
        }

        private static List<int> GetNewArray(List<List<int>> numberClasses)
        {
            List<int> result = new();

            foreach (List<int> group in numberClasses)
            {
                result.AddRange(group);
                group.Clear();
            }

            return result;
        }
    }
}
