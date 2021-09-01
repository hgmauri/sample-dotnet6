using Microsoft.AspNetCore.Builder;
using Sample.DotNet6.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.DotNet6.Api.Core.Extensions
{
    public static class ServicesExtensions
    {
        public static void Setup(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IHelloService, HelloService>();
        }
    }
}
