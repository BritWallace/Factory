using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public DbSet<Engineer> Categories { get; set; }
    public DbSet<Machine> Items { get; set; }
    
    public DbSet<EngineerMachine> CategoryItemTags { get; set; }

    public FactoryContext(DbContextOptions options) : base(options) { }
  }
}