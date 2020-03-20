using Microsoft.EntityFrameworkCore;

namespace Organization.Models
{
  public class OrganizationContext : DbContext
  {
    public virtual DbSet<User> Users { get; set; }
    public DbSet<Zine> Zines { get; set; }


    public OrganizationContext(DbContextOptions options) : base(options) { }
  }
}
