using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context.Postgres
{
    public class PostgresContext(DbContextOptions options) : ApiDbContext(options)
    {
    
    }
}
