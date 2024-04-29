using System.Security.Cryptography;

namespace Crypto.Logic.Interfaces.Services;

/// <summary>
/// Интерфейс предоставляющий работу с криптографией
/// </summary>
public interface IRSACryptoService
{
    /// <summary>
    /// Получить параметры для алгоритма RSA
    /// </summary>
    /// <param name="key">Публичный ключ</param>
    /// <returns>Параметры для алгоритма RSA</returns>
    RSAParameters GetPublicKey(string key);

    /// <summary>
    /// Получить публичный ключ
    /// </summary>
    /// <param name="source">Параметры для алгоритма RSA</param>
    /// <returns>Публичный ключ</returns>
    string ToEncodedString(RSAParameters source);

    /// <summary>
    /// Получить подписанное сообщение
    /// </summary>
    /// <param name="content">Сообщение</param>
    /// <param name="key">Параметры для алгоритма RSA</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Подписанное сообщение</returns>
    Task<string> SignContentAsync(string content, RSAParameters key, CancellationToken cancellationToken);
}
