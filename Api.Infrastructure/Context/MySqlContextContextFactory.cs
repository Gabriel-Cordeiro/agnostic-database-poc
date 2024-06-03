using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Context
{
    public class MySqlContextContextFactory : IDesignTimeDbContextFactory<MySqlContext>
    {
        public MySqlContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MySqlContext>();
            builder.UseMySQL();
            return new MySqlContext(builder.Options);
        }
    }
}
