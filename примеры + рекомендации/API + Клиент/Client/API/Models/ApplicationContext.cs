using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = SLAVANST\\127.0.0.1,54163; Database = SystemO; Trusted_Connection=True;  TrustServerCertificate = True;");
        }
    }
}
