namespace Aggink.Crypto.Logic.Interfaces.Services;

public interface ITextGeneratorService
{
    Task<string> GetTextAsync(CancellationToken cancellationToken);
}
