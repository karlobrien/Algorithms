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
        static MarketDataStruct[] MktDataStruct;
        static MarketData[] MktDataObj;
        static Data[] GenericData;
        const int size = 1000000;

        public AdvancedAlgosBenchmark()
        {
            MktDataStruct = new MarketDataStruct[size];
            MktDataObj = new MarketData[size];
            Data = new int[size];
            GenericData = new Data[size];

            Random random = new Random();

            for (var i = 0; i < size; i++)
            {
                var item = random.Next(0, size);
                Data[i] = item;

                var mkt = new MarketDataStruct{ Close = item };
                MktDataStruct[i] = mkt;

                var mktObj = new MarketData { Close = item };
                MktDataObj[i] = mktObj;

                var gData = new Data { Close = item };
                GenericData[i] = gData;
            }
        }

        [Benchmark]
        public static void MergeSortPerformance()
        {
            var sortedArray = MergeSort.Sort(Data);
        }

        [Benchmark]
        public static void MergeSortPerformanceByStruct()
        {
            var sortedArray = MergeSort.Sort(MktDataStruct);
        }

        [Benchmark]
        public static void MergeSortPerformanceByObject()
        {
            var sortedArray = MergeSort.Sort(MktDataObj);
        }

        [Benchmark]
        public static void MergeSortGeneric()
        {
            var sortedData = MergeSortGeneric<Data>.Sort(GenericData);
        }
    }
}