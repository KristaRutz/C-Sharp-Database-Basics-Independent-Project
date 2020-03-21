using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ZineMachine.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace ZineMachine.Controllers
{
  public class PostsController : Controller
  {
    private readonly ZineMachineContext _db;

    public PostsController(ZineMachineContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Post> model = _db.Posts.ToList();
      return View(model);
    }

    public ActionResult Create(int zineId)
    {
			Zine thisZine = _db.Zines.FirstOrDefault(zines => zines.ZineId == zineId);
			ViewBag.ZineId = zineId;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Post post)
    {
      _db.Posts.Add(post);
      _db.SaveChanges();
      return RedirectToAction("Details", "Zines", new { id = post.ZineId});
    }

    public ActionResult Edit(int id)
    {
      var thisPost = _db.Posts.FirstOrDefault(posts => posts.PostId == id);
      var thisZine = _db.Zines.FirstOrDefault(zine => zine.ZineId == thisPost.ZineId);
      ViewBag.ZineName = thisZine.Name;
      return View(thisPost);
    }

    [HttpPost]
    public ActionResult Edit(Post post)
    {
      _db.Entry(post).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", "Zines", new { id = post.ZineId});
    }

    public ActionResult Delete(int id)
    {
      var thisPost = _db.Posts.FirstOrDefault(posts => posts.PostId == id);
      var thisZine = _db.Zines.FirstOrDefault(zine => zine.ZineId == thisPost.ZineId);
      ViewBag.ZineName = thisZine.Name;
      return View(thisPost);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisPost = _db.Posts.FirstOrDefault(posts => posts.PostId == id);
      _db.Posts.Remove(thisPost);
      _db.SaveChanges();
      return RedirectToAction("Details", "Zines", new {id = thisPost.ZineId});
    }
  }
}