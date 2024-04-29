using AutoFixture;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Crypto.Web.Test.Tools;

/// <summary>
/// Базовый шаблон тестового класса
/// </summary>
[TestFixture]
public abstract class SetUpTests
{
    protected readonly IFixture _fixture;
    protected readonly IMediator _mediator;
    protected readonly TestWebApplicationFactory _factory;
    protected readonly CancellationTokenSource _tokenSource;

    public SetUpTests()
    {
        _fixture = new Fixture();
        _factory = new TestWebApplicationFactory();

        _tokenSource = new CancellationTokenSource();

        var scope = _factory.Services.CreateScope();
        _mediator = scope.ServiceProvider.GetService<IMediator>();
    }

    /// <summary>
    /// Настройка тестового класса
    /// </summary>
    [OneTimeSetUp]
    public void SetUp()
    {

    }

    /// <summary>
    /// Очистка после прогона тестов
    /// </summary>
    [OneTimeTearDown]
    public void TearDown()
    {
        _factory.Dispose();
        _tokenSource.Dispose();
    }
}
