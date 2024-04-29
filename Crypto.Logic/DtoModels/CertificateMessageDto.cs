namespace Crypto.Logic.DtoModels;

/// <summary>
/// Сертификат
/// </summary>
public sealed record CertificateMessageDto
{
    /// <summary>
    /// Сообщение
    /// </summary>
    public string OriginalMessage { get; init; }

    /// <summary>
    /// Подпись к сообщению
    /// </summary>
    public string SignedMessage { get; init; }

    /// <summary>
    /// Публичный ключ
    /// </summary>
    public string PublicKey { get; init; }
}
