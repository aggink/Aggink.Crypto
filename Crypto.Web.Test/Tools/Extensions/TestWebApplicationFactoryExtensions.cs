using Refit;

namespace Crypto.Web.Test.Tools.Extensions;

/// <summary>
/// Получение объектов для запросов к API
/// </summary>
public static class TestWebApplicationFactoryExtensions
{
    /// <summary>
    /// Получить объект для запросов к API
    /// </summary>
    /// <typeparam name="T">Тип интерфейса для запросов к API</typeparam>
    /// <param name="factory">Фабрика для загрузки приложения в память для сквозных функциональных тестов</param>
    /// <returns>Интерфейса для запросов к API</returns>
    public static T CreateApi<T>(this TestWebApplicationFactory factory)
    {
        var client = factory.CreateApiClient();
        return RestService.For<T>(client);
    }
}
