using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

using Sorts.Benchmarks.Helpers;
using Sorts.Algorithms;

namespace Sorts.Benchmarks
{
    [RankColumn]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class SortBenchmarkRandom
    {
        private int _size; 


        public SortBenchmarkRandom()
        {
            _size = 100000;
        }


        [Benchmark]
        public void BaseListSortRandom()
        {
            var collection = CollectionHelper.GetCollection(_size);

            collection.Sort();
        }

        [Benchmark]
        public void BubbleSortRandom()
        {
            var collection = CollectionHelper.GetCollection(_size);

            BubbleSort<int> sort = new();

            sort.Sort(collection);
        }

        [Benchmark]
        public void CoctailSortRandom()
        {
            var collection = CollectionHelper.GetCollection(_size);

            CoctailSort<int> sort = new();

            sort.Sort(collection);
        }

        [Benchmark]
        public void SelectionSortRandom()
        {
            var collection = CollectionHelper.GetCollection(_size);

            SelectionSort<int> sort = new();

            sort.Sort(collection);
        }

        [Benchmark]
        public void GnomeSortRandom()
        {
            var collection = CollectionHelper.GetCollection(_size);

            GnomeSort<int> sort = new();

            sort.Sort(collection);
        }

        [Benchmark]
        public void InsertionSortRandom()
        {
            var collection = CollectionHelper.GetCollection(_size);

            InsertionSort<int> sort = new();

            sort.Sort(collection);
        }

        [Benchmark]
        public void ShellSortRandom()
        {
            var collection = CollectionHelper.GetCollection(_size);

            ShellSort<int> sort = new();

            sort.Sort(collection);
        }

        [Benchmark]
        public void TreeSortRandom()
        {
            var collection = CollectionHelper.GetCollection(_size);

            TreeSort<int> sort = new();

            sort.Sort(collection);
        }

        [Benchmark]
        public void HeapSortRandom()
        {
            var collection = CollectionHelper.GetCollection(_size);

            HeapSort<int> sort = new();

            sort.Sort(collection);
        }

        [Benchmark]
        public void LsdRedixSortRandom()
        {
            var collection = CollectionHelper.GetCollection(_size);

            LsdRedixSort sort = new();

            sort.Sort(collection);
        }

        [Benchmark]
        public void MsdRedixSortRandom()
        {
            var collection = CollectionHelper.GetCollection(_size);

            MsdRedixSort sort = new();

            sort.Sort(collection);
        }

        [Benchmark]
        public void MergeSortRandom()
        {
            var collection = CollectionHelper.GetCollection(_size);

            MergeSort<int> sort = new();

            sort.Sort(collection);
        }

        [Benchmark]
        public void QuickSortRandom()
        {
            var collection = CollectionHelper.GetCollection(_size);

            QuickSort<int> sort = new();

            sort.Sort(collection);
        }
    }
}
