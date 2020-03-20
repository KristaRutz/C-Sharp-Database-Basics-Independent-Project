using Microsoft.AspNetCore.Mvc;
using Organization.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Organization.Controllers
{
  public class ClientsController : Controller
  {

    private readonly OrganizationContext _db;

    public ClientsController(OrganizationContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients.Include(clients => clients.Employee).ToList();
      ViewBag.EmployeeCount = _db.Clients.ToList().Count;
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.EmployeeId = new SelectList(_db.Employees, "EmployeeId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      ViewBag.EmployeeLiaison = _db.Employees.FirstOrDefault(employee => employee.EmployeeId == thisClient.EmployeeId);
      return View(thisClient);
    }

    public ActionResult Edit(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
      ViewBag.EmployeeId = new SelectList(_db.Employees, "EmployeeId", "Name", thisClient.EmployeeId);
      return View(thisClient);
    }

    [HttpPost]
    public ActionResult Edit(Client client)
    {
      _db.Entry(client).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
      return View(thisClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisClient = _db.Clients.FirstOrDefault(clients => clients.ClientId == id);
      _db.Clients.Remove(thisClient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}