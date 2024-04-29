using Crypto.Logic.Exceptions;
using Crypto.Web.Middlewares.DtoModels;
using System.Net;

namespace Crypto.Web.Middlewares;

/// <summary>
/// Обработчик ошибок
/// </summary>
public sealed class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionMiddleware> _logger;

    public ExceptionMiddleware(
        RequestDelegate next,
        ILogger<ExceptionMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            var error = GetErrorResponse(context, ex);

            context.Response.StatusCode = (int)error.StatusCode;
            await context.Response.WriteAsJsonAsync(error.Response);

            _logger.LogError(ex, "Произошла ошибка при выполнении запроса. Описание запроса: {Request}", context.Request);
        }
    }

    /// <summary>
    /// Получить описание ошибки
    /// </summary>
    /// <param name="context">HttpContext</param>
    /// <param name="ex">Ошибка</param>
    /// <returns>Описание ошибки</returns>
    private (ErrorResponse Response, HttpStatusCode StatusCode) GetErrorResponse(HttpContext context, Exception ex)
    {
        var response = new ErrorResponse();

        switch (ex)
        {
            case CryptoException cryptoException:
                return (new ErrorResponse
                {
                    Code = cryptoException.HResult.ToString(),
                    Message = cryptoException.Message
                }, HttpStatusCode.BadRequest);
            case OperationCanceledException canceledException
                when context.RequestAborted.IsCancellationRequested:
                return (new ErrorResponse
                {
                    Code = canceledException.HResult.ToString(),
                    Message = "Запрос был отменен"
                }, HttpStatusCode.BadRequest);
            default:
                return (new ErrorResponse
                {
                    Code = ex.HResult.ToString(),
                    Message = "Что-то пошло не так. Пожалуйста, повторите попытку позже"
                }, HttpStatusCode.InternalServerError);
        }
    }
}
