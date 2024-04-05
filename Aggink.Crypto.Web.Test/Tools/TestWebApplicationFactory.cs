using Aggink.Crypto.Web.Test.Tools.Filters;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Aggink.Crypto.Web.Test.Tools;

public sealed class TestWebApplicationFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureAppConfiguration((hostContext, config) =>
        {
            var directory = Directory.GetCurrentDirectory();
            config.SetBasePath(directory);

            var appsettingsFilePath = Path.Combine(directory, "appsettings.json");
            var configuration = new ConfigurationBuilder()
                .AddJsonFile(appsettingsFilePath)
                .AddUserSecrets(Assembly.GetExecutingAssembly())
                .Build();

            config.AddConfiguration(configuration);
            config.AddEnvironmentVariables();
        });

        builder.ConfigureServices(services =>
        {
            services.AddSingleton<IStartupFilter, StartupFilter>();
        });

        builder.UseEnvironment("Development");
    }

    public HttpClient CreateApiClient()
    {
        var client = CreateClient(new WebApplicationFactoryClientOptions
        {
            BaseAddress = new Uri($"http://localhost:{7266}"),
        });

        return client;
    }
}
