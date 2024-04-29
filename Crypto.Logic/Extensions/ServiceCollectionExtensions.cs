using Crypto.Logic.Interfaces.Repositories;
using Crypto.Logic.Interfaces.Services;
using Crypto.Logic.Repositories;
using Crypto.Logic.Services;
using Crypto.Refit.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Crypto.Logic.Extensions;

/// <summary>
/// Регистрация сервисов в DI
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Регистрация сервисов библиотеки Logic в DI
    /// </summary>
    /// <param name="service">Коллекция дескрипторов служб</param>
    public static void AddLogicServices(this IServiceCollection service)
    {
        // repositories
        service.AddSingleton<IMemoryRepository, MemoryRepository>();

        // services
        service.AddSingleton<IRSACryptoService, RSACryptoService>();
        service.AddSingleton<ITextGeneratorService, TextGeneratorService>();

        // refit
        service.AddRefitServices();
    }
}
