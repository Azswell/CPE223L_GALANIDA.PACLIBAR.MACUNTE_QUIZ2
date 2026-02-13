// AppDbContext.cs
using EquipmentTracker.Domain;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Equipment> Equipments { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    public class AppDbContext
    {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AppDbReleased;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
