using Refit;

namespace Aggink.Crypto.Web.Test.Tools.Extensions;

public static class TestWebApplicationFactoryExtensions
{
    public static T CreateApi<T>(this TestWebApplicationFactory factory)
    {
        var client = factory.CreateApiClient();
        return RestService.For<T>(client);
    }
}
