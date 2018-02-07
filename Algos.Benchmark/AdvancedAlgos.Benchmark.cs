using System;
using Algos;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Running;
using System.Linq;


namespace Algos.Benchmark
{
    [CoreJob]
    [MemoryDiagnoser]
    public class AdvancedAlgosBenchmark
    {
        static int[] Data;
        static List<MarketData> MktData;
        const int size = 1000000;

        public AdvancedAlgosBenchmark()
        {
            MktData = new List<MarketData>();
            Data = new int[size];
            Random random = new Random();

            for (var i = 0; i < size; i++)
            {
                var item = random.Next(0, size);
                Data[i] = item;
                var mkt = new MarketData{ Close = item };
                MktData.Add(mkt);
            }
        }

        [Benchmark]
        public static void MergeSortPerformance()
        {
            var sortedArray = MergeSort.Sort(Data);
        }

    }
}
