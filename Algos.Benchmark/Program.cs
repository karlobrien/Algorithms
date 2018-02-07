using System;
using Algos;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Running;
using System.Linq;


namespace Algos.Benchmark
{
    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<AdvancedAlgosBenchmark>();
            var result = summary.Reports.All(report => report.GcStats.BytesAllocatedPerOperation == 0);

            Console.WriteLine(result);
        }
    }
}
