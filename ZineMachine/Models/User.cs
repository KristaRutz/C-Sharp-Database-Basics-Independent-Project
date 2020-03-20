using System.Collections.Generic;

namespace ZineMachine.Models
{
  public class User
  {
    public User()
    {
      this.Zines = new List<Zine>();
    }

    public int UserId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Zine> Zines { get; set; }
  }
}