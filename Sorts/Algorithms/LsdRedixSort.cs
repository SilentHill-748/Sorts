using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorts.Algorithms
{
    public class LsdRedixSort : SortBase<int>
    {
        public override void Sort(List<int> collection)
        {
            Collection = collection;

            List<List<int>> numberClasses = InitNumberClasses();

            int numOfDigs = (int)Math.Log10(collection.Max()) + 1;

            FillNumberClasses(numberClasses, numOfDigs);
        }

        private void FillNumberClasses(List<List<int>> numberClasses, int numOfDigs)
        {
            for (int i = 0; i < numOfDigs; i++)
            {
                for (int j = 0; j < Collection.Count; j++)
                {
                    int rank = Convert.ToInt32(
                        Math.Truncate(
                            Collection[j] % 
                            Math.Pow(10, i + 1) / 
                            Math.Pow(10, i)));

                    numberClasses[rank].Add(Collection[j]);
                }

                Collection = GetNewArray(numberClasses);
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
