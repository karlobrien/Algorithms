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

    public class QuickSortBenchmark
    {
        static int[] Data;
        static MarketDataStruct[] MktDataStruct;
        static MarketData[] MktDataObj;
        static Data[] GenericData;
        static int[] SwData;
        const int size = 10000;

        public QuickSortBenchmark()
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
        public static void QuickSortValueType()
        {
            //var sortedArray = QuickSortByValue.Sort(Data);
            var sortedArray = QuickSortByValue.Sort(Data);
        }

        [Benchmark]
        public static void QuickSortSw()
        {
            //var sortedArray = QuickSortByValue.Sort(Data);
            var sortedArray = QuickSortSegwick.QuickSort(Data, 0, Data.Length-1);
        }

        [Benchmark]
        public static void QuickSortStruct()
        {
            var sortedArray = QuickSortByStruct.Sort(MktDataStruct);
        }

        [Benchmark]
        public static void QuickSortReferenceType()
        {
            var sortedArray = QuickSortByRefence.Sort(MktDataObj);
        }

        [Benchmark]
        public static void QuickSortGeneric()
        {
            var sortedData = QuickSortGeneric<Data>.Sort(GenericData);
        }
    }
}
