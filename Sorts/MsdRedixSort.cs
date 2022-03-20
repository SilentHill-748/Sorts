using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    public class MsdRedixSort : SortBase<int>
    {
        private List<int> _localList;


        public MsdRedixSort(int[] array) : base(array)
        {
            _localList = new List<int>();
            _localList.AddRange(array);
        }


        public override void Sort()
        {
            int numOfDigs = (int)Math.Log10(_localList.Max()) + 1;

            _localList = SortCollection(_localList, numOfDigs - 1);

            for (int i = 0; i < _localList.Count; i++)
                _array[i] = _localList[i];
        }

        private List<int> SortCollection(List<int> list, int step)
        {
            List<Queue<int>> numberClasses = InitNumberClassesCollections();

            FillNumberClasses(list, step, numberClasses);

            list.Clear();

            foreach (Queue<int> group in numberClasses)
            {
                if (group.Count > 1 && step > 0)
                {
                    list.AddRange(SortCollection(group.ToList(), step - 1));
                }
                else
                    list.AddRange(group);
            }

            return list;
        }

        private static List<Queue<int>> InitNumberClassesCollections()
        {
            List<Queue<int>> numberClasses = new();

            for (int i = 0; i < 10; i++)
                numberClasses.Add(new Queue<int>());

            return numberClasses;
        }

        private static void FillNumberClasses(List<int> list, int step, List<Queue<int>> numberClasses)
        {
            for (int j = 0; j < list.Count; j++)
            {
                int rank = Convert.ToInt32(
                    Math.Truncate(list[j]  %
                    Math.Pow(10, step + 1) /
                    Math.Pow(10, step)));

                numberClasses[rank].Enqueue(list[j]);
            }
        }
    }
}
