using BenchmarkDotnet.Benchmarks;
using BenchmarkDotNet.Running;

class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunnerCore.Run<BenchmarkDotnet.Benchmarks.EmailValidatorBenchmark>();
    }
}