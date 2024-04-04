using Aggink.Crypto.Logic.DtoModels;
using Aggink.Crypto.Web.Features.Commands;
using Aggink.Crypto.Web.Features.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Aggink.Crypto.Web.Controllers;

[ApiController]
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
    /// <param name="command">Dto параметр</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Открытый ключ для пользователя</returns>
    [HttpPost(nameof(CreatePublicKey), Name = nameof(CreatePublicKey))]
    public async Task<ActionResult<string>> CreatePublicKey(CreatePublicKeyCommand command, CancellationToken cancellationToken)
    {
        var key = await _mediator.Send(command, cancellationToken);
        return Ok(key);
    }

    /// <summary>
    /// Верификация полученного сообщения полученным ключом
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
    /// Подписать текст пользователю
    /// </summary>
    /// <param name="command">Dto параметр</param>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Подписанный текст пользователя</returns>
    [HttpGet(nameof(GetMessageWithCertificate), Name = nameof(GetMessageWithCertificate))]
    public async Task<ActionResult<CertificateMessageDto>> GetMessageWithCertificate(GetMessageWithCertificateQuery query, CancellationToken cancellationToken)
    {
        var message = await _mediator.Send(query, cancellationToken);
        return Ok(message);
    }
}
