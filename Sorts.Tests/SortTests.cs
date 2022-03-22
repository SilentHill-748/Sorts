using System;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

using Sorts.Algorithms;

namespace Sorts.Tests
{
    public class SortTests
    {
        private readonly List<int> _source;
        private List<int> _sortedSource;
        private readonly int _size;


        public SortTests()
        {
            _source = new List<int>();
            _sortedSource = new List<int>();
            _size = 10000;
        }


        [SetUp]
        public void Init()
        {
            Random rnd = new();

            _source.Clear();
            _sortedSource.Clear();

            for (int i = 0; i < _size; i++)
                _source.Add(rnd.Next(0, int.MaxValue));

            _sortedSource = _source.OrderBy(x => x).ToList();
        }

        [Test]
        public void BaseSortTest()
        {
            _source.Sort();

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], _source[i]);
        }

        [Test]
        public void BubbleSortTest()
        {
            BubbleSort<int> bubbleSort = new();

            bubbleSort.Sort(_source);
            List<int> collection = bubbleSort.Collection;

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void CoctailSortTest()
        {
            CoctailSort<int> coctailSort = new();

            coctailSort.Sort(_source);
            List<int> collection = coctailSort.Collection;

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void InsertionSortTest()
        {
            InsertionSort<int> insertionSort = new();

            insertionSort.Sort(_source);
            List<int> collection = insertionSort.Collection;

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void ShellSortTest()
        {
            ShellSort<int> shellSort = new();

            shellSort.Sort(_source);
            List<int> collection = shellSort.Collection;

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void SelectionSortTest()
        {
            SelectionSort<int> selectionSort = new();

            selectionSort.Sort(_source);
            List<int> collection = selectionSort.Collection;

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void TreeSortTest()
        {
            TreeSort<int> treeSort = new();

            treeSort.Sort(_source);
            List<int> collection = treeSort.Collection;

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void HeapSortTest()
        {
            HeapSort<int> heapSort = new();

            heapSort.Sort(_source);

            List<int> collection = heapSort.Collection;
            collection.Reverse();

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void GnomeSortTest()
        {
            GnomeSort<int> gnomeSort = new();

            gnomeSort.Sort(_source);
            List<int> collection = gnomeSort.Collection;

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void LsdRadixSortTest()
        {
            LsdRedixSort lsdRadixSort = new();

            lsdRadixSort.Sort(_source);
            List<int> collection = lsdRadixSort.Collection;

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void MsdRedixSortTest()
        {
            MsdRedixSort msdRadixSort = new();

            msdRadixSort.Sort(_source);
            List<int> collection = msdRadixSort.Collection;

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);

        }

        [Test]
        public void MergeSortTest()
        {
            MergeSort<int> mergeSort = new();

            mergeSort.Sort(_source);
            List<int> collection = mergeSort.Collection;

            for (int i = 0; i < _sortedSource.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void QuickSortTest()
        {
            QuickSort<int> quickSort = new();

            quickSort.Sort(_source);
            List<int> collection = quickSort.Collection;

            for (int i = 0; i < _sortedSource.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }
    }
}
