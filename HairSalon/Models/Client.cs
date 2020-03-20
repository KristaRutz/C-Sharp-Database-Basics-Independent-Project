namespace Organization.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Description { get; set; }
    public int EmployeeId { get; set; }
    public virtual Employee Employee { get; set; }
  }
}