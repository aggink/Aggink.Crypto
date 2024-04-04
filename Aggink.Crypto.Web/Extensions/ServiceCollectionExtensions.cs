using Aggink.Crypto.Logic.Extensions;

namespace Aggink.Crypto.Web.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddWebServices(this IServiceCollection services)
    {
        services.AddLogicServices();
    }
}
