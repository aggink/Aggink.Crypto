using Crypto.Logic.DtoModels;
using Crypto.Web.DataAnnotations;
using Crypto.Web.Features.Commands;
using Crypto.Web.Features.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Crypto.Web.Controllers;

/// <summary>
/// Работа с ЭЦП
/// </summary>
[ValidateUsingFluentValidation]
[Produces("application/json")]
[Route("api/crypto")]
public class ManageController : Controller
{
    private readonly IMediator _mediator;

    public ManageController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Генерация открытого ключа для пользователя
    /// </summary>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <remarks>Получаем и сохранение сообщение из стороннего api, возвращаем публичный ключ</remarks>
    /// <returns>Публичный ключ для пользователя</returns>
    [HttpPost(nameof(CreatePublicKey), Name = nameof(CreatePublicKey))]
    public async Task<ActionResult<string>> CreatePublicKey(CancellationToken cancellationToken)
    {
        var key = await _mediator.Send(new CreatePublicKeyCommand(), cancellationToken);
        return Ok(key);
    }

    /// <summary>
    /// Верификации сообщения
    /// </summary>
    /// <param name="command">Dto параметр</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>True - сообщение валидно</returns>
    [HttpPost(nameof(VerifyMessage), Name = nameof(VerifyMessage))]
    public async Task<ActionResult<bool>> VerifyMessage(VerifyMessageCommand command, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(command, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Подписать текст пользователя
    /// </summary>
    /// <param name="query">Dto параметр</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <remarks>По публичному ключу находим полученное сообщение из сторонней api в памяти, подписываем его и возвращаем</remarks>
    /// <returns>Подписанное сообщение пользователя</returns>
    [HttpPost(nameof(MessageWithCertificate), Name = nameof(MessageWithCertificate))]
    public async Task<ActionResult<CertificateMessageDto>> MessageWithCertificate(GetMessageWithCertificateQuery query, CancellationToken cancellationToken)
    {
        var message = await _mediator.Send(query, cancellationToken);
        return Ok(message);
    }

    /// <summary>
    /// Подписать сообщение пользователя
    /// </summary>
    /// <param name="command">Dto параметр</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <remarks>Берем сообщение пользователя, подписываем его и возвращаем сертификат</remarks>
    /// <returns>Подписанный текст пользователя</returns>
    [HttpPost(nameof(SingMessage), Name = nameof(SingMessage))]
    public async Task<ActionResult<CertificateMessageDto>> SingMessage(SingMessageCommand command, CancellationToken cancellationToken)
    {
        var message = await _mediator.Send(command, cancellationToken);
        return Ok(message);
    }
}
