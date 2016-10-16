using HardwareSensorSystem.Identity.Models;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Microsoft.AspNetCore.Builder
{
    public static class IdentityBuilderExtensions
    {
        public static void AddHssIdentity(this IServiceCollection services)
        {
            services.AddIdentity<User, Role>(config =>
            {
                config.Cookies.ApplicationCookie.AutomaticChallenge = false;
            })
                .AddEntityFrameworkStores<IdentityContext, uint>()
                .AddDefaultTokenProviders();

            services.AddOpenIddict<User, Role, IdentityContext, uint>()
                .AddMvcBinders()
                .EnableTokenEndpoint("/token")
                .AllowPasswordFlow()
                .AllowRefreshTokenFlow()
                .SetAccessTokenLifetime(TimeSpan.FromMinutes(5))
                .SetRefreshTokenLifetime(TimeSpan.FromHours(1))
                .UseJsonWebTokens()
                .DisableHttpsRequirement()
                .AddEphemeralSigningKey();
        }

        public static IApplicationBuilder UseHssIdentity(this IApplicationBuilder app)
        {
            return app.UseIdentity()
                      .UseOAuthValidation()
                      .UseOpenIddict();
        }
    }
}
