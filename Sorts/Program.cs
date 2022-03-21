using System;
using System.Collections.Generic;

using Sorts.Benchmarks;
using Sorts.Algorithms;

using BenchmarkDotNet.Running;

namespace Sorts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SortBenchmark>();
        }
    }
}
