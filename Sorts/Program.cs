using Sorts.Benchmarks;

using BenchmarkDotNet.Running;

namespace Sorts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SortBenchmarkRandom>();
        }
    }
}
