using Microsoft.AspNetCore.Http;

namespace Aggink.Crypto.Web.Test.Tools.Middlewares
{
    public class ApplyRequestPortMiddleware
    {
        private readonly RequestDelegate _next;

        public ApplyRequestPortMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            // HACK: Устанавливаем LocalPort, чтобы корректно отрабатывали MapOnPublicPort/MapOnInternalPort.
            // По умолчанию в тестах LocalPort == 0 и маппинг для запросов не отрабатывает ни для публичного, ни для внутреннего порта.
            httpContext.Connection.LocalPort = httpContext.Request.Host.Port ?? throw new Exception("No port");

            await _next(httpContext);
        }
    }
}
