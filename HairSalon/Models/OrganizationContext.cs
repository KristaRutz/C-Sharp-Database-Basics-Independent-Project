using Microsoft.EntityFrameworkCore;

namespace Organization.Models
{
  public class OrganizationContext : DbContext
  {
    public virtual DbSet<Employee> Employees { get; set; }
    public DbSet<Client> Clients { get; set; }


    public OrganizationContext(DbContextOptions options) : base(options) { }
  }
}
