using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context.SqlServer
{
    public class SqlServerContext(DbContextOptions options) : ApiDbContext(options)
    {
    
    }
}
