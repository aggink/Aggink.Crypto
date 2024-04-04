using Aggink.Crypto.Logic.Interfaces.Services;
using Aggink.Crypto.Refit.Interfaces;

namespace Aggink.Crypto.Logic.Services;

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
