using Maestro.Authentication.Identity;
using Maestro.Authentication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;


namespace Maestro.Authentication
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddMaestroAuthentication(this IServiceCollection services)
        {

            services.AddIdentity<ApplicationUser, ApplicationUserRole>(x=> {
                x.Password.RequireDigit = false;
                x.Password.RequiredLength = 1;
                x.Password.RequireLowercase = false;
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequireUppercase = false;
            })
                             .AddUserManager<UserManager<ApplicationUser>>()
                             .AddRoleManager<RoleManager<ApplicationUserRole>>()
                             .AddSignInManager<SignInManager<ApplicationUser>>()
                              .AddUserStore<CustomUserStore>()
                              .AddRoleStore<CustomRoleStore>()
                              .AddDefaultTokenProviders();


            return services;

        }
    }
}
