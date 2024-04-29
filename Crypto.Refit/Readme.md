<a name='assembly'></a>
# Crypto.Refit

## Contents

- [CryptoRefitRefitsIApiSpacexdataHistory](#T-Refit-Implementation-Generated-CryptoRefitRefitsIApiSpacexdataHistory 'Refit.Implementation.Generated.CryptoRefitRefitsIApiSpacexdataHistory')
  - [#ctor()](#M-Refit-Implementation-Generated-CryptoRefitRefitsIApiSpacexdataHistory-#ctor-System-Net-Http-HttpClient,Refit-IRequestBuilder- 'Refit.Implementation.Generated.CryptoRefitRefitsIApiSpacexdataHistory.#ctor(System.Net.Http.HttpClient,Refit.IRequestBuilder)')
  - [Client](#P-Refit-Implementation-Generated-CryptoRefitRefitsIApiSpacexdataHistory-Client 'Refit.Implementation.Generated.CryptoRefitRefitsIApiSpacexdataHistory.Client')
  - [Crypto#Refit#Refits#IApiSpacexdataHistory#GetAllHistoricalEvents()](#M-Refit-Implementation-Generated-CryptoRefitRefitsIApiSpacexdataHistory-Crypto#Refit#Refits#IApiSpacexdataHistory#GetAllHistoricalEvents-System-Threading-CancellationToken- 'Refit.Implementation.Generated.CryptoRefitRefitsIApiSpacexdataHistory.Crypto#Refit#Refits#IApiSpacexdataHistory#GetAllHistoricalEvents(System.Threading.CancellationToken)')
  - [Crypto#Refit#Refits#IApiSpacexdataHistory#GetOneHistoricalEvents()](#M-Refit-Implementation-Generated-CryptoRefitRefitsIApiSpacexdataHistory-Crypto#Refit#Refits#IApiSpacexdataHistory#GetOneHistoricalEvents-System-Int32,System-Threading-CancellationToken- 'Refit.Implementation.Generated.CryptoRefitRefitsIApiSpacexdataHistory.Crypto#Refit#Refits#IApiSpacexdataHistory#GetOneHistoricalEvents(System.Int32,System.Threading.CancellationToken)')
  - [GetAllHistoricalEvents()](#M-Refit-Implementation-Generated-CryptoRefitRefitsIApiSpacexdataHistory-GetAllHistoricalEvents-System-Threading-CancellationToken- 'Refit.Implementation.Generated.CryptoRefitRefitsIApiSpacexdataHistory.GetAllHistoricalEvents(System.Threading.CancellationToken)')
  - [GetOneHistoricalEvents()](#M-Refit-Implementation-Generated-CryptoRefitRefitsIApiSpacexdataHistory-GetOneHistoricalEvents-System-Int32,System-Threading-CancellationToken- 'Refit.Implementation.Generated.CryptoRefitRefitsIApiSpacexdataHistory.GetOneHistoricalEvents(System.Int32,System.Threading.CancellationToken)')
- [GenerateTestDataClientService](#T-Crypto-Refit-Services-GenerateTestDataClientService 'Crypto.Refit.Services.GenerateTestDataClientService')
- [Generated](#T-Refit-Implementation-Generated 'Refit.Implementation.Generated')
- [HistoricalEvent](#T-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEvent 'Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History.HistoricalEvent')
  - [Details](#P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEvent-Details 'Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History.HistoricalEvent.Details')
  - [EventDateUnix](#P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEvent-EventDateUnix 'Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History.HistoricalEvent.EventDateUnix')
  - [EventDateUtc](#P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEvent-EventDateUtc 'Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History.HistoricalEvent.EventDateUtc')
  - [FlightNumber](#P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEvent-FlightNumber 'Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History.HistoricalEvent.FlightNumber')
  - [Id](#P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEvent-Id 'Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History.HistoricalEvent.Id')
  - [Links](#P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEvent-Links 'Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History.HistoricalEvent.Links')
  - [Title](#P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEvent-Title 'Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History.HistoricalEvent.Title')
- [HistoricalEventLink](#T-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEventLink 'Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History.HistoricalEventLink')
  - [Article](#P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEventLink-Article 'Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History.HistoricalEventLink.Article')
  - [Reddit](#P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEventLink-Reddit 'Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History.HistoricalEventLink.Reddit')
  - [Wikipedia](#P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEventLink-Wikipedia 'Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History.HistoricalEventLink.Wikipedia')
- [IApiSpacexdataHistory](#T-Crypto-Refit-Refits-IApiSpacexdataHistory 'Crypto.Refit.Refits.IApiSpacexdataHistory')
  - [GetAllHistoricalEvents(cancellationToken)](#M-Crypto-Refit-Refits-IApiSpacexdataHistory-GetAllHistoricalEvents-System-Threading-CancellationToken- 'Crypto.Refit.Refits.IApiSpacexdataHistory.GetAllHistoricalEvents(System.Threading.CancellationToken)')
  - [GetOneHistoricalEvents(id,cancellationToken)](#M-Crypto-Refit-Refits-IApiSpacexdataHistory-GetOneHistoricalEvents-System-Int32,System-Threading-CancellationToken- 'Crypto.Refit.Refits.IApiSpacexdataHistory.GetOneHistoricalEvents(System.Int32,System.Threading.CancellationToken)')
- [IGenerateTestDataClientService](#T-Crypto-Refit-Interfaces-IGenerateTestDataClientService 'Crypto.Refit.Interfaces.IGenerateTestDataClientService')
  - [GetAllHistoricalEventsAsync(cancellationToken)](#M-Crypto-Refit-Interfaces-IGenerateTestDataClientService-GetAllHistoricalEventsAsync-System-Threading-CancellationToken- 'Crypto.Refit.Interfaces.IGenerateTestDataClientService.GetAllHistoricalEventsAsync(System.Threading.CancellationToken)')
  - [GetOneHistoricalEventAsync(id,cancellationToken)](#M-Crypto-Refit-Interfaces-IGenerateTestDataClientService-GetOneHistoricalEventAsync-System-Int32,System-Threading-CancellationToken- 'Crypto.Refit.Interfaces.IGenerateTestDataClientService.GetOneHistoricalEventAsync(System.Int32,System.Threading.CancellationToken)')
  - [GetRandomTitleHistoricalEventAsync(cancellationToken)](#M-Crypto-Refit-Interfaces-IGenerateTestDataClientService-GetRandomTitleHistoricalEventAsync-System-Threading-CancellationToken- 'Crypto.Refit.Interfaces.IGenerateTestDataClientService.GetRandomTitleHistoricalEventAsync(System.Threading.CancellationToken)')
- [RefitException](#T-Crypto-Refit-Exceptions-RefitException 'Crypto.Refit.Exceptions.RefitException')
- [RefitExtensions](#T-Crypto-Refit-Extensions-RefitExtensions 'Crypto.Refit.Extensions.RefitExtensions')
  - [GetRequestMessage\`\`1(response)](#M-Crypto-Refit-Extensions-RefitExtensions-GetRequestMessage``1-Refit-IApiResponse{``0}- 'Crypto.Refit.Extensions.RefitExtensions.GetRequestMessage``1(Refit.IApiResponse{``0})')
  - [GetResponseMessage\`\`1(response)](#M-Crypto-Refit-Extensions-RefitExtensions-GetResponseMessage``1-Refit-IApiResponse{``0}- 'Crypto.Refit.Extensions.RefitExtensions.GetResponseMessage``1(Refit.IApiResponse{``0})')
  - [RefitResponseValidate\`\`1(response,logger,checkContent)](#M-Crypto-Refit-Extensions-RefitExtensions-RefitResponseValidate``1-Refit-IApiResponse{``0},Microsoft-Extensions-Logging-ILogger,System-Boolean- 'Crypto.Refit.Extensions.RefitExtensions.RefitResponseValidate``1(Refit.IApiResponse{``0},Microsoft.Extensions.Logging.ILogger,System.Boolean)')
- [ServiceCollectionExtensions](#T-Crypto-Refit-Extensions-ServiceCollectionExtensions 'Crypto.Refit.Extensions.ServiceCollectionExtensions')
  - [AddApiRefitServices(services)](#M-Crypto-Refit-Extensions-ServiceCollectionExtensions-AddApiRefitServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Crypto.Refit.Extensions.ServiceCollectionExtensions.AddApiRefitServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [AddRefitServices(services)](#M-Crypto-Refit-Extensions-ServiceCollectionExtensions-AddRefitServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Crypto.Refit.Extensions.ServiceCollectionExtensions.AddRefitServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')

<a name='T-Refit-Implementation-Generated-CryptoRefitRefitsIApiSpacexdataHistory'></a>
## CryptoRefitRefitsIApiSpacexdataHistory `type`

##### Namespace

Refit.Implementation.Generated

##### Summary

*Inherit from parent.*

<a name='M-Refit-Implementation-Generated-CryptoRefitRefitsIApiSpacexdataHistory-#ctor-System-Net-Http-HttpClient,Refit-IRequestBuilder-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='P-Refit-Implementation-Generated-CryptoRefitRefitsIApiSpacexdataHistory-Client'></a>
### Client `property`

##### Summary

*Inherit from parent.*

<a name='M-Refit-Implementation-Generated-CryptoRefitRefitsIApiSpacexdataHistory-Crypto#Refit#Refits#IApiSpacexdataHistory#GetAllHistoricalEvents-System-Threading-CancellationToken-'></a>
### Crypto#Refit#Refits#IApiSpacexdataHistory#GetAllHistoricalEvents() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Refit-Implementation-Generated-CryptoRefitRefitsIApiSpacexdataHistory-Crypto#Refit#Refits#IApiSpacexdataHistory#GetOneHistoricalEvents-System-Int32,System-Threading-CancellationToken-'></a>
### Crypto#Refit#Refits#IApiSpacexdataHistory#GetOneHistoricalEvents() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Refit-Implementation-Generated-CryptoRefitRefitsIApiSpacexdataHistory-GetAllHistoricalEvents-System-Threading-CancellationToken-'></a>
### GetAllHistoricalEvents() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Refit-Implementation-Generated-CryptoRefitRefitsIApiSpacexdataHistory-GetOneHistoricalEvents-System-Int32,System-Threading-CancellationToken-'></a>
### GetOneHistoricalEvents() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Crypto-Refit-Services-GenerateTestDataClientService'></a>
## GenerateTestDataClientService `type`

##### Namespace

Crypto.Refit.Services

##### Summary

Сервис запросов данных к API об исторических справках

<a name='T-Refit-Implementation-Generated'></a>
## Generated `type`

##### Namespace

Refit.Implementation

##### Summary

*Inherit from parent.*

<a name='T-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEvent'></a>
## HistoricalEvent `type`

##### Namespace

Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History

##### Summary

Историческое событие

<a name='P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEvent-Details'></a>
### Details `property`

##### Summary

Описание

<a name='P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEvent-EventDateUnix'></a>
### EventDateUnix `property`

##### Summary

Дата события

<a name='P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEvent-EventDateUtc'></a>
### EventDateUtc `property`

##### Summary

Дата события

<a name='P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEvent-FlightNumber'></a>
### FlightNumber `property`

##### Summary

Номер

<a name='P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEvent-Id'></a>
### Id `property`

##### Summary

Идентификатор

<a name='P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEvent-Links'></a>
### Links `property`

##### Summary

Ссылки на статьи о событии

<a name='P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEvent-Title'></a>
### Title `property`

##### Summary

Название события

<a name='T-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEventLink'></a>
## HistoricalEventLink `type`

##### Namespace

Crypto.Refit.Refits.DtoModels.ApiSpacexdata.History

##### Summary

Ссылки на статьи о событии

<a name='P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEventLink-Article'></a>
### Article `property`

##### Summary

Ссылка на Article

<a name='P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEventLink-Reddit'></a>
### Reddit `property`

##### Summary

Ссылка на Reddit

<a name='P-Crypto-Refit-Refits-DtoModels-ApiSpacexdata-History-HistoricalEventLink-Wikipedia'></a>
### Wikipedia `property`

##### Summary

Ссылка на Wikipedia

<a name='T-Crypto-Refit-Refits-IApiSpacexdataHistory'></a>
## IApiSpacexdataHistory `type`

##### Namespace

Crypto.Refit.Refits

##### Summary

Запросы к API

<a name='M-Crypto-Refit-Refits-IApiSpacexdataHistory-GetAllHistoricalEvents-System-Threading-CancellationToken-'></a>
### GetAllHistoricalEvents(cancellationToken) `method`

##### Summary

Получить информацию о всех событиях

##### Returns

Информация о всех событиях

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-Crypto-Refit-Refits-IApiSpacexdataHistory-GetOneHistoricalEvents-System-Int32,System-Threading-CancellationToken-'></a>
### GetOneHistoricalEvents(id,cancellationToken) `method`

##### Summary

Получить информацию о событии

##### Returns

Информация о событии

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Идентификатор события |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-Crypto-Refit-Interfaces-IGenerateTestDataClientService'></a>
## IGenerateTestDataClientService `type`

##### Namespace

Crypto.Refit.Interfaces

##### Summary

Интерфейс получения данных с API

<a name='M-Crypto-Refit-Interfaces-IGenerateTestDataClientService-GetAllHistoricalEventsAsync-System-Threading-CancellationToken-'></a>
### GetAllHistoricalEventsAsync(cancellationToken) `method`

##### Summary

Получить истории о всех событиях

##### Returns

Истории о всех событиях

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-Crypto-Refit-Interfaces-IGenerateTestDataClientService-GetOneHistoricalEventAsync-System-Int32,System-Threading-CancellationToken-'></a>
### GetOneHistoricalEventAsync(id,cancellationToken) `method`

##### Summary

Получить историю о событии

##### Returns

История о событии

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Идентификатор события |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='M-Crypto-Refit-Interfaces-IGenerateTestDataClientService-GetRandomTitleHistoricalEventAsync-System-Threading-CancellationToken-'></a>
### GetRandomTitleHistoricalEventAsync(cancellationToken) `method`

##### Summary

Получить рандомную историю о событии

##### Returns

История о событии

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cancellationToken | [System.Threading.CancellationToken](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.CancellationToken 'System.Threading.CancellationToken') | Токен отмены |

<a name='T-Crypto-Refit-Exceptions-RefitException'></a>
## RefitException `type`

##### Namespace

Crypto.Refit.Exceptions

##### Summary

Ошибка выброшенная разработчиком

<a name='T-Crypto-Refit-Extensions-RefitExtensions'></a>
## RefitExtensions `type`

##### Namespace

Crypto.Refit.Extensions

<a name='M-Crypto-Refit-Extensions-RefitExtensions-GetRequestMessage``1-Refit-IApiResponse{``0}-'></a>
### GetRequestMessage\`\`1(response) `method`

##### Summary

Получить описание запроса

##### Returns

Описание запроса

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| response | [Refit.IApiResponse{\`\`0}](#T-Refit-IApiResponse{``0} 'Refit.IApiResponse{``0}') | Ответ от сервера |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Тип ответа |

<a name='M-Crypto-Refit-Extensions-RefitExtensions-GetResponseMessage``1-Refit-IApiResponse{``0}-'></a>
### GetResponseMessage\`\`1(response) `method`

##### Summary

Получить описание ответа

##### Returns

Описание ответа

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| response | [Refit.IApiResponse{\`\`0}](#T-Refit-IApiResponse{``0} 'Refit.IApiResponse{``0}') | Ответ от сервера |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Тип ответа |

<a name='M-Crypto-Refit-Extensions-RefitExtensions-RefitResponseValidate``1-Refit-IApiResponse{``0},Microsoft-Extensions-Logging-ILogger,System-Boolean-'></a>
### RefitResponseValidate\`\`1(response,logger,checkContent) `method`

##### Summary

Проверка ответа сервера

##### Returns

True - проверка завершилась успешно

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| response | [Refit.IApiResponse{\`\`0}](#T-Refit-IApiResponse{``0} 'Refit.IApiResponse{``0}') | Ответ |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') | Журнал логирования |
| checkContent | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Проверить наличие контента |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Crypto.Refit.Exceptions.RefitException](#T-Crypto-Refit-Exceptions-RefitException 'Crypto.Refit.Exceptions.RefitException') | В ходе выполнения запроса произошла ошибка |

<a name='T-Crypto-Refit-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

Crypto.Refit.Extensions

##### Summary

Регистрация сервисов в DI

<a name='M-Crypto-Refit-Extensions-ServiceCollectionExtensions-AddApiRefitServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddApiRefitServices(services) `method`

##### Summary

Регистрация обработчика API - Refit

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |

<a name='M-Crypto-Refit-Extensions-ServiceCollectionExtensions-AddRefitServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### AddRefitServices(services) `method`

##### Summary

Регистрация сервисов библиотеки Refit

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | Коллекция дескрипторов служб |
