using Aggink.Crypto.Logic.DtoModels;
using Aggink.Crypto.Web.Controllers;
using Aggink.Crypto.Web.Features.Commands;
using Aggink.Crypto.Web.Features.Queries;
using Refit;

namespace Aggink.Crypto.Web.Test.Controllers.Refit;

public interface IManageController
{
    [Post($"/api/crypto/{nameof(ManageController.CreatePublicKey)}")]
    Task<IApiResponse<string>> CreatePublicKey(CreatePublicKeyCommand command, CancellationToken cancellationToken);

    [Post($"/api/crypto/{nameof(ManageController.VerifyMessage)}")]
    Task<IApiResponse<bool>> VerifyMessage(VerifyMessageCommand command, CancellationToken cancellationToken);

    [Post($"/api/crypto/{nameof(ManageController.MessageWithCertificate)}")]
    Task<IApiResponse<CertificateMessageDto>> MessageWithCertificate(GetMessageWithCertificateQuery query, CancellationToken cancellationToken);
}
