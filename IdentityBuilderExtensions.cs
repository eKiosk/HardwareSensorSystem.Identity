using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Builder
{
    public static class IdentityBuilderExtensions
    {
        public static void AddHssIdentity(this IServiceCollection services)
        {

        }

        public static IApplicationBuilder UseHssIdentity(this IApplicationBuilder app)
        {
            return app.UseIdentity()
                      .UseOAuthValidation()
                      .UseOpenIddict();
        }
    }
}
