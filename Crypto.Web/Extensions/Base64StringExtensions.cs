namespace Crypto.Web.Extensions;

/// <summary>
/// Расширение для <see cref="Convert"/>
/// </summary>
public static class Base64StringExtensions
{
    /// <summary>
    /// Возвращает размер декодированного Base64-представления строки
    /// </summary>
    /// <param name="base64">Строка в формате Base64</param>
    /// <returns>Размер декодированного массива байт</returns>
    private static int DecodedSize(this string base64) =>
        (base64.Length * 3 + 3) / 4 - (base64.Length > 0 && base64[^1] == '=' ? base64.Length > 1 && base64[^2] == '=' ? 2 : 1 : 0);

    /// <summary>
    /// Получает декодированную строку из Base64, если строка является допустимым представлением в формате Base64.
    /// </summary>
    /// <param name="base64">Строка в формате Base64.</param>
    /// <param name="content">Декодированная строка, если строка является допустимым Base64-представлением; в противном случае - null.</param>
    /// <returns>True, если строка является допустимым Base64-представлением и удалось успешно декодировать; в противном случае - False.</returns>
    public static bool TryFromBase64String(this string base64, out byte[] content)
    {
        content = null;

        var bufferSize = DecodedSize(base64);
        Span<byte> buffer = stackalloc byte[bufferSize];
        var result = Convert.TryFromBase64String(base64, buffer, out var bytesWritten);
        if (result)
        {
            content = buffer.Slice(0, bytesWritten).ToArray();
        }

        return result;
    }
}
