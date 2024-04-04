using Aggink.Crypto.Logic.DtoModels;

namespace Aggink.Crypto.Logic.Interfaces.Repositories;

public interface IMemoryRepository
{
    int Count { get; }

    Task<string> AddKeyAsync(string text, CancellationToken cancellationToken);

    CertificateMessageDto GetMessageWithCertificate(string id);
}
