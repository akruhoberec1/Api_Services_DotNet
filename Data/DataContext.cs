global using Microsoft.EntityFrameworkCore;

namespace WebApi_BestPractices.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\;Database=WebAPI;Trusted_Connection=True;TrustServerCertificate=true;");
        }

        public DbSet<VehicleMake> VehicleMakes { get; set; }
    }
}
