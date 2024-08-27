namespace BenchmarkDotnet.Interfaces;

public interface IEmailValidator
{
    bool IsValid(string email);
}
