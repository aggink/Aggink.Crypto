using System.Text.Json.Serialization;

namespace Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History;

/// <summary>
/// Историческое событие
/// </summary>
public sealed record HistoricalEvent
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; init; }

    /// <summary>
    /// Название события
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; init; }

    /// <summary>
    /// Дата события
    /// </summary>
    [JsonPropertyName("event_date_utc")]
    public DateTime EventDateUtc { get; init; }

    /// <summary>
    /// Дата события
    /// </summary>
    [JsonPropertyName("event_date_unix")]
    public int EventDateUnix { get; init; }

    /// <summary>
    /// Номер
    /// </summary>
    [JsonPropertyName("flight_number")]
    public int? FlightNumber { get; init; }

    /// <summary>
    /// Описание
    /// </summary>
    [JsonPropertyName("details")]
    public string Details { get; init; }

    /// <summary>
    /// Ссылки на статьи о событии
    /// </summary>
    [JsonPropertyName("links")]
    public HistoricalEventLink Links { get; init; }
}
