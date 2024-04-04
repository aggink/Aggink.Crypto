using System.Text.Json.Serialization;

namespace Aggink.Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History;

public sealed record HistoricalEvent
{
    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("title")]
    public string Title { get; init; }

    [JsonPropertyName("event_date_utc")]
    public DateTime EventDateUtc { get; init; }

    [JsonPropertyName("event_date_unix")]
    public int EventDateUnix { get; init; }

    [JsonPropertyName("flight_number")]
    public int? FlightNumber { get; init; }

    [JsonPropertyName("details")]
    public string Details { get; init; }

    [JsonPropertyName("links")]
    public HistoricalEventLink Links { get; init; }
}
