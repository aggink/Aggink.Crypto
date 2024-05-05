# Электронно-цифровая подпись сообщений

### Реализовано программное решение, позволяющее выполнить следующие сценарии: 

Сценарий 1:
1.	Клиент подписывает сообщение.
2.	Клиент обращается к серверу и передает ему подписанное сообщение. 
3.	Клиент проверяет статус верификации, возвращенный ему сервером.

Сценарий 2:
1.	Клиент запрашивает публичный ключ сервера.
2.	Клиент запрашивает генерацию случайного сообщения на сервере.
3.	Клиент осуществляет верификацию полученного сообщения.

Для ЭЦП следует использовать RSA + SHA256.

### Используемые библиотеки:
- AutoFixture
- coverlet.collector
- FluentValidation.AspNetCore
- MediatR
- Microsoft.AspNetCore.Mvc.Testing
- Microsoft.Extensions.DependencyInjection.Abstractions
- Microsoft.Extensions.Logging
- Microsoft.NET.Test.Sdk
- NUnit
- NUnit.Analyzers
- NUnit3TestAdapter
- Refit.HttpClientFactory
- Serilog.AspNetCore
- Swashbuckle.AspNetCore
- Swashbuckle.AspNetCore.Annotations
- Vsxmd
