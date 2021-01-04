using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Boilerplate.Authorization;
using Boilerplate.Authorization.Roles;
using Boilerplate.Authorization.Users;
using Boilerplate.Editions;
using Boilerplate.MultiTenancy;

namespace Boilerplate.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            services.ConfigureApplicationCookie(i =>
            {
                i.LoginPath = "/Identity/Account/Login";
                i.LogoutPath = "/Identity/Account/Logout";
                i.AccessDeniedPath = "/AccessDenied";
                i.Cookie.Name = "Boilerplate.Identity";
                i.ExpireTimeSpan = TimeSpan.FromHours(2);
                //i.Cookie.SameSite = SameSiteMode.None;//TODO Remove after IFrame Remove
                //i.Cookie.HttpOnly = true;//TODO Remove after IFrame Remove
                //i.Cookie.SecurePolicy = CookieSecurePolicy.Always;//TODO Remove after IFrame Remove
                i.Cookie.Path = "/; SameSite = lax";
                //i.Cookie.IsEssential = true;
            });

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
