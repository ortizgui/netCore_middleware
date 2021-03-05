using Microsoft.AspNetCore.Builder;

namespace netCore_middlewares.Middleware
{
    public static class LoggerMiddlewareExtension
    {
        public static IApplicationBuilder UseLogger(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<LoggerMiddleware>();
        }
    }
}