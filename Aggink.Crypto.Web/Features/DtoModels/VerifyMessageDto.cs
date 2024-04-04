namespace Aggink.Crypto.Web.Features.DtoModels;

public sealed class VerifyMessageDto
{
    public string PublicKey { get; set; }

    public string OriginalMessage { get; set; }

    public string SignedContent { get; set; }
}
