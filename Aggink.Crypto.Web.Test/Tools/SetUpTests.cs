using AutoFixture;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Aggink.Crypto.Web.Test.Tools;

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

    [OneTimeSetUp]
    public void SetUp()
    {

    }

    [OneTimeTearDown]
    public void TearDown()
    {
        _factory.Dispose();
        _tokenSource.Dispose();
    }
}
