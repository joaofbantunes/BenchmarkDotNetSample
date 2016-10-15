using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace BenchmarkDotNetSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<GetNameBenchmark>(
                DefaultConfig.Instance.With(
                    new Job()
                        .With(Mode.Throughput)
                        .WithLaunchCount(2)
                        .WithWarmupCount(10)
                        .WithTargetCount(200)
                ));
        }
    }
}
