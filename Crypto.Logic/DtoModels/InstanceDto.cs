using System.Security.Cryptography;

namespace Crypto.Logic.DtoModels;

/// <summary>
/// Сертификат
/// </summary>
public sealed record InstanceDto
{
    /// <summary>
    /// Ключи
    /// </summary>
    public KeyValuePair<RSAParameters, RSAParameters> KeyProvider { get; init; }

    /// <summary>
    /// Сообщение
    /// </summary>
    public string Message { get; init; }

    /// <summary>
    /// Подписанное сообщение
    /// </summary>
    public string SignedMessage { get; init; }
}
