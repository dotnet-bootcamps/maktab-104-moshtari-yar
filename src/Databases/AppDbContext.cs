using Entities;
using Microsoft.EntityFrameworkCore;

namespace Databases
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=(LocalDb)\\MSSQLLocalDB; Initial Catalog=MaktabSharif-104-MoshtariYar; Integrated Security=True;");
        //    base.OnConfiguring(optionsBuilder);
        //}


        public DbSet<Ticket> Tickets { get; set; }

    }
}
