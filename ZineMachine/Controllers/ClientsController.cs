using Microsoft.AspNetCore.Mvc;
using Organization.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Organization.Controllers
{
  public class ZinesController : Controller
  {

    private readonly OrganizationContext _db;

    public ZinesController(OrganizationContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Zine> model = _db.Zines.Include(zines => zines.User).ToList();
      ViewBag.UserCount = _db.Zines.ToList().Count;
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.UserId = new SelectList(_db.Users, "UserId", "Name");
      return View();
    }

    [HttpZine]
    public ActionResult Create(Zine zine)
    {
      _db.Zines.Add(zine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Zine thisZine = _db.Zines.FirstOrDefault(zine => zine.ZineId == id);
      ViewBag.UserLiaison = _db.Users.FirstOrDefault(user => user.UserId == thisZine.UserId);
      return View(thisZine);
    }

    public ActionResult Edit(int id)
    {
      var thisZine = _db.Zines.FirstOrDefault(zines => zines.ZineId == id);
      ViewBag.UserId = new SelectList(_db.Users, "UserId", "Name", thisZine.UserId);
      return View(thisZine);
    }

    [HttpZine]
    public ActionResult Edit(Zine zine)
    {
      _db.Entry(zine).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisZine = _db.Zines.FirstOrDefault(zines => zines.ZineId == id);
      return View(thisZine);
    }

    [HttpZine, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisZine = _db.Zines.FirstOrDefault(zines => zines.ZineId == id);
      _db.Zines.Remove(thisZine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}