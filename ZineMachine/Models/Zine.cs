using System.Collections.Generic;

namespace ZineMachine.Models
{
  public class Zine
  {
    public int ZineId { get; set; }
    public string Name { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
    public virtual ICollection<Post> Posts { get; set; }

    public Zine()
    {
      this.Posts = new List<Post>();
    }
  }
}