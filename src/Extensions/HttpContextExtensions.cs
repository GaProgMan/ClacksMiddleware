using Microsoft.AspNetCore.Http;

namespace ClacksMiddleware.Extensions
{
    public static class HttpContextExtensions
    {
        public static bool ResponseContainsHeader(this HttpContext httpContext, string header)
        {
            return httpContext.Response.Headers.ContainsKey(header);
        }
    }
}