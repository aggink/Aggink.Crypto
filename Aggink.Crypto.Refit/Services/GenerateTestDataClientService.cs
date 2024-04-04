using Aggink.Crypto.Refit.Interfaces;
using Aggink.Crypto.Refit.Refits;
using Aggink.Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History;
using Microsoft.Extensions.Logging;

namespace Aggink.Crypto.Refit.Services;

public sealed class GenerateTestDataClientService : IGenerateTestDataClientService
{
    private readonly IApiSpacexdataHistory _apiSpacexdataHistory;
    private readonly ILogger<GenerateTestDataClientService> _logger;

    public GenerateTestDataClientService(
        IApiSpacexdataHistory apiSpacexdataHistory,
        ILogger<GenerateTestDataClientService> logger)
    {
        _apiSpacexdataHistory = apiSpacexdataHistory;
        _logger = logger;
    }

    public async Task<HistoricalEvent[]> GetAllHistoricalEventsAsync(CancellationToken cancellationToken)
    {
        return await _apiSpacexdataHistory.GetAllHistoricalEvents(cancellationToken);
    }

    public async Task<HistoricalEvent> GetOneHistoricalEventAsync(int id, CancellationToken cancellationToken)
    {
        return await _apiSpacexdataHistory.GetOneHistoricalEvents(id, cancellationToken);
    }

    public async Task<string> GetRandomTitleHistoricalEventAsync(CancellationToken cancellationToken)
    {
        try
        {
            var events = await GetAllHistoricalEventsAsync(cancellationToken);
            if (events?.Any() == true)
            {
                var rand = new Random();
                var randumNumber = rand.Next(0, events.Length - 1);

                return events[randumNumber].Title;
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Ошибка при выполнении запроса");
        }

        return "default";
    }
}
