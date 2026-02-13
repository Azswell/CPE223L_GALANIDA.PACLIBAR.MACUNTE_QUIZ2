using EquipmentTracker.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EquipmentTracker.Infrastructure
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AppDbReleased;Integrated Security=True;TrustServerCertificate=True;");
            }
        }

        public DbSet<Equipment> Equipments { get; set; }
    }
}
