using Crypto.Logic.DtoModels;
using Crypto.Logic.Interfaces.Repositories;
using Crypto.Logic.Interfaces.Services;
using System.Collections.Concurrent;
using System.Security.Cryptography;

namespace Crypto.Logic.Repositories;

/// <summary>
/// Локальное хранилище данных
/// </summary>
public sealed class MemoryRepository : IMemoryRepository
{
    /// <summary>
    /// Локальное хранилище данных
    /// </summary>
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

    public async Task<CertificateMessageDto> AddKeyWithInstanceAsync(string text, CancellationToken cancellationToken)
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

        var certificate = new CertificateMessageDto
        {
            OriginalMessage = text,
            SignedMessage = signed,
            PublicKey = publicKey
        };

        return certificate;
    }
}
