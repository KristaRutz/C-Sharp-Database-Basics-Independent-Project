namespace ZineMachine.Models
{
  public class Zine
  {
    public int ZineId { get; set; }
    public string Name { get; set; }
    public int UserId { get; set; }
    public virtual User User { get; set; }
  }
}