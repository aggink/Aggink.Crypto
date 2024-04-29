using Crypto.Refit.Interfaces;
using Crypto.Refit.Refits;
using Crypto.Refit.Services;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace Crypto.Refit.Extensions;

/// <summary>
/// Регистрация сервисов в DI
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Регистрация сервисов библиотеки Refit
    /// </summary>
    /// <param name="services">Коллекция дескрипторов служб</param>
    public static void AddRefitServices(this IServiceCollection services)
    {
        services.AddApiRefitServices();
        services.AddSingleton<IGenerateTestDataClientService, GenerateTestDataClientService>();
    }

    /// <summary>
    /// Регистрация обработчика API - Refit
    /// </summary>
    /// <param name="services">Коллекция дескрипторов служб</param>
    private static void AddApiRefitServices(this IServiceCollection services)
    {
        services
            .AddRefitClient<IApiSpacexdataHistory>(_ => new RefitSettings()
            {
                CollectionFormat = CollectionFormat.Multi
            })
            .ConfigureHttpClient(client =>
            {
                client.BaseAddress = new Uri("https://api.spacexdata.com");
            });
    }
}
