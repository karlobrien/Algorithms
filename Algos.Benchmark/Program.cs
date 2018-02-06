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
    public class Program
    {
        static int[] Data;
        static List<MarketData> MktData;
        const int size = 100;
        static Program()
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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var summary = BenchmarkRunner.Run<Program>();
        }


        //public static int Size { get; set; }

        [Benchmark]
        public static void BubbleSortPerformance()
        {
            var sortedArray = BubbleSort.Sort(Data);
        }

        [Benchmark]
        public void BubbleSortByObjectPerformance()
        {
            var sortedArray = BubbleSort.Sort(MktData);
        }

        [Benchmark]
        public static void InsertionSortPerformance()
        {
            var sortedArray = InsertionSort.Sort(Data);
        }

        [Benchmark]
        public static void SelectionSortPerformance()
        {
            var sortedArray = SelectionSort.Sort(Data);
        }

        [Benchmark]
        public byte[] SomeLinq()
        {
            return Enumerable
                .Range(0, 100)
                .Where(i => i % 2 == 0)
                .Select(i => (byte)i)
                .ToArray();
        }
    }
}
