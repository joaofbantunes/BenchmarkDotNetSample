```ini

Host Process Environment Information:
BenchmarkDotNet.Core=v0.9.9.0
OS=Windows
Processor=?, ProcessorCount=8
Frequency=2740584 ticks, Resolution=364.8857 ns, Timer=TSC
CLR=CORE, Arch=64-bit ? [RyuJIT]
GC=Concurrent Workstation
dotnet cli version: 1.0.0-preview2-003133

Type=GetNameBenchmark  Mode=Throughput  LaunchCount=2  
WarmupCount=10  TargetCount=200  

```
     Method |     Median |    StdDev |
----------- |----------- |---------- |
 Reflection | 16.0348 ns | 0.7896 ns |
     NameOf |  0.0005 ns | 0.0147 ns |
 GetNameBenchmark_Reflection_WarmupCount10_TargetCount200_LaunchCount2
  GetNameBenchmark_NameOf_WarmupCount10_TargetCount200_LaunchCount2
