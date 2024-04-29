using Crypto.Logic.DtoModels;

namespace Crypto.Logic.Interfaces.Repositories;

/// <summary>
/// Локальное хранилище данных
/// </summary>
public interface IMemoryRepository
{
    /// <summary>
    /// Количество записей
    /// </summary>
    int Count { get; }

    /// <summary>
    /// Получить сертификат по публичному ключу
    /// </summary>
    /// <param name="id">Идентификатор сообщения (публичный ключ)</param>
    /// <returns>Сертификат</returns>
    CertificateMessageDto GetMessageWithCertificate(string id);

    /// <summary>
    /// Добавить ключ в хранилище (подписать сообщение и сохранить его в хранилище)
    /// </summary>
    /// <param name="text">Сообщение</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Публичный ключ</returns>
    Task<string> AddKeyAsync(string text, CancellationToken cancellationToken);

    /// <summary>
    /// Добавить ключ в хранилище (подписать сообщение, сохранить его в хранилище и вернуть сертификат)
    /// </summary>
    /// <param name="text"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<CertificateMessageDto> AddKeyWithInstanceAsync(string text, CancellationToken cancellationToken);
}
