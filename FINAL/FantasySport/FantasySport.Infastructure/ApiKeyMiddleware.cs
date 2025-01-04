using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace FantasySport.Infastructure
{
    public class ApiKeyMiddleware
    {
        private readonly RequestDelegate _next;
        private const string ApiKeyHeaderName = "X-Api-Key";
        private readonly IConfiguration _configuration;

        public ApiKeyMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var path = context.Request.Path.Value;

            // Исключение для Swagger
            if (path != null && (path.StartsWith("/swagger") || path.StartsWith("/favicon.ico")))
            {
                await _next(context);
                return;
            }

            if (!context.Request.Headers.TryGetValue(ApiKeyHeaderName, out var extractedApiKey))
            {
                context.Response.StatusCode = 401; // Unauthorized
                await context.Response.WriteAsync("API Key was not provided.");
                return;
            }

            var configuredApiKey = _configuration.GetSection("ApiKey").Value;
            if (string.IsNullOrEmpty(configuredApiKey) || !string.Equals(extractedApiKey, configuredApiKey, StringComparison.Ordinal))
            {
                context.Response.StatusCode = 401; // Unauthorized
                await context.Response.WriteAsync("Unauthorized client.");
                return;
            }

            await _next(context);
        }
    }
}
