using Microsoft.EntityFrameworkCore;

namespace plz.Models
{
    public class Connection : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=molly;User Id=sa;Password=aptech;TrustserverCertificate=True");
        }

        public DbSet<Student> students { get; set; }
    }
}
