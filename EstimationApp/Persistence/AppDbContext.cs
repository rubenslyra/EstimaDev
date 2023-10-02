using EstimationApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EstimationApp.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Estimate> Estimates { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new EstimateConfiguration());
    }

}

