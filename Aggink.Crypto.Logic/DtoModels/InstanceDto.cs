﻿using System.Security.Cryptography;

namespace Aggink.Crypto.Logic.DtoModels;

public sealed record InstanceDto
{
    public KeyValuePair<RSAParameters, RSAParameters> KeyProvider { get; init; }

    public string Message { get; init; }

    public string SignedMessage { get; init; }
}
