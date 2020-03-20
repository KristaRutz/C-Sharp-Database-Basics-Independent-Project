using System.Collections.Generic;

namespace Organization.Models
{
  public class User
  {
    public User()
    {
      this.Zines = new List<Zine>();
    }

    public int UserId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<ZinePoZineget; set; }
  }
}