using Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History;

namespace Crypto.Refit.Interfaces;

/// <summary>
/// Интерфейс получения данных с API
/// </summary>
public interface IGenerateTestDataClientService
{
    /// <summary>
    /// Получить истории о всех событиях
    /// </summary>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Истории о всех событиях</returns>
    Task<HistoricalEvent[]> GetAllHistoricalEventsAsync(CancellationToken cancellationToken);

    /// <summary>
    /// Получить историю о событии
    /// </summary>
    /// <param name="id">Идентификатор события</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>История о событии</returns>
    Task<HistoricalEvent> GetOneHistoricalEventAsync(int id, CancellationToken cancellationToken);

    /// <summary>
    /// Получить рандомную историю о событии
    /// </summary>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>История о событии</returns>
    Task<string> GetRandomTitleHistoricalEventAsync(CancellationToken cancellationToken);
}
