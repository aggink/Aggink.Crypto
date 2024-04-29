using Crypto.Logic.DtoModels;
using Crypto.Web.Controllers;
using Crypto.Web.Features.Commands;
using Crypto.Web.Features.DtoModels;
using Refit;

namespace Crypto.Web.Test.Controllers.Refit;

/// <summary>
/// Запросы к API приложения
/// </summary>
public interface IManageController
{
    /// <summary>
    /// Создать публичный ключ
    /// </summary>
    /// <param name="command">Генерация открытого ключа для пользователя</param>
    /// <returns>Публичный ключ</returns>
    [Post($"/api/crypto/{nameof(ManageController.CreatePublicKey)}")]
    Task<IApiResponse<string>> CreatePublicKey(CreatePublicKeyCommand command);

    /// <summary>
    /// Проверка сообщения
    /// </summary>
    /// <param name="VerifyMessage">Сообщение для верификации</param>
    /// <returns>True - валидация прошла успешно</returns>
    [Post($"/api/crypto/{nameof(ManageController.VerifyMessage)}")]
    Task<IApiResponse<bool>> VerifyMessage(VerifyMessageDto VerifyMessage);

    /// <summary>
    /// Получить сертификат
    /// </summary>
    /// <param name="Key">Публичный ключ</param>
    /// <returns>Сертификат</returns>
    [Headers("Content-Type: application/json")]
    [Post($"/api/crypto/{nameof(ManageController.MessageWithCertificate)}")]
    Task<IApiResponse<CertificateMessageDto>> MessageWithCertificate([Body] string Key);
}
