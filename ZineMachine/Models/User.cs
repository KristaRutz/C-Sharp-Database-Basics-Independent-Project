using System.Collections.Generic;

namespace ZineMachine.Models
{
  public class User
  {
    public int UserId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Zine> Zines { get; set; }

    public User()
    {
      this.Zines = new List<Zine>();
    }
  }
}