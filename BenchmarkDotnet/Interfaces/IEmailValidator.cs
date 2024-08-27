namespace BenchmarkDotnetRegex.Interfaces;

public interface IEmailValidator
{
    bool IsValid(string email);
}
