using Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History;
using Refit;

namespace Crypto.Refit.Refits;

/// <summary>
/// Запросы к API
/// </summary>
public interface IApiSpacexdataHistory
{
    /// <summary>
    /// Получить информацию о всех событиях
    /// </summary>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Информация о всех событиях</returns>
    [Get("/v3/history")]
    Task<IApiResponse<HistoricalEvent[]>> GetAllHistoricalEvents(CancellationToken cancellationToken = default);

    /// <summary>
    /// Получить информацию о событии
    /// </summary>
    /// <param name="id">Идентификатор события</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Информация о событии</returns>
    [Get("/v3/history/{id}")]
    Task<IApiResponse<HistoricalEvent>> GetOneHistoricalEvents(int id, CancellationToken cancellationToken = default);
}
