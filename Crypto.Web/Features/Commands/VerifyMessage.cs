using Crypto.Logic.Exceptions;
using Crypto.Logic.Interfaces.Services;
using Crypto.Web.Extensions;
using Crypto.Web.Features.DtoModels;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace Crypto.Web.Features.Commands;

/// <summary>
/// Верификация сообщения
/// </summary>
public sealed class VerifyMessageCommand : IRequest<bool>
{
    /// <summary>
    /// Сообщение
    /// </summary>
    [Required]
    [FromBody]
    public VerifyMessageDto VerifyMessage { get; set; }
}

public sealed class VerifyMessageCommandValidator : AbstractValidator<VerifyMessageCommand>
{
    public VerifyMessageCommandValidator(IValidator<VerifyMessageDto> validator)
    {
        RuleFor(x => x.VerifyMessage)
            .NotNull()
            .SetValidator(validator)
            .OverridePropertyName(string.Empty);
    }
}

public sealed class VerifyMessageDtoValidator : AbstractValidator<VerifyMessageDto>
{
    public VerifyMessageDtoValidator()
    {
        RuleFor(x => x.PublicKey)
            .NotEmpty();

        RuleFor(x => x.OriginalMessage)
            .NotEmpty();

        RuleFor(x => x.SignedMessage)
            .NotEmpty();
    }
}

public sealed class VerifyMessageCommandHandler : IRequestHandler<VerifyMessageCommand, bool>
{
    private readonly IRSACryptoService _cryptoService;
    private readonly ILogger<VerifyMessageCommandHandler> _logger;

    public VerifyMessageCommandHandler(
        IRSACryptoService cryptoService,
        ILogger<VerifyMessageCommandHandler> logger)
    {
        _logger = logger;
        _cryptoService = cryptoService;
    }

    public async Task<bool> Handle(VerifyMessageCommand request, CancellationToken cancellationToken)
    {
        bool success = false;
        var encoder = new UTF8Encoding();

        var byteContent = encoder.GetBytes(request.VerifyMessage.OriginalMessage);
        var publicKey = _cryptoService.GetPublicKey(request.VerifyMessage.PublicKey);

        if (!request.VerifyMessage.SignedMessage.TryFromBase64String(out var byteSignedContent))
            throw new CryptoException("Неверный формат подписанного сообщения пользователя");

        using (var provider = new RSACryptoServiceProvider())
        {
            try
            {
                provider.ImportParameters(publicKey);
                success = provider.VerifyData(byteContent, CryptoConfig.MapNameToOID("SHA256"), byteSignedContent);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "При проверки сертификата произошла ошибка");
            }
        }

        return success;
    }
}
