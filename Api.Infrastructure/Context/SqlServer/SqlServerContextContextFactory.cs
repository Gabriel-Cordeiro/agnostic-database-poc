using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Context.SqlServer
{
    public class SqlServerContextContextFactory : IDesignTimeDbContextFactory<SqlServerContext>
    {
        public SqlServerContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SqlServerContext>();
            builder.UseSqlServer();
            return new SqlServerContext(builder.Options);
        }
    }
}
