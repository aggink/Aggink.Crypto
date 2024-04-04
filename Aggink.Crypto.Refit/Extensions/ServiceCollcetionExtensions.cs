using Aggink.Crypto.Refit.Interfaces;
using Aggink.Crypto.Refit.Refits;
using Aggink.Crypto.Refit.Services;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace Aggink.Crypto.Refit.Extensions;

public static class ServiceCollcetionExtensions
{
    public static void AddRefitServices(this IServiceCollection services)
    {
        services.AddApiRefitServices();
        services.AddSingleton<IGenerateTestDataClientService, GenerateTestDataClientService>();
    }

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
