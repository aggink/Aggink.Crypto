using Aggink.Crypto.Logic.Interfaces.Repositories;
using Aggink.Crypto.Logic.Interfaces.Services;
using MediatR;

namespace Aggink.Crypto.Web.Features.Commands;

public sealed class CreatePublicKeyCommand : IRequest<string>
{

}

public sealed class CreatePublicKeyCommandHandler : IRequestHandler<CreatePublicKeyCommand, string>
{
    private readonly IMemoryRepository _memoryRepository;
    private readonly ITextGeneratorService _textGenerator;

    public CreatePublicKeyCommandHandler(
        IMemoryRepository memoryRepository,
        ITextGeneratorService textGenerator)
    {
        _memoryRepository = memoryRepository;
        _textGenerator = textGenerator;
    }

    public async Task<string> Handle(CreatePublicKeyCommand request, CancellationToken cancellationToken)
    {
        var text = await _textGenerator.GetTextAsync(cancellationToken);
        return await _memoryRepository.AddKeyAsync(text, cancellationToken);
    }
}
