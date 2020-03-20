using Microsoft.AspNetCore.Mvc;
using ZineMachine.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace ZineMachine.Controllers
{
  public class UsersController : Controller
  {

    private readonly ZineMachineContext _db;

    public UsersController(ZineMachineContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<User> model = _db.Users.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(User user)
    {
      _db.Users.Add(user);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      User thisUser = _db.Users.FirstOrDefault(catogory => catogory.UserId == id);
      thisUser.Zines = _db.Zines.Where(zine => zine.UserId == id).ToList();
      return View(thisUser);
    }

    public ActionResult Edit(int id)
    {
      var thisUser = _db.Users.FirstOrDefault(users => users.UserId == id);
      return View(thisUser);
    }

    [HttpPost]
    public ActionResult Edit(User user)
    {
      _db.Entry(user).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisUser = _db.Users.FirstOrDefault(users => users.UserId == id);
      return View(thisUser);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisUser = _db.Users.FirstOrDefault(users => users.UserId == id);
      _db.Users.Remove(thisUser);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}