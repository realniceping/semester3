``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.2006/21H2/November2021Update)
AMD Ryzen 7 3700U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.401
  [Host]     : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT AVX2


```
|            Method |      Mean |     Error |    StdDev |   Gen0 | Allocated |
|------------------ |----------:|----------:|----------:|-------:|----------:|
|              test | 26.018 μs | 0.2242 μs | 0.1987 μs | 2.2278 |    4720 B |
| testPriorityQueue |  3.291 μs | 0.0130 μs | 0.0115 μs | 0.4501 |     944 B |
