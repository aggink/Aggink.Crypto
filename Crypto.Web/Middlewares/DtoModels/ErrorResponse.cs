using System.Text.Json.Serialization;

namespace Crypto.Web.Middlewares.DtoModels;

/// <summary>
/// Сообщение об ошибке
/// </summary>
public sealed record ErrorResponse
{
    [JsonPropertyName("code")]
    public string Code { get; init; }

    [JsonPropertyName("message")]
    public string Message { get; init; }

    [JsonPropertyName("details")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public object Details { get; init; }
}
