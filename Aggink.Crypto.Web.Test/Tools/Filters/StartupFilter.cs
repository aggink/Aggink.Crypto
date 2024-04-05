using Aggink.Crypto.Web.Test.Tools.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace Aggink.Crypto.Web.Test.Tools.Filters;

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
