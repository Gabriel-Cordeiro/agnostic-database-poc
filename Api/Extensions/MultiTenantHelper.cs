using Core.Enums;
using Infrastructure.Context;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Api.Models;

namespace Api.Extensions
{
    public static class MultiTenantHelper
    {
        public static void AddMultiTenantDbContext(this IServiceCollection services)
        {
            services.AddDbContext<ApiDbContext>((serviceProvider, options) =>
            {
                var httpContext = serviceProvider.GetRequiredService<IHttpContextAccessor>();
                var accessToken = GetIdentityDataFromRequest(httpContext);
                var configuration = serviceProvider.GetRequiredService<IConfiguration>();

                var connectionString = configuration.GetConnectionString(accessToken.ConnectionName);

                switch (accessToken.Provider)
                {
                    case DatabaseProvider.SqlServer:
                        options.UseSqlServer(connectionString);
                        break;
                    case DatabaseProvider.MySql:
                        options.UseMySQL(connectionString);
                        break;
                    case DatabaseProvider.Hana:
                        throw new NotImplementedException();
                    default:
                        throw new Exception("Invalid database provider");
                }
            });
        }

        public static AccessToken GetIdentityDataFromRequest(this IHttpContextAccessor httpContextAccessor)
        {
            if (httpContextAccessor == null)
                throw new Exception("IHttpContextAccessor is null");

            var jwt = httpContextAccessor?.HttpContext.Request.Headers["Authorization"].ToString();

            if (jwt.IsNullOrEmpty())
                throw new Exception("JWT Token is null");

            var handler = new JwtSecurityTokenHandler();
            var token = handler.ReadJwtToken(jwt);

            return new AccessToken()
            {
                Name = token.Claims.FirstOrDefault(x => x.Type == "name")?.Value ?? string.Empty,
                ConnectionName = token.Claims.FirstOrDefault(x => x.Type == "connectionName")?.Value.ToString() ?? string.Empty,
                Id = Convert.ToInt32(token.Claims.FirstOrDefault(x => x.Type == "id")?.Value),
                Provider = Enum.Parse<DatabaseProvider>(token.Claims.FirstOrDefault(x => x.Type == "provider")?.Value)
            };
        }
    }
}
