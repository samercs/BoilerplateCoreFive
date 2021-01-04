using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Boilerplate.Authorization.Roles;
using Boilerplate.Authorization.Users;
using Boilerplate.MultiTenancy;

namespace Boilerplate.EntityFrameworkCore
{
    public class BoilerplateDbContext : AbpZeroDbContext<Tenant, Role, User, BoilerplateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BoilerplateDbContext(DbContextOptions<BoilerplateDbContext> options)
            : base(options)
        {
        }
    }
}
