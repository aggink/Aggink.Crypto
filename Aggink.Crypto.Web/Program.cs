using Aggink.Crypto.Web.Extensions;
using Aggink.Crypto.Web.Middlewares;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo() { Title = "Crypto", Version = "v1" });
    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());

    foreach (FileInfo file in new DirectoryInfo(AppContext.BaseDirectory).GetFiles(
                 Assembly.GetExecutingAssembly().GetName().Name! + ".xml"))
        c.IncludeXmlComments(file.FullName);

    c.EnableAnnotations(enableAnnotationsForInheritance: true,
        enableAnnotationsForPolymorphism: true
    );
});

builder.Services.AddWebServices();

var app = builder.Build();

app.UseHttpLogging();

app.UseHttpsRedirection();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Crypto");

        options.EnableDeepLinking();
    });
}

app.UseMiddleware<ExceptionMiddleware>();

app.UseRouting();

app.MapControllers();

app.Run();
