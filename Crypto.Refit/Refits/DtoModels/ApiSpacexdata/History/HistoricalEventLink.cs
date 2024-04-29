using System.Text.Json.Serialization;

namespace Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History;

/// <summary>
/// Ссылки на статьи о событии
/// </summary>
public sealed record HistoricalEventLink
{
    /// <summary>
    /// Ссылка на Reddit
    /// </summary>
    [JsonPropertyName("reddit")]
    public string Reddit { get; init; }

    /// <summary>
    /// Ссылка на Article
    /// </summary>
    [JsonPropertyName("article")]
    public string Article { get; init; }

    /// <summary>
    /// Ссылка на Wikipedia
    /// </summary>
    [JsonPropertyName("wikipedia")]
    public string Wikipedia { get; init; }
}