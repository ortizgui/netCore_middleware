using Microsoft.AspNetCore.Builder;
using netCore_middlewares.Middleware;

namespace netCore_middlewares
{
    public class Configuration
    {
        public static IApplicationBuilder UseLogUrl(IApplicationBuilder app)  
        {  
            return app.UseMiddleware<LoggerMiddleware>();  
        }  
    }
}