using Microsoft.AspNetCore.Mvc;
using Organization.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Organization.Controllers
{
  public class PostsController : Controller
  {

    private readonly OrganizationContext _db;

    public PostsController(OrganizationContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Post> model = _db.Posts.Include(posts => posts.User).ToList();
      ViewBag.UserCount = _db.Posts.ToList().Count;
      return View(model);
    }

    public ActionResult Create()
    {
      ViewBag.UserId = new SelectList(_db.Users, "UserId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Post post)
    {
      _db.Posts.Add(post);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Post thisPost = _db.Posts.FirstOrDefault(post => post.PostId == id);
      ViewBag.UserLiaison = _db.Users.FirstOrDefault(user => user.UserId == thisPost.UserId);
      return View(thisPost);
    }

    public ActionResult Edit(int id)
    {
      var thisPost = _db.Posts.FirstOrDefault(posts => posts.PostId == id);
      ViewBag.UserId = new SelectList(_db.Users, "UserId", "Name", thisPost.UserId);
      return View(thisPost);
    }

    [HttpPost]
    public ActionResult Edit(Post post)
    {
      _db.Entry(post).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisPost = _db.Posts.FirstOrDefault(posts => posts.PostId == id);
      return View(thisPost);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisPost = _db.Posts.FirstOrDefault(posts => posts.PostId == id);
      _db.Posts.Remove(thisPost);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}