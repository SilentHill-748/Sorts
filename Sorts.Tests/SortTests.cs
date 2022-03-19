using System;
using System.Linq;

using NUnit.Framework;

namespace Sorts.Tests
{
    public class SortTests
    {
        private readonly int[] _source;
        private int[] _sortedSource;


        public SortTests()
        {
            _source = new int[10000];
            _sortedSource = Array.Empty<int>();
        }


        [SetUp]
        public void Init()
        {
            Random rnd = new();

            Array.Clear(_source);
            Array.Clear(_sortedSource);

            for (int i = 0; i < _source.Length; i++)
                _source[i] = rnd.Next(0, 10000);

            _sortedSource = _source.OrderBy(x => x).ToArray();
        }

        [Test]
        public void BaseSortTest()
        {
            Array.Sort(_source);
            CollectionAssert.AreEquivalent(_sortedSource, _source);
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
        public void SelectionSortTest()
        {
            SelectionSort<int> selectionSort = new(_source);

            selectionSort.Sort();

            CollectionAssert.AreEquivalent(_sortedSource, _source);
        }

        [Test]
        public void TreeSortTest()
        {
            TreeSort<int> treeSort = new(_source);

            treeSort.Sort();

            CollectionAssert.AreEquivalent(_sortedSource, _source);
        }

        [Test]
        public void HeapSortTest()
        {
            HeapSort<int> heapSort = new(_source);

            heapSort.Sort();

            CollectionAssert.AreEquivalent(_sortedSource, _source);
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
    }
}
