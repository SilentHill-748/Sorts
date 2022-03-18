using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace Sorts.Tests
{
    internal class SortTests
    {
        private readonly int[] _source;
        private readonly SortedSet<int> _sortedSource;


        public SortTests()
        {
            _source = new int[10000];
            _sortedSource = new SortedSet<int>();
        }


        [SetUp]
        public void InitializeTestParameters()
        {
            FillRandom();
        }

        [Test]
        public void BubbleSortTest()
        {
            BubbleSort<int> bubbleSort = new(_source);

            bubbleSort.Sort();

            CollectionAssert.AreEquivalent(_sortedSource, _source);
        }

        [Test]
        public void CoctailSortTest()
        {
            CoctailSort<int> coctailSort = new(_source);

            coctailSort.Sort();

            CollectionAssert.AreEquivalent(_sortedSource, _source);
        }

        [Test]
        public void InsertionSortTest()
        {
            InsertionSort<int> insertionSort = new(_source);

            insertionSort.Sort();

            CollectionAssert.AreEquivalent(_sortedSource, _source);
        }

        [Test]
        public void ShellSortTest()
        {
            ShellSort<int> shellSort = new(_source);

            shellSort.Sort();

            CollectionAssert.AreEquivalent(_sortedSource, _source);
        }

        [Test]
        public void TreeSortTest()
        {

        }

        [Test]
        public void HeapSortTest()
        {

        }

        [Test]
        public void GnomeSortTest()
        {

        }

        [Test]
        public void RadixSortTest()
        {

        }

        [Test]
        public void MergeSortTest()
        {

        }

        [Test]
        public void QuickSortTest()
        {

        }

        private void FillRandom()
        {
            Random random = new();

            for (int i = 0; i < _source.Length; i++)
            {
                int item = random.Next(int.MinValue, int.MaxValue);

                _source[i] = item;
                _sortedSource.Add(item);
            }
        }
    }
}
