using Microsoft.EntityFrameworkCore;

namespace ZineMachine.Models
{
  public class ZineMachineContext : DbContext
  {
    public virtual DbSet<User> Users { get; set; }
    public DbSet<Zine> Zines { get; set; }


    public ZineMachineContext(DbContextOptions options) : base(options) { }
  }
}
