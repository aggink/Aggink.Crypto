using Aggink.Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History;
using Refit;

namespace Aggink.Crypto.Refit.Refits;

public interface IApiSpacexdataHistory
{
    [Get("/v3/history")]
    Task<HistoricalEvent[]> GetAllHistoricalEvents(CancellationToken cancellationToken = default);

    [Get("/v3/history/{id}")]
    Task<HistoricalEvent> GetOneHistoricalEvents(int id, CancellationToken cancellationToken = default);
}
