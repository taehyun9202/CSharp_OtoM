using Microsoft.EntityFrameworkCore;
namespace Brony.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options){}

        public DbSet<User> Users { get; set; }

        public DbSet<BronySample> Bronies { get; set; }
    }
}