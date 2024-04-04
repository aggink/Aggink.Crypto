using Aggink.Crypto.Logic.DtoModels;
using Aggink.Crypto.Logic.Interfaces.Repositories;
using Aggink.Crypto.Logic.Interfaces.Services;
using System.Collections.Concurrent;
using System.Security.Cryptography;

namespace Aggink.Crypto.Logic.Repositories;

public sealed class MemoryRepository : IMemoryRepository
{
    private ConcurrentDictionary<string, InstanceDto> Instances { get; set; }

    private readonly IRSACryptoService _rsaCryptoService;

    public MemoryRepository(IRSACryptoService rsaCryptoService)
    {
        _rsaCryptoService = rsaCryptoService;

        Instances = new ConcurrentDictionary<string, InstanceDto>();
    }

    public int Count
    {
        get => Instances.Count;
    }

    public async Task<string> AddKeyAsync(string text, CancellationToken cancellationToken)
    {
        var keyProvider = RSA.Create();
        var keys = new KeyValuePair<RSAParameters, RSAParameters>(keyProvider.ExportParameters(false), keyProvider.ExportParameters(true));

        var signed = await _rsaCryptoService.SignContentAsync(text, keys.Value, cancellationToken);

        var instance = new InstanceDto
        {
            Message = text,
            KeyProvider = keys,
            SignedMessage = signed
        };

        var publicKey = _rsaCryptoService.ToEncodedString(instance.KeyProvider.Key);

        Instances.TryAdd(publicKey, instance);

        return publicKey;
    }

    public CertificateMessageDto GetMessageWithCertificate(string id)
    {
        if (Instances.TryGetValue(id, out var content))
        {
            var publicKey = _rsaCryptoService.ToEncodedString(content.KeyProvider.Key);

            return new CertificateMessageDto()
            {
                OriginalMessage = content.Message,
                SignedMessage = content.SignedMessage,
                PublicKey = publicKey
            };
        }

        return null;
    }
}
