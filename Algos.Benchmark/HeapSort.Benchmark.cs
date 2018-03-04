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

    public class HeapSortBenchmark
    {
        static int[] Data;
        static MarketDataStruct[] MktDataStruct;
        static MarketData[] MktDataObj;
        static Data[] GenericData;
        static int[] SwData;
        const int size = 10000;

        public HeapSortBenchmark()
        {
            MktDataStruct = new MarketDataStruct[size];
            MktDataObj = new MarketData[size];
            Data = new int[size];
            SwData = new int[size];
            GenericData = new Data[size];

            Random random = new Random();

            for (var i = 0; i < size; i++)
            {
                var item = random.Next(0, size);
                Data[i] = item;

                SwData[i] = item;

                var mkt = new MarketDataStruct{ Close = item };
                MktDataStruct[i] = mkt;

                var mktObj = new MarketData { Close = item };
                MktDataObj[i] = mktObj;

                var gData = new Data { Close = item };
                GenericData[i] = gData;
            }
        }

        [Benchmark]
        public static void HeapSortValueType()
        {
            //var sortedArray = QuickSortByValue.Sort(Data);
            var sortedArray = HeapSortByValue.HeapSort(Data);
        }

        [Benchmark]
        public static void HeapSortStruct()
        {
            //var sortedArray = QuickSortByStruct.QuickSort(MktDataStruct, 0, MktDataStruct.Length);
        }

        [Benchmark]
        public static void HeapSortReferenceType()
        {
            //var sortedArray = QuickSortByRefence.Sort(MktDataObj);
        }

        [Benchmark]
        public static void HeapSortGeneric()
        {
            //var sortedData = QuickSortGeneric<Data>.Sort(GenericData);
        }
    }
}
