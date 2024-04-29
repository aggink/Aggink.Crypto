<a name='assembly'></a>
# Crypto.Web.Test

## Contents

- [ApplyRequestPortMiddleware](#T-Crypto-Web-Test-Tools-Middlewares-ApplyRequestPortMiddleware 'Crypto.Web.Test.Tools.Middlewares.ApplyRequestPortMiddleware')
- [CryptoWebTestControllersRefitIManageController](#T-Refit-Implementation-Generated-CryptoWebTestControllersRefitIManageController 'Refit.Implementation.Generated.CryptoWebTestControllersRefitIManageController')
  - [#ctor()](#M-Refit-Implementation-Generated-CryptoWebTestControllersRefitIManageController-#ctor-System-Net-Http-HttpClient,Refit-IRequestBuilder- 'Refit.Implementation.Generated.CryptoWebTestControllersRefitIManageController.#ctor(System.Net.Http.HttpClient,Refit.IRequestBuilder)')
  - [Client](#P-Refit-Implementation-Generated-CryptoWebTestControllersRefitIManageController-Client 'Refit.Implementation.Generated.CryptoWebTestControllersRefitIManageController.Client')
  - [CreatePublicKey()](#M-Refit-Implementation-Generated-CryptoWebTestControllersRefitIManageController-CreatePublicKey-Crypto-Web-Features-Commands-CreatePublicKeyCommand- 'Refit.Implementation.Generated.CryptoWebTestControllersRefitIManageController.CreatePublicKey(Crypto.Web.Features.Commands.CreatePublicKeyCommand)')
  - [Crypto#Web#Test#Controllers#Refit#IManageController#CreatePublicKey()](#M-Refit-Implementation-Generated-CryptoWebTestControllersRefitIManageController-Crypto#Web#Test#Controllers#Refit#IManageController#CreatePublicKey-Crypto-Web-Features-Commands-CreatePublicKeyCommand- 'Refit.Implementation.Generated.CryptoWebTestControllersRefitIManageController.Crypto#Web#Test#Controllers#Refit#IManageController#CreatePublicKey(Crypto.Web.Features.Commands.CreatePublicKeyCommand)')
  - [Crypto#Web#Test#Controllers#Refit#IManageController#MessageWithCertificate()](#M-Refit-Implementation-Generated-CryptoWebTestControllersRefitIManageController-Crypto#Web#Test#Controllers#Refit#IManageController#MessageWithCertificate-System-String- 'Refit.Implementation.Generated.CryptoWebTestControllersRefitIManageController.Crypto#Web#Test#Controllers#Refit#IManageController#MessageWithCertificate(System.String)')
  - [Crypto#Web#Test#Controllers#Refit#IManageController#VerifyMessage()](#M-Refit-Implementation-Generated-CryptoWebTestControllersRefitIManageController-Crypto#Web#Test#Controllers#Refit#IManageController#VerifyMessage-Crypto-Web-Features-DtoModels-VerifyMessageDto- 'Refit.Implementation.Generated.CryptoWebTestControllersRefitIManageController.Crypto#Web#Test#Controllers#Refit#IManageController#VerifyMessage(Crypto.Web.Features.DtoModels.VerifyMessageDto)')
  - [MessageWithCertificate()](#M-Refit-Implementation-Generated-CryptoWebTestControllersRefitIManageController-MessageWithCertificate-System-String- 'Refit.Implementation.Generated.CryptoWebTestControllersRefitIManageController.MessageWithCertificate(System.String)')
  - [VerifyMessage()](#M-Refit-Implementation-Generated-CryptoWebTestControllersRefitIManageController-VerifyMessage-Crypto-Web-Features-DtoModels-VerifyMessageDto- 'Refit.Implementation.Generated.CryptoWebTestControllersRefitIManageController.VerifyMessage(Crypto.Web.Features.DtoModels.VerifyMessageDto)')
- [Generated](#T-Refit-Implementation-Generated 'Refit.Implementation.Generated')
- [IManageController](#T-Crypto-Web-Test-Controllers-Refit-IManageController 'Crypto.Web.Test.Controllers.Refit.IManageController')
  - [CreatePublicKey(command)](#M-Crypto-Web-Test-Controllers-Refit-IManageController-CreatePublicKey-Crypto-Web-Features-Commands-CreatePublicKeyCommand- 'Crypto.Web.Test.Controllers.Refit.IManageController.CreatePublicKey(Crypto.Web.Features.Commands.CreatePublicKeyCommand)')
  - [MessageWithCertificate(Key)](#M-Crypto-Web-Test-Controllers-Refit-IManageController-MessageWithCertificate-System-String- 'Crypto.Web.Test.Controllers.Refit.IManageController.MessageWithCertificate(System.String)')
  - [VerifyMessage(VerifyMessage)](#M-Crypto-Web-Test-Controllers-Refit-IManageController-VerifyMessage-Crypto-Web-Features-DtoModels-VerifyMessageDto- 'Crypto.Web.Test.Controllers.Refit.IManageController.VerifyMessage(Crypto.Web.Features.DtoModels.VerifyMessageDto)')
- [ManageControllerTests](#T-Crypto-Web-Test-Controllers-ManageControllerTests 'Crypto.Web.Test.Controllers.ManageControllerTests')
  - [FullСycleTest(changeOrigMessage,changePublicKey,changeSignedContent,result)](#M-Crypto-Web-Test-Controllers-ManageControllerTests-FullСycleTest-System-Boolean,System-Boolean,System-Boolean,System-Boolean- 'Crypto.Web.Test.Controllers.ManageControllerTests.FullСycleTest(System.Boolean,System.Boolean,System.Boolean,System.Boolean)')
  - [VerifyMessageTest(originalMessage,originalMessageTest,result)](#M-Crypto-Web-Test-Controllers-ManageControllerTests-VerifyMessageTest-System-String,System-String,System-Boolean- 'Crypto.Web.Test.Controllers.ManageControllerTests.VerifyMessageTest(System.String,System.String,System.Boolean)')
- [SetUpTests](#T-Crypto-Web-Test-Tools-SetUpTests 'Crypto.Web.Test.Tools.SetUpTests')
  - [SetUp()](#M-Crypto-Web-Test-Tools-SetUpTests-SetUp 'Crypto.Web.Test.Tools.SetUpTests.SetUp')
  - [TearDown()](#M-Crypto-Web-Test-Tools-SetUpTests-TearDown 'Crypto.Web.Test.Tools.SetUpTests.TearDown')
- [StartupFilter](#T-Crypto-Web-Test-Tools-Filters-StartupFilter 'Crypto.Web.Test.Tools.Filters.StartupFilter')
- [TestWebApplicationFactory](#T-Crypto-Web-Test-Tools-TestWebApplicationFactory 'Crypto.Web.Test.Tools.TestWebApplicationFactory')
  - [CreateApiClient()](#M-Crypto-Web-Test-Tools-TestWebApplicationFactory-CreateApiClient 'Crypto.Web.Test.Tools.TestWebApplicationFactory.CreateApiClient')
- [TestWebApplicationFactoryExtensions](#T-Crypto-Web-Test-Tools-Extensions-TestWebApplicationFactoryExtensions 'Crypto.Web.Test.Tools.Extensions.TestWebApplicationFactoryExtensions')
  - [CreateApi\`\`1(factory)](#M-Crypto-Web-Test-Tools-Extensions-TestWebApplicationFactoryExtensions-CreateApi``1-Crypto-Web-Test-Tools-TestWebApplicationFactory- 'Crypto.Web.Test.Tools.Extensions.TestWebApplicationFactoryExtensions.CreateApi``1(Crypto.Web.Test.Tools.TestWebApplicationFactory)')

<a name='T-Crypto-Web-Test-Tools-Middlewares-ApplyRequestPortMiddleware'></a>
## ApplyRequestPortMiddleware `type`

##### Namespace

Crypto.Web.Test.Tools.Middlewares

##### Summary

Настройка локального порта

<a name='T-Refit-Implementation-Generated-CryptoWebTestControllersRefitIManageController'></a>
## CryptoWebTestControllersRefitIManageController `type`

##### Namespace

Refit.Implementation.Generated

##### Summary

*Inherit from parent.*

<a name='M-Refit-Implementation-Generated-CryptoWebTestControllersRefitIManageController-#ctor-System-Net-Http-HttpClient,Refit-IRequestBuilder-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='P-Refit-Implementation-Generated-CryptoWebTestControllersRefitIManageController-Client'></a>
### Client `property`

##### Summary

*Inherit from parent.*

<a name='M-Refit-Implementation-Generated-CryptoWebTestControllersRefitIManageController-CreatePublicKey-Crypto-Web-Features-Commands-CreatePublicKeyCommand-'></a>
### CreatePublicKey() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Refit-Implementation-Generated-CryptoWebTestControllersRefitIManageController-Crypto#Web#Test#Controllers#Refit#IManageController#CreatePublicKey-Crypto-Web-Features-Commands-CreatePublicKeyCommand-'></a>
### Crypto#Web#Test#Controllers#Refit#IManageController#CreatePublicKey() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Refit-Implementation-Generated-CryptoWebTestControllersRefitIManageController-Crypto#Web#Test#Controllers#Refit#IManageController#MessageWithCertificate-System-String-'></a>
### Crypto#Web#Test#Controllers#Refit#IManageController#MessageWithCertificate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Refit-Implementation-Generated-CryptoWebTestControllersRefitIManageController-Crypto#Web#Test#Controllers#Refit#IManageController#VerifyMessage-Crypto-Web-Features-DtoModels-VerifyMessageDto-'></a>
### Crypto#Web#Test#Controllers#Refit#IManageController#VerifyMessage() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Refit-Implementation-Generated-CryptoWebTestControllersRefitIManageController-MessageWithCertificate-System-String-'></a>
### MessageWithCertificate() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Refit-Implementation-Generated-CryptoWebTestControllersRefitIManageController-VerifyMessage-Crypto-Web-Features-DtoModels-VerifyMessageDto-'></a>
### VerifyMessage() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Refit-Implementation-Generated'></a>
## Generated `type`

##### Namespace

Refit.Implementation

##### Summary

*Inherit from parent.*

<a name='T-Crypto-Web-Test-Controllers-Refit-IManageController'></a>
## IManageController `type`

##### Namespace

Crypto.Web.Test.Controllers.Refit

##### Summary

Запросы к API приложения

<a name='M-Crypto-Web-Test-Controllers-Refit-IManageController-CreatePublicKey-Crypto-Web-Features-Commands-CreatePublicKeyCommand-'></a>
### CreatePublicKey(command) `method`

##### Summary

Создать публичный ключ

##### Returns

Публичный ключ

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| command | [Crypto.Web.Features.Commands.CreatePublicKeyCommand](#T-Crypto-Web-Features-Commands-CreatePublicKeyCommand 'Crypto.Web.Features.Commands.CreatePublicKeyCommand') | Генерация открытого ключа для пользователя |

<a name='M-Crypto-Web-Test-Controllers-Refit-IManageController-MessageWithCertificate-System-String-'></a>
### MessageWithCertificate(Key) `method`

##### Summary

Получить сертификат

##### Returns

Сертификат

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Публичный ключ |

<a name='M-Crypto-Web-Test-Controllers-Refit-IManageController-VerifyMessage-Crypto-Web-Features-DtoModels-VerifyMessageDto-'></a>
### VerifyMessage(VerifyMessage) `method`

##### Summary

Проверка сообщения

##### Returns

True - валидация прошла успешно

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| VerifyMessage | [Crypto.Web.Features.DtoModels.VerifyMessageDto](#T-Crypto-Web-Features-DtoModels-VerifyMessageDto 'Crypto.Web.Features.DtoModels.VerifyMessageDto') | Сообщение для верификации |

<a name='T-Crypto-Web-Test-Controllers-ManageControllerTests'></a>
## ManageControllerTests `type`

##### Namespace

Crypto.Web.Test.Controllers

##### Summary

Проверка API

<a name='M-Crypto-Web-Test-Controllers-ManageControllerTests-FullСycleTest-System-Boolean,System-Boolean,System-Boolean,System-Boolean-'></a>
### FullСycleTest(changeOrigMessage,changePublicKey,changeSignedContent,result) `method`

##### Summary

Тестовый метод целого цикла: получения ключа, получения подписанного сообщения, проверка подписанного сообщения

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| changeOrigMessage | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Заменить оригинальное сообщение |
| changePublicKey | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Заменить публичный ключ |
| changeSignedContent | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Замесить подпись |
| result | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Результат |

<a name='M-Crypto-Web-Test-Controllers-ManageControllerTests-VerifyMessageTest-System-String,System-String,System-Boolean-'></a>
### VerifyMessageTest(originalMessage,originalMessageTest,result) `method`

##### Summary

Тестовый метод проверки подписи сообщения

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| originalMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Оригинальное сообщение |
| originalMessageTest | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Оригинальное тестовое сообщение |
| result | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | True - тестовые сообщения одинаковы |

<a name='T-Crypto-Web-Test-Tools-SetUpTests'></a>
## SetUpTests `type`

##### Namespace

Crypto.Web.Test.Tools

##### Summary

Базовый шаблон тестового класса

<a name='M-Crypto-Web-Test-Tools-SetUpTests-SetUp'></a>
### SetUp() `method`

##### Summary

Настройка тестового класса

##### Parameters

This method has no parameters.

<a name='M-Crypto-Web-Test-Tools-SetUpTests-TearDown'></a>
### TearDown() `method`

##### Summary

Очистка после прогона тестов

##### Parameters

This method has no parameters.

<a name='T-Crypto-Web-Test-Tools-Filters-StartupFilter'></a>
## StartupFilter `type`

##### Namespace

Crypto.Web.Test.Tools.Filters

##### Summary

Расширение конвейера ПО промежуточного слоя с помощью новых методов Configure

<a name='T-Crypto-Web-Test-Tools-TestWebApplicationFactory'></a>
## TestWebApplicationFactory `type`

##### Namespace

Crypto.Web.Test.Tools

##### Summary

Фабрика для загрузки приложения в память для сквозных функциональных тестов

<a name='M-Crypto-Web-Test-Tools-TestWebApplicationFactory-CreateApiClient'></a>
### CreateApiClient() `method`

##### Summary

Создание клиента для перенаправления запросов к приложению

##### Returns

Клиент для перенаправления запросов к приложению

##### Parameters

This method has no parameters.

<a name='T-Crypto-Web-Test-Tools-Extensions-TestWebApplicationFactoryExtensions'></a>
## TestWebApplicationFactoryExtensions `type`

##### Namespace

Crypto.Web.Test.Tools.Extensions

##### Summary

Получение объектов для запросов к API

<a name='M-Crypto-Web-Test-Tools-Extensions-TestWebApplicationFactoryExtensions-CreateApi``1-Crypto-Web-Test-Tools-TestWebApplicationFactory-'></a>
### CreateApi\`\`1(factory) `method`

##### Summary

Получить объект для запросов к API

##### Returns

Интерфейса для запросов к API

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| factory | [Crypto.Web.Test.Tools.TestWebApplicationFactory](#T-Crypto-Web-Test-Tools-TestWebApplicationFactory 'Crypto.Web.Test.Tools.TestWebApplicationFactory') | Фабрика для загрузки приложения в память для сквозных функциональных тестов |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Тип интерфейса для запросов к API |
