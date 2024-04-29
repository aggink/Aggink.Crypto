using Crypto.Web.Test.Tools.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace Crypto.Web.Test.Tools.Filters;

/// <summary>
/// Расширение конвейера ПО промежуточного слоя с помощью новых методов Configure
/// </summary>
public class StartupFilter : IStartupFilter
{
    public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
    {
        return app =>
        {
            app.UseMiddleware<ApplyRequestPortMiddleware>();
            next(app);
        };
    }
}
