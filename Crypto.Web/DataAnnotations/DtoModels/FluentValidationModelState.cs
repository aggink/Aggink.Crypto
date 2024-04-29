namespace Crypto.Web.DataAnnotations.DtoModels;

/// <summary>
/// Описание ошибок
/// </summary>
public class FluentValidationModelState
{
    /// <summary>
    /// Ошибки валидации
    /// </summary>
    public IDictionary<string, string> Errors { get; set; }
}