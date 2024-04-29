using Crypto.Refit.Exceptions;
using Crypto.Refit.Extensions;
using Crypto.Refit.Interfaces;
using Crypto.Refit.Refits;
using Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History;
using Microsoft.Extensions.Logging;

namespace Crypto.Refit.Services;

/// <summary>
/// Сервис запросов данных к API об исторических справках
/// </summary>
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
        var response = await _apiSpacexdataHistory.GetAllHistoricalEvents(cancellationToken);
        response.RefitResponseValidate(_logger);

        return response.Content;
    }

    public async Task<HistoricalEvent> GetOneHistoricalEventAsync(int id, CancellationToken cancellationToken)
    {
        var response = await _apiSpacexdataHistory.GetOneHistoricalEvents(id, cancellationToken);
        response.RefitResponseValidate(_logger);

        return response.Content;
    }

    public async Task<string> GetRandomTitleHistoricalEventAsync(CancellationToken cancellationToken)
    {
        try
        {
            var events = await GetAllHistoricalEventsAsync(cancellationToken);
            if (events == null || events.Any() == false)
                throw new RefitException("Пришел пустой ответ от сервера с историческими событиями");

            var rand = new Random();
            var randumNumber = rand.Next(0, events.Length - 1);

            return events[randumNumber].Title;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Ошибка при выполнении запроса");
            throw;
        }
    }
}
