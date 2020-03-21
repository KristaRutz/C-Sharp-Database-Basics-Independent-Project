using Microsoft.EntityFrameworkCore;

namespace ZineMachine.Models
{
  public class ZineMachineContext : DbContext
  {
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Zine> Zines { get; set; }
    public virtual DbSet<Post> Posts {get; set;}


    public ZineMachineContext(DbContextOptions options) : base(options) { }
  }
}
