using System;
using System.Collections.Generic;

namespace Sorts.Benchmarks.Helpers
{
    public static class CollectionHelper
    {
        public static List<int> GetCollection(int size)
        {
            Random rnd = new();
            List<int> result = new();

            for (int i = 0; i <  size; i++)
            {
                result.Add(rnd.Next(0, int.MaxValue));
            }

            return result;
        }
    }
}
