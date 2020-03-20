using System.Collections.Generic;

namespace Organization.Models
{
  public class Employee
  {
    public Employee()
    {
      this.Clients = new List<Client>();
    }

    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}