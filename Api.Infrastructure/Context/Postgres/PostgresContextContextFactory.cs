using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Context.Postgres
{
    public class PostgressContextContextFactory : IDesignTimeDbContextFactory<PostgresContext>
    {
        public PostgresContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PostgresContext>();
            builder.UseNpgsql();
            return new PostgresContext(builder.Options);
        }
    }
}
