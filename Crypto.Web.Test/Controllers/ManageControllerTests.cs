using AutoFixture;
using Crypto.Logic.Interfaces.Services;
using Crypto.Web.Features.Commands;
using Crypto.Web.Features.DtoModels;
using Crypto.Web.Test.Controllers.Refit;
using Crypto.Web.Test.Tools;
using Crypto.Web.Test.Tools.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Security.Cryptography;

namespace Crypto.Web.Test.Controllers;

/// <summary>
/// Проверка API
/// </summary>
[TestFixture]
public class ManageControllerTests : SetUpTests
{
    /// <summary>
    /// Тестовый метод проверки подписи сообщения
    /// </summary>
    /// <param name="originalMessage">Оригинальное сообщение</param>
    /// <param name="originalMessageTest">Оригинальное тестовое сообщение</param>
    /// <param name="result">True - тестовые сообщения одинаковы</param>
    /// <returns></returns>
    [TestCase("Hello, World!", "Hello, World!", true)]
    [TestCase("Hello, World!", "Hello, World", false)]
    public async Task VerifyMessageTest(string originalMessage, string originalMessageTest, bool result)
    {
        var scope = _factory.Services.CreateScope();
        var rsaCryptoService = scope.ServiceProvider.GetRequiredService<IRSACryptoService>();

        var keyProvider = RSA.Create();
        var keys = new KeyValuePair<RSAParameters, RSAParameters>(keyProvider.ExportParameters(false), keyProvider.ExportParameters(true));

        var signedMessage = await rsaCryptoService.SignContentAsync(originalMessage, keys.Value, _tokenSource.Token);

        var manageController = _factory.CreateApi<IManageController>();

        var verifyMessage = new VerifyMessageDto()
        {
            OriginalMessage = originalMessageTest,
            PublicKey = rsaCryptoService.ToEncodedString(keys.Key),
            SignedMessage = signedMessage
        };

        var response = await manageController.VerifyMessage(verifyMessage);
        Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        var isVerify = response.Content;
        Assert.That(isVerify, Is.EqualTo(result));
    }

    /// <summary>
    /// Тестовый метод целого цикла: получения ключа, получения подписанного сообщения, проверка подписанного сообщения
    /// </summary>
    /// <param name="changeOrigMessage">Заменить оригинальное сообщение</param>
    /// <param name="changePublicKey">Заменить публичный ключ</param>
    /// <param name="changeSignedContent">Замесить подпись</param>
    /// <param name="result">Результат</param>
    /// <returns></returns>
    [TestCase(false, false, false, true)]
    [TestCase(true, false, false, false)]
    [TestCase(false, true, false, false)]
    [TestCase(false, false, true, false)]
    public async Task FullСycleTest(bool changeOrigMessage, bool changePublicKey, bool changeSignedContent, bool result)
    {
        var manageController = _factory.CreateApi<IManageController>();

        var publicKeyResponse = await manageController.CreatePublicKey(new CreatePublicKeyCommand());
        Assert.That(publicKeyResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        var publicKey = publicKeyResponse.Content;
        Assert.That(publicKey, Is.Not.Null);

        var messageWithCertificateResponse = await manageController.MessageWithCertificate(publicKey);
        Assert.That(messageWithCertificateResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        var messageWithCertificate = messageWithCertificateResponse.Content;
        Assert.That(messageWithCertificate, Is.Not.Null);

        var verifyMessageQuery = new VerifyMessageDto()
        {
            OriginalMessage = changeOrigMessage ? _fixture.Create<string>() : messageWithCertificate.OriginalMessage,
            PublicKey = changePublicKey ? _fixture.Create<string>() : messageWithCertificate.PublicKey,
            SignedMessage = changeSignedContent ? _fixture.Create<string>() : messageWithCertificate.SignedMessage
        };

        var verifyMessageResponse = await manageController.VerifyMessage(verifyMessageQuery);
        if (result)
        {
            Assert.That(verifyMessageResponse.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
        else
        {
            Assert.That(
                verifyMessageResponse.StatusCode == HttpStatusCode.InternalServerError ||
                verifyMessageResponse.StatusCode == HttpStatusCode.BadRequest ||
                verifyMessageResponse.StatusCode == HttpStatusCode.OK);
        }

        var verifyMessage = verifyMessageResponse.Content;
        Assert.That(verifyMessage, Is.EqualTo(result));
    }
}
