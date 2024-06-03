using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class MySqlContext : ApiDbContext
    {
        public MySqlContext(DbContextOptions options) : base(options)
        {
        }

        //If necessary we can override the model creating method and do manually the best mapping for mysql
        //protected override void OnModelCreating(ModelBuilder modelBuilder)    g
        //{
        //    modelBuilder.Entity<Address>().Property(wf => wf.Street).HasColumnType("varchar(512)");
        //}

    }
}
