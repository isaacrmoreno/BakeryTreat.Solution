using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BakeryTreat.Models
{
  public class BakeryTreatContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Flavor> Flavor { get; set; }
    public DbSet<Treat> Treat { get; set; }
    public DbSet<FlavorTreat> FlavorTreat { get; set; }

    public BakeryTreatContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}