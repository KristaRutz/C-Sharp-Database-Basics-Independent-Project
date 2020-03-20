using Microsoft.AspNetCore.Mvc;

namespace Organization.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}