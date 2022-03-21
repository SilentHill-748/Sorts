using System;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

namespace Sorts.Tests
{
    public class SortTests
    {
        private readonly List<int> _source;
        private List<int> _sortedSource;


        public SortTests()
        {
            _source = new List<int>(10000);
            _sortedSource = new List<int>();
        }


        [SetUp]
        public void Init()
        {
            Random rnd = new();

            _source.Clear();
            _sortedSource.Clear();

            for (int i = 0; i < 10000; i++)
                _source.Add(rnd.Next(0, 10000));

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
            BubbleSort<int> bubbleSort = new(_source);

            bubbleSort.Sort();
            List<int> collection = bubbleSort.SortedCollection;

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void CoctailSortTest()
        {
            CoctailSort<int> coctailSort = new(_source);

            coctailSort.Sort();
            List<int> collection = coctailSort.SortedCollection;

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void InsertionSortTest()
        {
            InsertionSort<int> insertionSort = new(_source);

            insertionSort.Sort();
            List<int> collection = insertionSort.SortedCollection;

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void ShellSortTest()
        {
            ShellSort<int> shellSort = new(_source);

            shellSort.Sort();
            List<int> collection = shellSort.SortedCollection;

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void SelectionSortTest()
        {
            SelectionSort<int> selectionSort = new(_source);

            selectionSort.Sort();
            List<int> collection = selectionSort.SortedCollection;

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void TreeSortTest()
        {
            TreeSort<int> treeSort = new(_source);

            treeSort.Sort();
            List<int> collection = treeSort.SortedCollection;

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void HeapSortTest()
        {
            HeapSort<int> heapSort = new(_source);

            heapSort.Sort();

            List<int> collection = heapSort.SortedCollection;
            collection.Reverse();

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void GnomeSortTest()
        {
            GnomeSort<int> gnomeSort = new(_source);

            gnomeSort.Sort();
            List<int> collection = gnomeSort.SortedCollection;

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void LsdRadixSortTest()
        {
            LsdRedixSort lsdRadixSort = new(_source);

            lsdRadixSort.Sort();
            List<int> collection = lsdRadixSort.SortedCollection;

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);
        }

        [Test]
        public void MsdRedixSortTest()
        {
            MsdRedixSort msdRadixSort = new(_source);

            msdRadixSort.Sort();
            List<int> collection = msdRadixSort.SortedCollection;

            for (int i = 0; i < _source.Count; i++)
                Assert.AreEqual(_sortedSource[i], collection[i]);

        }

        [Test]
        public void MergeSortTest()
        {

        }

        [Test]
        public void QuickSortTest()
        {

        }
    }
}
