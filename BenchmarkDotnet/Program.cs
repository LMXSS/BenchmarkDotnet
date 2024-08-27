using BenchmarkDotnetRegex.Benchmarks;
using BenchmarkDotNet.Running;

class Program
{
    static void Main(string[] args)
    {
        BenchmarkRunner.Run<BenchmarkDotnetRegex.Benchmarks.EmailValidatorBenchmark>();
    }
}