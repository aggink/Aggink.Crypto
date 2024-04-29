using Crypto.Logic.Interfaces.Services;
using Crypto.Refit.Interfaces;

namespace Crypto.Logic.Services;

/// <summary>
/// Сервис генерации текста
/// </summary>
public sealed class TextGeneratorService : ITextGeneratorService
{
    private readonly IGenerateTestDataClientService _generateTestDataService;

    public TextGeneratorService(IGenerateTestDataClientService generateTestDataService)
    {
        _generateTestDataService = generateTestDataService;
    }

    public async Task<string> GetTextAsync(CancellationToken cancellationToken)
    {
        return await _generateTestDataService.GetRandomTitleHistoricalEventAsync(cancellationToken);
    }
}
