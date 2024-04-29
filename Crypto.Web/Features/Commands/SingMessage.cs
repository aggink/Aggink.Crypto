using Crypto.Logic.DtoModels;
using Crypto.Logic.Interfaces.Repositories;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Crypto.Web.Features.Commands;

/// <summary>
/// Подписать сообщение пользователя
/// </summary>
public sealed class SingMessageCommand : IRequest<CertificateMessageDto>
{
    /// <summary>
    /// Сообщение пользователя
    /// </summary>
    [Required]
    [FromBody]
    public string OriginalMessage { get; set; }
}

public sealed class SingMessageCommandValidator : AbstractValidator<SingMessageCommand>
{
    public SingMessageCommandValidator()
    {
        RuleFor(x => x.OriginalMessage)
            .NotEmpty();
    }
}

public sealed class SingMessageCommandHandler : IRequestHandler<SingMessageCommand, CertificateMessageDto>
{
    private readonly IMemoryRepository _memoryRepository;

    public SingMessageCommandHandler(IMemoryRepository memoryRepository)
    {
        _memoryRepository = memoryRepository;
    }

    public async Task<CertificateMessageDto> Handle(SingMessageCommand request, CancellationToken cancellationToken)
    {
        var certificate = await _memoryRepository.AddKeyWithInstanceAsync(request.OriginalMessage, cancellationToken);
        return certificate;
    }
}
