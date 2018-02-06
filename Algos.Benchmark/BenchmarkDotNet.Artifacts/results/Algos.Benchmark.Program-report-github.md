``` ini

BenchmarkDotNet=v0.10.12, OS=macOS 10.13.3 (17D47) [Darwin 17.4.0]
Intel Core i5-6267U CPU 2.90GHz (Skylake), 1 CPU, 4 logical cores and 2 physical cores
.NET Core SDK=2.1.3
  [Host] : .NET Core 2.0.4 (Framework 4.6.0.0), 64bit RyuJIT
  Core   : .NET Core 2.0.4 (Framework 4.6.0.0), 64bit RyuJIT

Job=Core  Runtime=Core  

```
|                        Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
|------------------------------ |-----------:|----------:|----------:|-------:|----------:|
|         BubbleSortPerformance |   6.023 us | 0.0902 us | 0.0799 us |      - |       0 B |
| BubbleSortByObjectPerformance | 266.203 us | 5.1519 us | 6.6989 us | 0.9766 |    2200 B |
|      InsertionSortPerformance |   7.097 us | 0.1215 us | 0.1137 us |      - |       0 B |
|      SelectionSortPerformance |   5.788 us | 0.1156 us | 0.1237 us |      - |       0 B |
|                      SomeLinq |   1.500 us | 0.0234 us | 0.0219 us | 0.2308 |     488 B |
