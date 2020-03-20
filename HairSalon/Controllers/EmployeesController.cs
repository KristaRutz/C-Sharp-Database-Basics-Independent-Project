using Microsoft.AspNetCore.Mvc;
using Organization.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace Organization.Controllers
{
  public class EmployeesController : Controller
  {

    private readonly OrganizationContext _db;

    public EmployeesController(OrganizationContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Employee> model = _db.Employees.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Employee employee)
    {
      _db.Employees.Add(employee);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Employee thisEmployee = _db.Employees.FirstOrDefault(catogory => catogory.EmployeeId == id);
      thisEmployee.Clients = _db.Clients.Where(client => client.EmployeeId == id).ToList();
      return View(thisEmployee);
    }

    public ActionResult Edit(int id)
    {
      var thisEmployee = _db.Employees.FirstOrDefault(employees => employees.EmployeeId == id);
      return View(thisEmployee);
    }

    [HttpPost]
    public ActionResult Edit(Employee employee)
    {
      _db.Entry(employee).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisEmployee = _db.Employees.FirstOrDefault(employees => employees.EmployeeId == id);
      return View(thisEmployee);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisEmployee = _db.Employees.FirstOrDefault(employees => employees.EmployeeId == id);
      _db.Employees.Remove(thisEmployee);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}