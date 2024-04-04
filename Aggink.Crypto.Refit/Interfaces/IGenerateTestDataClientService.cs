using Aggink.Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History;

namespace Aggink.Crypto.Refit.Interfaces;

public interface IGenerateTestDataClientService
{
    Task<HistoricalEvent[]> GetAllHistoricalEventsAsync(CancellationToken cancellationToken);

    Task<HistoricalEvent> GetOneHistoricalEventAsync(int id, CancellationToken cancellationToken);

    Task<string> GetRandomTitleHistoricalEventAsync(CancellationToken cancellationToken);
}
