<a name='assembly'></a>
# Crypto.Logic

## Contents

- [CertificateMessageDto](#T-Crypto-Logic-DtoModels-CertificateMessageDto 'Crypto.Logic.DtoModels.CertificateMessageDto')
  - [OriginalMessage](#P-Crypto-Logic-DtoModels-CertificateMessageDto-OriginalMessage 'Crypto.Logic.DtoModels.CertificateMessageDto.OriginalMessage')
  - [PublicKey](#P-Crypto-Logic-DtoModels-CertificateMessageDto-PublicKey 'Crypto.Logic.DtoModels.CertificateMessageDto.PublicKey')
  - [SignedMessage](#P-Crypto-Logic-DtoModels-CertificateMessageDto-SignedMessage 'Crypto.Logic.DtoModels.CertificateMessageDto.SignedMessage')
- [CryptoException](#T-Crypto-Logic-Exceptions-CryptoException 'Crypto.Logic.Exceptions.CryptoException')
- [IMemoryRepository](#T-Crypto-Logic-Interfaces-Repositories-IMemoryRepository 'Crypto.Logic.Interfaces.Repositories.IMemoryRepository')
  - [Count](#P-Crypto-Logic-Interfaces-Repositories-IMemoryRepository-Count 'Crypto.Logic.Interfaces.Repositories.IMemoryRepository.Count')
  - [AddKeyAsync(text,cancellationToken)](#M-Crypto-Logic-Interfaces-Repositories-IMemoryRepository-AddKeyAsync-System-String,System-Threading-CancellationToken- 'Crypto.Logic.Interfaces.Repositories.IMemoryRepository.AddKeyAsync(System.String,System.Threading.CancellationToken)')
  - [AddKeyWithInstanceAsync(text,cancellationToken)](#M-Crypto-Logic-Interfaces-Repositories-IMemoryRepository-AddKeyWithInstanceAsync-System-String,System-Threading-CancellationToken- 'Crypto.Logic.Interfaces.Repositories.IMemoryRepository.AddKeyWithInstanceAsync(System.String,System.Threading.CancellationToken)')
  - [GetMessageWithCertificate(id)](#M-Crypto-Logic-Interfaces-Repositories-IMemoryRepository-GetMessageWithCertificate-System-String- 'Crypto.Logic.Interfaces.Repositories.IMemoryRepository.GetMessageWithCertificate(System.String)')
- [IRSACryptoService](#T-Crypto-Logic-Interfaces-Services-IRSACryptoService 'Crypto.Logic.Interfaces.Services.IRSACryptoService')
  - [GetPublicKey(key)](#M-Crypto-Logic-Interfaces-Services-IRSACryptoService-GetPublicKey-System-String- 'Crypto.Logic.Interfaces.Services.IRSACryptoService.GetPublicKey(System.String)')
  - [SignContentAsync(content,key,cancellationToken)](#M-Crypto-Logic-Interfaces-Services-IRSACryptoService-SignContentAsync-System-String,System-Security-Cryptography-RSAParameters,System-Threading-CancellationToken- 'Crypto.Logic.Interfaces.Services.IRSACryptoService.SignContentAsync(System.String,System.Security.Cryptography.RSAParameters,System.Threading.CancellationToken)')
  - [ToEncodedString(source)](#M-Crypto-Logic-Interfaces-Services-IRSACryptoService-ToEncodedString-System-Security-Cryptography-RSAParameters- 'Crypto.Logic.Interfaces.Services.IRSACryptoService.ToEncodedString(System.Security.Cryptography.RSAParameters)')
- [ITextGeneratorService](#T-Crypto-Logic-Interfaces-Services-ITextGeneratorService 'Crypto.Logic.Interfaces.Services.ITextGeneratorService')
  - [GetTextAsync(cancellationToken)](#M-Crypto-Logic-Interfaces-Services-ITextGeneratorService-GetTextAsync-System-Threading-CancellationToken- 'Crypto.Logic.Interfaces.Services.ITextGeneratorService.GetTextAsync(System.Threading.CancellationToken)')
- [InstanceDto](#T-Crypto-Logic-DtoModels-InstanceDto 'Crypto.Logic.DtoModels.InstanceDto')
  - [KeyProvider](#P-Crypto-Logic-DtoModels-InstanceDto-KeyProvider 'Crypto.Logic.DtoModels.InstanceDto.KeyProvider')
  - [Message](#P-Crypto-Logic-DtoModels-InstanceDto-Message 'Crypto.Logic.DtoModels.InstanceDto.Message')
  - [SignedMessage](#P-Crypto-Logic-DtoModels-InstanceDto-SignedMessage 'Crypto.Logic.DtoModels.InstanceDto.SignedMessage')
- [MemoryRepository](#T-Crypto-Logic-Repositories-MemoryRepository 'Crypto.Logic.Repositories.MemoryRepository')
  - [Instances](#P-Crypto-Logic-Repositories-MemoryRepository-Instances 'Crypto.Logic.Repositories.MemoryRepository.Instances')
- [RSACryptoService](#T-Crypto-Logic-Services-RSACryptoService 'Crypto.Logic.Services.RSACryptoService')
- [ServiceCollectionExtensions](#T-Crypto-Logic-Extensions-ServiceCollectionExtensions 'Crypto.Logic.Extensions.ServiceCollectionExtensions')
  - [AddLogicServices(service)](#M-Crypto-Logic-Extensions-ServiceCollectionExtensions-AddLogicServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Crypto.Logic.Extensions.ServiceCollectionExtensions.AddLogicServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [TextGeneratorService](#T-Crypto-Logic-Services-TextGeneratorService 'Crypto.Logic.Services.TextGeneratorService')

<a name='T-Crypto-Logic-DtoModels-CertificateMessageDto'></a>
## CertificateMessageDto `type`

##### Namespace

Crypto.Logic.DtoModels

##### Summary

Сертификат

<a name='P-Crypto-Logic-DtoModels-CertificateMessageDto-OriginalMessage'></a>
### OriginalMessage `property`

##### Summary

Сообщение

<a name='P-Crypto-Logic-DtoModels-CertificateMessageDto-PublicKey'></a>
### PublicKey `property`

##### Summary

Публичный ключ

<a name='P-Crypto-Logic-DtoModels-CertificateMessageDto-SignedMessage'></a>
### SignedMessage `property`

##### Summary

Подпись к сообщению

<a name='T-Crypto-Logic-Exceptions-CryptoException'></a>
## CryptoException `type`

##### Namespace

Crypto.Logic.Exceptions

##### Summary

Ошибка выброшенная разработчиком

<a name='T-Crypto-Logic-Interfaces-Repositories-IMemoryRepository'></a>
## IMemoryRepository `type`

##### Namespace

Crypto.Logic.Interfaces.Repositories

##### Summary

Локальное хранилище данных

<a name='P-Crypto-Logic-Interfaces-Repositories-IMemoryRepository-Count'></a>
### Count `property`

##### Summary

Количество записей

<a name='M-Crypto-Logic-Interfaces-Repositories-IMemoryRepository-AddKeyAsync-System-String,System-Threading-CancellationToken-'></a>
### AddKeyAsync(text,cancellationToken) `method`

##### Summary

Добавить ключ в хранилище (подписать сообщение и сохранить его в хранилище)

##### Returns

Публичный ключ

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Сообщение |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-Crypto-Logic-Interfaces-Repositories-IMemoryRepository-AddKeyWithInstanceAsync-System-String,System-Threading-CancellationToken-'></a>
### AddKeyWithInstanceAsync(text,cancellationToken) `method`

##### Summary

Добавить ключ в хранилище (подписать сообщение, сохранить его в хранилище и вернуть сертификат)

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') |  |

<a name='M-Crypto-Logic-Interfaces-Repositories-IMemoryRepository-GetMessageWithCertificate-System-String-'></a>
### GetMessageWithCertificate(id) `method`

##### Summary

Получить сертификат по публичному ключу

##### Returns

Сертификат

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Идентификатор сообщения (публичный ключ) |

<a name='T-Crypto-Logic-Interfaces-Services-IRSACryptoService'></a>
## IRSACryptoService `type`

##### Namespace

Crypto.Logic.Interfaces.Services

##### Summary

Интерфейс предоставляющий работу с криптографией

<a name='M-Crypto-Logic-Interfaces-Services-IRSACryptoService-GetPublicKey-System-String-'></a>
### GetPublicKey(key) `method`

##### Summary

Получить параметры для алгоритма RSA

##### Returns

Параметры для алгоритма RSA

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Публичный ключ |

<a name='M-Crypto-Logic-Interfaces-Services-IRSACryptoService-SignContentAsync-System-String,System-Security-Cryptography-RSAParameters,System-Threading-CancellationToken-'></a>
### SignContentAsync(content,key,cancellationToken) `method`

##### Summary

Получить подписанное сообщение

##### Returns

Подписанное сообщение

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| content | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Сообщение |
| key | [System.Security.Cryptography.RSAParameters](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Cryptography.RSAParameters 'System.Security.Cryptography.RSAParameters') | Параметры для алгоритма RSA |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-Crypto-Logic-Interfaces-Services-IRSACryptoService-ToEncodedString-System-Security-Cryptography-RSAParameters-'></a>
### ToEncodedString(source) `method`

##### Summary

Получить публичный ключ

##### Returns

Публичный ключ

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.Security.Cryptography.RSAParameters](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Cryptography.RSAParameters 'System.Security.Cryptography.RSAParameters') | Параметры для алгоритма RSA |

<a name='T-Crypto-Logic-Interfaces-Services-ITextGeneratorService'></a>
## ITextGeneratorService `type`

##### Namespace

Crypto.Logic.Interfaces.Services

##### Summary

Генератор получения текста

<a name='M-Crypto-Logic-Interfaces-Services-ITextGeneratorService-GetTextAsync-System-Threading-CancellationToken-'></a>
### GetTextAsync(cancellationToken) `method`

##### Summary

Получить текст

##### Returns

Текст

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-Crypto-Logic-DtoModels-InstanceDto'></a>
## InstanceDto `type`

##### Namespace

Crypto.Logic.DtoModels

##### Summary

Сертификат

<a name='P-Crypto-Logic-DtoModels-InstanceDto-KeyProvider'></a>
### KeyProvider `property`

##### Summary

Ключи

<a name='P-Crypto-Logic-DtoModels-InstanceDto-Message'></a>
### Message `property`

##### Summary

Сообщение

<a name='P-Crypto-Logic-DtoModels-InstanceDto-SignedMessage'></a>
### SignedMessage `property`

##### Summary

Подписанное сообщение

<a name='T-Crypto-Logic-Repositories-MemoryRepository'></a>
## MemoryRepository `type`

##### Namespace

Crypto.Logic.Repositories

##### Summary

Локальное хранилище данных

<a name='P-Crypto-Logic-Repositories-MemoryRepository-Instances'></a>
### Instances `property`

##### Summary

Локальное хранилище данных

<a name='T-Crypto-Logic-Services-RSACryptoService'></a>
## RSACryptoService `type`

##### Namespace

Crypto.Logic.Services

##### Summary

Сервис по работе с алгоритмом RSA

<a name='T-Crypto-Logic-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

Crypto.Logic.Extensions

##### Summary

Регистрация сервисов в DI

<a name='M-Crypto-Logic-Extensions-ServiceCollectionExtensions-AddLogicServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddLogicServices(service) `method`

##### Summary

Регистрация сервисов библиотеки Logic в DI

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| service | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |

<a name='T-Crypto-Logic-Services-TextGeneratorService'></a>
## TextGeneratorService `type`

##### Namespace

Crypto.Logic.Services

##### Summary

Сервис генерации текста
