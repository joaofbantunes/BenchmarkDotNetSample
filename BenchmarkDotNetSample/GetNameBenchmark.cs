using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNetSample
{
    public class GetNameBenchmark
    {
        [Benchmark]
        public string Reflection()
        {
            return typeof(GetNameBenchmark).Name;
        }

        [Benchmark]
        public string NameOf()
        {
            return nameof(GetNameBenchmark);
        }
    }
}