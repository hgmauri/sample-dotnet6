using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sample.DotNet6.Api.Core.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddLogging();
builder.Services.AddHttpClient();
builder.Services.AddCors();

builder.Setup();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Sample API .NET 6.0", Version = "v1" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api v1"));
}

app.UseCors(p =>
{
    p.AllowAnyOrigin();
    p.WithMethods("GET");
    p.AllowAnyHeader();
});

app.MapControllers();
app.Run();