using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class SqlServerContext(DbContextOptions options) : ApiDbContext(options)
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlServer("Data Source=my.db");
    }
}
