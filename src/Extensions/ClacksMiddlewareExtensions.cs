using Microsoft.AspNetCore.Builder;

namespace ClacksMiddleware.Extensions
{
    /// <summary>
    /// Extension methods to allow us to easily build the middleware
    /// </summary>
    public static class ClacksMiddlewareExtensions
    {
        /// <summary>
        /// Extention method to include the <see cref="ClacksMiddlewareExtensions" /> in
        /// an instance of an <see cref="IApplicationBuilder" />.
        /// This works in the same way was the MVC, Static files, etc. middleware
        /// </summary>
        /// <param name="builder">
        /// The instance of the <see cref="IApplicationBuilder" /> to use
        /// </param>
        /// <returns>
        /// The <see cref="IApplicationBuilder"/> with the <see cref="ClacksMiddlewareExtensions" />
        /// added
        /// </returns>
        public static IApplicationBuilder GnuTerryPratchett(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<GnuTerryPratchett>();
        }
    }
}