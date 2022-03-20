using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorts
{
    public class LsdRedixSort : SortBase<int>
    {
        private readonly List<Queue<int>> _numberClasses;
        private int[] _localArray;

        public LsdRedixSort(int[] array) : base(array)
        {
            _numberClasses = new List<Queue<int>>();

            for (int i = 0; i < 10; i++)
                _numberClasses.Add(new Queue<int>());

            _localArray = array;
        }


        public override void Sort()
        {
            int numOfDigs = (int)Math.Log10(_localArray.Max()) + 1;

            for (int i = 0; i < numOfDigs; i++)
            {
                for (int j = 0; j < _localArray.Length; j++)
                {
                    int rank = _localArray[j] % (int)Math.Pow(10, i + 1) / (int)Math.Pow(10, i);
                    
                    _numberClasses[rank].Enqueue(_localArray[j]);
                }

                _localArray = GetNewArray();
            }

            Array.Copy(_localArray, 0, _array, 0, _localArray.Length);
        }

        private int[] GetNewArray()
        {
            List<int> result = new();

            foreach (Queue<int> group in _numberClasses)
            {
                while (group.Count > 0)
                    result.Add(group.Dequeue());
            }

            return result.ToArray();
        }
    }
}
