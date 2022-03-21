using System.Collections.Generic;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

using Sorts.Benchmarks.Helpers;
using Sorts.Algorithms;

namespace Sorts.Benchmarks
{
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class SortBenchmark
    {
        private readonly List<int> _baseSortSource;
        private readonly List<int> _bubbleSortSource;
        private readonly List<int> _coctailSortSource;
        private readonly List<int> _gnomeSortSource;
        private readonly List<int> _heapSortSource;
        private readonly List<int> _insertionSortSource;
        private readonly List<int> _lsdRedixSortSource;
        private readonly List<int> _msdRedixSortSource;
        private readonly List<int> _mergeSortSource;
        private readonly List<int> _quickSortSource;
        private readonly List<int> _selectionSortSource;
        private readonly List<int> _shellSortSource;
        private readonly List<int> _treeSortSource;


        public SortBenchmark()
        {
            List<int> list = CollectionHelper.GetCollection(100000);

            _baseSortSource = new List<int>(list);
            _bubbleSortSource = new List<int>(list);
            _coctailSortSource = new List<int>(list);
            _gnomeSortSource = new List<int>(list);
            _heapSortSource = new List<int>(list);
            _insertionSortSource = new List<int>(list);
            _lsdRedixSortSource = new List<int>(list);
            _msdRedixSortSource = new List<int>(list);
            _mergeSortSource = new List<int>(list);
            _quickSortSource = new List<int>(list);
            _selectionSortSource = new List<int>(list);
            _shellSortSource = new List<int>(list);
            _treeSortSource = new List<int>(list);
        }

        [Benchmark]
        public void BaseListSort()
        {
            _baseSortSource.Sort();
        }

        [Benchmark]
        public void BubbleSort()
        {
            BubbleSort<int> bubbleSort = new(_bubbleSortSource);
            bubbleSort.Sort();
        }

        [Benchmark]
        public void CoctailSort()
        {
            CoctailSort<int> coctailSort = new(_coctailSortSource);
            coctailSort.Sort();
        }

        [Benchmark]
        public void GnomeSort()
        {
            GnomeSort<int> gnomeSort = new(_gnomeSortSource);
            gnomeSort.Sort();
        }

        [Benchmark]
        public void HeapSort()
        {
            HeapSort<int> heapSort = new(_heapSortSource);
            heapSort.Sort();
        }

        [Benchmark]
        public void InsertionSort()
        {
            InsertionSort<int> insertionSort = new(_insertionSortSource);
            insertionSort.Sort();
        }

        [Benchmark]
        public void LsdRedixSort()
        {
            LsdRedixSort lsdRedixSort = new(_lsdRedixSortSource);
            lsdRedixSort.Sort();
        }

        [Benchmark]
        public void MergeSort()
        {
            MergeSort<int> mergeSort = new(_mergeSortSource);
            mergeSort.Sort();
        }

        [Benchmark]
        public void MsdRedixSort()
        {
            MsdRedixSort msdRedixSort = new(_msdRedixSortSource);
            msdRedixSort.Sort();
        }

        [Benchmark]
        public void QuickSort()
        {
            QuickSort<int> quickSort = new(_quickSortSource);
            quickSort.Sort();
        }

        [Benchmark]
        public void SelectionSort()
        {
            SelectionSort<int> selectionSort = new(_selectionSortSource);
            selectionSort.Sort();
        }

        [Benchmark]
        public void ShellSort()
        {
            ShellSort<int> shellSort = new(_shellSortSource);
            shellSort.Sort();
        }

        [Benchmark]
        public void TreeSort()
        {
            TreeSort<int> treeSort = new(_treeSortSource);
            treeSort.Sort();
        }
    }
}
