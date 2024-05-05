<a name='assembly'></a>
# Crypto.Web

## Contents

- [Base64StringExtensions](#T-Crypto-Web-Extensions-Base64StringExtensions 'Crypto.Web.Extensions.Base64StringExtensions')
  - [DecodedSize(base64)](#M-Crypto-Web-Extensions-Base64StringExtensions-DecodedSize-System-String- 'Crypto.Web.Extensions.Base64StringExtensions.DecodedSize(System.String)')
  - [TryFromBase64String(base64,content)](#M-Crypto-Web-Extensions-Base64StringExtensions-TryFromBase64String-System-String,System-Byte[]@- 'Crypto.Web.Extensions.Base64StringExtensions.TryFromBase64String(System.String,System.Byte[]@)')
- [CreatePublicKeyCommand](#T-Crypto-Web-Features-Commands-CreatePublicKeyCommand 'Crypto.Web.Features.Commands.CreatePublicKeyCommand')
- [ErrorResponse](#T-Crypto-Web-Middlewares-DtoModels-ErrorResponse 'Crypto.Web.Middlewares.DtoModels.ErrorResponse')
  - [Code](#P-Crypto-Web-Middlewares-DtoModels-ErrorResponse-Code 'Crypto.Web.Middlewares.DtoModels.ErrorResponse.Code')
  - [Details](#P-Crypto-Web-Middlewares-DtoModels-ErrorResponse-Details 'Crypto.Web.Middlewares.DtoModels.ErrorResponse.Details')
  - [Message](#P-Crypto-Web-Middlewares-DtoModels-ErrorResponse-Message 'Crypto.Web.Middlewares.DtoModels.ErrorResponse.Message')
- [ExceptionMiddleware](#T-Crypto-Web-Middlewares-ExceptionMiddleware 'Crypto.Web.Middlewares.ExceptionMiddleware')
  - [GetErrorResponse(context,ex)](#M-Crypto-Web-Middlewares-ExceptionMiddleware-GetErrorResponse-Microsoft-AspNetCore-Http-HttpContext,System-Exception- 'Crypto.Web.Middlewares.ExceptionMiddleware.GetErrorResponse(Microsoft.AspNetCore.Http.HttpContext,System.Exception)')
- [FluentValidationModelState](#T-Crypto-Web-DataAnnotations-DtoModels-FluentValidationModelState 'Crypto.Web.DataAnnotations.DtoModels.FluentValidationModelState')
  - [Errors](#P-Crypto-Web-DataAnnotations-DtoModels-FluentValidationModelState-Errors 'Crypto.Web.DataAnnotations.DtoModels.FluentValidationModelState.Errors')
- [GetMessageWithCertificateQuery](#T-Crypto-Web-Features-Queries-GetMessageWithCertificateQuery 'Crypto.Web.Features.Queries.GetMessageWithCertificateQuery')
  - [Key](#P-Crypto-Web-Features-Queries-GetMessageWithCertificateQuery-Key 'Crypto.Web.Features.Queries.GetMessageWithCertificateQuery.Key')
- [ManageController](#T-Crypto-Web-Controllers-ManageController 'Crypto.Web.Controllers.ManageController')
  - [CreatePublicKey(cancellationToken)](#M-Crypto-Web-Controllers-ManageController-CreatePublicKey-System-Threading-CancellationToken- 'Crypto.Web.Controllers.ManageController.CreatePublicKey(System.Threading.CancellationToken)')
  - [MessageWithCertificate(query,cancellationToken)](#M-Crypto-Web-Controllers-ManageController-MessageWithCertificate-Crypto-Web-Features-Queries-GetMessageWithCertificateQuery,System-Threading-CancellationToken- 'Crypto.Web.Controllers.ManageController.MessageWithCertificate(Crypto.Web.Features.Queries.GetMessageWithCertificateQuery,System.Threading.CancellationToken)')
  - [SingMessage(command,cancellationToken)](#M-Crypto-Web-Controllers-ManageController-SingMessage-Crypto-Web-Features-Commands-SingMessageCommand,System-Threading-CancellationToken- 'Crypto.Web.Controllers.ManageController.SingMessage(Crypto.Web.Features.Commands.SingMessageCommand,System.Threading.CancellationToken)')
  - [VerifyMessage(command,cancellationToken)](#M-Crypto-Web-Controllers-ManageController-VerifyMessage-Crypto-Web-Features-Commands-VerifyMessageCommand,System-Threading-CancellationToken- 'Crypto.Web.Controllers.ManageController.VerifyMessage(Crypto.Web.Features.Commands.VerifyMessageCommand,System.Threading.CancellationToken)')
- [ServiceCollectionExtensions](#T-Crypto-Web-Extensions-ServiceCollectionExtensions 'Crypto.Web.Extensions.ServiceCollectionExtensions')
  - [AddFluentValidationSetup(services,type)](#M-Crypto-Web-Extensions-ServiceCollectionExtensions-AddFluentValidationSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Type- 'Crypto.Web.Extensions.ServiceCollectionExtensions.AddFluentValidationSetup(Microsoft.Extensions.DependencyInjection.IServiceCollection,System.Type)')
  - [AddSwaggerSetup(services)](#M-Crypto-Web-Extensions-ServiceCollectionExtensions-AddSwaggerSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Crypto.Web.Extensions.ServiceCollectionExtensions.AddSwaggerSetup(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [AddWebServices(services)](#M-Crypto-Web-Extensions-ServiceCollectionExtensions-AddWebServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Crypto.Web.Extensions.ServiceCollectionExtensions.AddWebServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [SingMessageCommand](#T-Crypto-Web-Features-Commands-SingMessageCommand 'Crypto.Web.Features.Commands.SingMessageCommand')
  - [OriginalMessage](#P-Crypto-Web-Features-Commands-SingMessageCommand-OriginalMessage 'Crypto.Web.Features.Commands.SingMessageCommand.OriginalMessage')
- [ValidateUsingFluentValidationAttribute](#T-Crypto-Web-DataAnnotations-ValidateUsingFluentValidationAttribute 'Crypto.Web.DataAnnotations.ValidateUsingFluentValidationAttribute')
  - [GetBadRequestResult(validationResult)](#M-Crypto-Web-DataAnnotations-ValidateUsingFluentValidationAttribute-GetBadRequestResult-FluentValidation-Results-ValidationResult- 'Crypto.Web.DataAnnotations.ValidateUsingFluentValidationAttribute.GetBadRequestResult(FluentValidation.Results.ValidationResult)')
  - [IsCustomType(type)](#M-Crypto-Web-DataAnnotations-ValidateUsingFluentValidationAttribute-IsCustomType-System-Type- 'Crypto.Web.DataAnnotations.ValidateUsingFluentValidationAttribute.IsCustomType(System.Type)')
  - [ToFluentModelState(validationResult)](#M-Crypto-Web-DataAnnotations-ValidateUsingFluentValidationAttribute-ToFluentModelState-FluentValidation-Results-ValidationResult- 'Crypto.Web.DataAnnotations.ValidateUsingFluentValidationAttribute.ToFluentModelState(FluentValidation.Results.ValidationResult)')
- [VerifyMessageCommand](#T-Crypto-Web-Features-Commands-VerifyMessageCommand 'Crypto.Web.Features.Commands.VerifyMessageCommand')
  - [VerifyMessage](#P-Crypto-Web-Features-Commands-VerifyMessageCommand-VerifyMessage 'Crypto.Web.Features.Commands.VerifyMessageCommand.VerifyMessage')
- [VerifyMessageDto](#T-Crypto-Web-Features-DtoModels-VerifyMessageDto 'Crypto.Web.Features.DtoModels.VerifyMessageDto')
  - [OriginalMessage](#P-Crypto-Web-Features-DtoModels-VerifyMessageDto-OriginalMessage 'Crypto.Web.Features.DtoModels.VerifyMessageDto.OriginalMessage')
  - [PublicKey](#P-Crypto-Web-Features-DtoModels-VerifyMessageDto-PublicKey 'Crypto.Web.Features.DtoModels.VerifyMessageDto.PublicKey')
  - [SignedMessage](#P-Crypto-Web-Features-DtoModels-VerifyMessageDto-SignedMessage 'Crypto.Web.Features.DtoModels.VerifyMessageDto.SignedMessage')

<a name='T-Crypto-Web-Extensions-Base64StringExtensions'></a>
## Base64StringExtensions `type`

##### Namespace

Crypto.Web.Extensions

##### Summary

Расширение для [Convert](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Convert 'System.Convert')

<a name='M-Crypto-Web-Extensions-Base64StringExtensions-DecodedSize-System-String-'></a>
### DecodedSize(base64) `method`

##### Summary

Возвращает размер декодированного Base64-представления строки

##### Returns

Размер декодированного массива байт

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| base64 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Строка в формате Base64 |

<a name='M-Crypto-Web-Extensions-Base64StringExtensions-TryFromBase64String-System-String,System-Byte[]@-'></a>
### TryFromBase64String(base64,content) `method`

##### Summary

Получает декодированную строку из Base64, если строка является допустимым представлением в формате Base64.

##### Returns

True, если строка является допустимым Base64-представлением и удалось успешно декодировать; в противном случае - False.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| base64 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Строка в формате Base64. |
| content | [System.Byte[]@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[]@ 'System.Byte[]@') | Декодированная строка, если строка является допустимым Base64-представлением; в противном случае - null. |

<a name='T-Crypto-Web-Features-Commands-CreatePublicKeyCommand'></a>
## CreatePublicKeyCommand `type`

##### Namespace

Crypto.Web.Features.Commands

##### Summary

Создание открытого ключа для пользователя

<a name='T-Crypto-Web-Middlewares-DtoModels-ErrorResponse'></a>
## ErrorResponse `type`

##### Namespace

Crypto.Web.Middlewares.DtoModels

##### Summary

Сообщение об ошибке

<a name='P-Crypto-Web-Middlewares-DtoModels-ErrorResponse-Code'></a>
### Code `property`

##### Summary

Код ошибки

<a name='P-Crypto-Web-Middlewares-DtoModels-ErrorResponse-Details'></a>
### Details `property`

##### Summary

Детали ошибки

<a name='P-Crypto-Web-Middlewares-DtoModels-ErrorResponse-Message'></a>
### Message `property`

##### Summary

Сообщение об ошибке

<a name='T-Crypto-Web-Middlewares-ExceptionMiddleware'></a>
## ExceptionMiddleware `type`

##### Namespace

Crypto.Web.Middlewares

##### Summary

Обработчик ошибок

<a name='M-Crypto-Web-Middlewares-ExceptionMiddleware-GetErrorResponse-Microsoft-AspNetCore-Http-HttpContext,System-Exception-'></a>
### GetErrorResponse(context,ex) `method`

##### Summary

Получить описание ошибки

##### Returns

Описание ошибки

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.AspNetCore.Http.HttpContext](#T-Microsoft-AspNetCore-Http-HttpContext 'Microsoft.AspNetCore.Http.HttpContext') | HttpContext |
| ex | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Ошибка |

<a name='T-Crypto-Web-DataAnnotations-DtoModels-FluentValidationModelState'></a>
## FluentValidationModelState `type`

##### Namespace

Crypto.Web.DataAnnotations.DtoModels

##### Summary

Описание ошибок

<a name='P-Crypto-Web-DataAnnotations-DtoModels-FluentValidationModelState-Errors'></a>
### Errors `property`

##### Summary

Ошибки валидации

<a name='T-Crypto-Web-Features-Queries-GetMessageWithCertificateQuery'></a>
## GetMessageWithCertificateQuery `type`

##### Namespace

Crypto.Web.Features.Queries

##### Summary

Подписать текст пользователю

<a name='P-Crypto-Web-Features-Queries-GetMessageWithCertificateQuery-Key'></a>
### Key `property`

##### Summary

Публичный ключ

<a name='T-Crypto-Web-Controllers-ManageController'></a>
## ManageController `type`

##### Namespace

Crypto.Web.Controllers

##### Summary

Работа с ЭЦП

<a name='M-Crypto-Web-Controllers-ManageController-CreatePublicKey-System-Threading-CancellationToken-'></a>
### CreatePublicKey(cancellationToken) `method`

##### Summary

Генерация открытого ключа для пользователя

##### Returns

Публичный ключ для пользователя

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

##### Remarks

Получаем и сохранение сообщение из стороннего api, возвращаем публичный ключ

<a name='M-Crypto-Web-Controllers-ManageController-MessageWithCertificate-Crypto-Web-Features-Queries-GetMessageWithCertificateQuery,System-Threading-CancellationToken-'></a>
### MessageWithCertificate(query,cancellationToken) `method`

##### Summary

Подписать текст пользователя

##### Returns

Подписанное сообщение пользователя

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| query | [Crypto.Web.Features.Queries.GetMessageWithCertificateQuery](#T-Crypto-Web-Features-Queries-GetMessageWithCertificateQuery 'Crypto.Web.Features.Queries.GetMessageWithCertificateQuery') | Dto параметр |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

##### Remarks

По публичному ключу находим полученное сообщение из сторонней api в памяти, подписываем его и возвращаем

<a name='M-Crypto-Web-Controllers-ManageController-SingMessage-Crypto-Web-Features-Commands-SingMessageCommand,System-Threading-CancellationToken-'></a>
### SingMessage(command,cancellationToken) `method`

##### Summary

Подписать сообщение пользователя

##### Returns

Подписанный текст пользователя

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [Crypto.Web.Features.Commands.SingMessageCommand](#T-Crypto-Web-Features-Commands-SingMessageCommand 'Crypto.Web.Features.Commands.SingMessageCommand') | Dto параметр |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

##### Remarks

Берем сообщение пользователя, подписываем его и возвращаем сертификат

<a name='M-Crypto-Web-Controllers-ManageController-VerifyMessage-Crypto-Web-Features-Commands-VerifyMessageCommand,System-Threading-CancellationToken-'></a>
### VerifyMessage(command,cancellationToken) `method`

##### Summary

Верификации сообщения

##### Returns

True - сообщение валидно

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [Crypto.Web.Features.Commands.VerifyMessageCommand](#T-Crypto-Web-Features-Commands-VerifyMessageCommand 'Crypto.Web.Features.Commands.VerifyMessageCommand') | Dto параметр |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-Crypto-Web-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

Crypto.Web.Extensions

##### Summary

Регистрация сервисов в DI

<a name='M-Crypto-Web-Extensions-ServiceCollectionExtensions-AddFluentValidationSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Type-'></a>
### AddFluentValidationSetup(services,type) `method`

##### Summary

Регистрация FluentValidation в DI

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Глобальный тип для поиска валидаторов |

<a name='M-Crypto-Web-Extensions-ServiceCollectionExtensions-AddSwaggerSetup-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddSwaggerSetup(services) `method`

##### Summary

Регистрация Swagger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |

<a name='M-Crypto-Web-Extensions-ServiceCollectionExtensions-AddWebServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddWebServices(services) `method`

##### Summary

Регистрация сервисов Web в DI

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |

<a name='T-Crypto-Web-Features-Commands-SingMessageCommand'></a>
## SingMessageCommand `type`

##### Namespace

Crypto.Web.Features.Commands

##### Summary

Подписать сообщение пользователя

<a name='P-Crypto-Web-Features-Commands-SingMessageCommand-OriginalMessage'></a>
### OriginalMessage `property`

##### Summary

Сообщение пользователя

<a name='T-Crypto-Web-DataAnnotations-ValidateUsingFluentValidationAttribute'></a>
## ValidateUsingFluentValidationAttribute `type`

##### Namespace

Crypto.Web.DataAnnotations

##### Summary

Настройка автоматической валидации входных параметров через FluentValidation

##### Remarks

Доступен для переопределения

<a name='M-Crypto-Web-DataAnnotations-ValidateUsingFluentValidationAttribute-GetBadRequestResult-FluentValidation-Results-ValidationResult-'></a>
### GetBadRequestResult(validationResult) `method`

##### Summary

Переопределение фильтров возвращаемых через BadRequestObjectResult

##### Returns

Объект, который используется в конструкторе

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| validationResult | [FluentValidation.Results.ValidationResult](#T-FluentValidation-Results-ValidationResult 'FluentValidation.Results.ValidationResult') | Результат валидации |

<a name='M-Crypto-Web-DataAnnotations-ValidateUsingFluentValidationAttribute-IsCustomType-System-Type-'></a>
### IsCustomType(type) `method`

##### Summary

Проверка является ли тип DTO

##### Returns

True - тип является DTO

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Тип модели |

<a name='M-Crypto-Web-DataAnnotations-ValidateUsingFluentValidationAttribute-ToFluentModelState-FluentValidation-Results-ValidationResult-'></a>
### ToFluentModelState(validationResult) `method`

##### Summary

Получить модуль с описанием ошибок

##### Returns

Описание ошибок

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| validationResult | [FluentValidation.Results.ValidationResult](#T-FluentValidation-Results-ValidationResult 'FluentValidation.Results.ValidationResult') | Результат валидации |

<a name='T-Crypto-Web-Features-Commands-VerifyMessageCommand'></a>
## VerifyMessageCommand `type`

##### Namespace

Crypto.Web.Features.Commands

##### Summary

Верификация сообщения

<a name='P-Crypto-Web-Features-Commands-VerifyMessageCommand-VerifyMessage'></a>
### VerifyMessage `property`

##### Summary

Сообщение

<a name='T-Crypto-Web-Features-DtoModels-VerifyMessageDto'></a>
## VerifyMessageDto `type`

##### Namespace

Crypto.Web.Features.DtoModels

##### Summary

Сообщение для верификации

<a name='P-Crypto-Web-Features-DtoModels-VerifyMessageDto-OriginalMessage'></a>
### OriginalMessage `property`

##### Summary

Сообщение

<a name='P-Crypto-Web-Features-DtoModels-VerifyMessageDto-PublicKey'></a>
### PublicKey `property`

##### Summary

Открытый ключ

<a name='P-Crypto-Web-Features-DtoModels-VerifyMessageDto-SignedMessage'></a>
### SignedMessage `property`

##### Summary

Подпись к сообщению
