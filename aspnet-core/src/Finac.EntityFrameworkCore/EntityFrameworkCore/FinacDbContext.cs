using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Finac.Authorization.Roles;
using Finac.Authorization.Users;
using Finac.MultiTenancy;

namespace Finac.EntityFrameworkCore
{
    public class FinacDbContext : AbpZeroDbContext<Tenant, Role, User, FinacDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FinacDbContext(DbContextOptions<FinacDbContext> options)
            : base(options)
        {
        }
    }
}
