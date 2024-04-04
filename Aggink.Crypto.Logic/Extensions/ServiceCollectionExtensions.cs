using Aggink.Crypto.Logic.Interfaces.Repositories;
using Aggink.Crypto.Logic.Interfaces.Services;
using Aggink.Crypto.Logic.Repositories;
using Aggink.Crypto.Logic.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Aggink.Crypto.Logic.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddLogicServices(this IServiceCollection service)
    {
        // repositories
        service.AddSingleton<IMemoryRepository, MemoryRepository>();

        // services
        service.AddSingleton<IRSACryptoService, RSACryptoService>();
        service.AddSingleton<ITextGeneratorService, TextGeneratorService>();
    }
}
