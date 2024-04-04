namespace Aggink.Crypto.Logic.DtoModels;

public sealed record CertificateMessageDto
{
    public string OriginalMessage { get; init; }

    public string SignedMessage { get; init; }

    public string PublicKey { get; init; }
}
