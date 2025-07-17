using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Finac.EntityFrameworkCore
{
    public static class FinacDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FinacDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FinacDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
