namespace Crypto.Logic.Interfaces.Services;

/// <summary>
/// Генератор получения текста
/// </summary>
public interface ITextGeneratorService
{
    /// <summary>
    /// Получить текст
    /// </summary>
    /// <param name="cancellationToken">Токен отмены</param>
    /// <returns>Текст</returns>
    Task<string> GetTextAsync(CancellationToken cancellationToken);
}
