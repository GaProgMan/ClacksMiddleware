using System.Threading.Tasks;
using ClacksMiddleware.Extensions;
using Microsoft.AspNetCore.Http;

namespace ClacksMiddleware
{
    /// <summary>
    /// Used to inject the (non-standard) GNU Terry Pratchett header into all
    /// HTTP requests.
    /// See: http://www.gnuterrypratchett.com/ for information on this
    /// non-standard header, and where it comes from.
    /// Ook
    /// </summary>
    public class GnuTerryPratchett
    {
        private readonly RequestDelegate _next;

        public GnuTerryPratchett(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (!httpContext.ResponseContainsHeader(Constants.XClacksOverheadHeaderName))
            {
                /* "A man is not dead while his name is still spoken." - Terry Pratchett, Going Postal */
                httpContext.Response.Headers.Add(Constants.XClacksOverheadHeaderName,
                    "GNU Terry Pratchett");
            }
            await _next.Invoke(httpContext);
        }
    }
}
