using BenchmarkDotnet.Validators;
using BenchmarkDotNet.Attributes;


namespace BenchmarkDotnet.Benchmarks;

public class EmailValidatorBenchmark
{
    static int TryValidations = 100;

    [Benchmark]
    public void Regex()
    {
        var validator = new EmailValidatorRegex();
        for (int i = 0; i < TryValidations; i++)
            validator.IsValid("Teste@Email.com");
    }

    [Benchmark]
    public void WithOutRegex()
    {
        var validator = new EmailValidatorRegex();
        for (int i = 0; i < TryValidations; i++)
            validator.IsValid("Teste@Email.com");
    }
}
