using System.Text.Json.Serialization;

namespace Aggink.Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History;

public sealed record HistoricalEventLink
{
    [JsonPropertyName("reddit")]
    public string Reddit { get; set; }

    [JsonPropertyName("article")]
    public string Article { get; set; }

    [JsonPropertyName("wikipedia")]
    public string Wikipedia { get; set; }
}