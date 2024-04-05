using Aggink.Crypto.Logic.DtoModels;
using Aggink.Crypto.Web.Controllers;
using Aggink.Crypto.Web.Features.Commands;
using Aggink.Crypto.Web.Features.DtoModels;
using Refit;

namespace Aggink.Crypto.Web.Test.Controllers.Refit;

public interface IManageController
{
    [Post($"/api/crypto/{nameof(ManageController.CreatePublicKey)}")]
    Task<IApiResponse<string>> CreatePublicKey(CreatePublicKeyCommand command);

    [Post($"/api/crypto/{nameof(ManageController.VerifyMessage)}")]
    Task<IApiResponse<bool>> VerifyMessage(VerifyMessageDto VerifyMessage);

    [Headers("Content-Type: application/json")]
    [Post($"/api/crypto/{nameof(ManageController.MessageWithCertificate)}")]
    Task<IApiResponse<CertificateMessageDto>> MessageWithCertificate([Body] string Key);
}
