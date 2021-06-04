using Microsoft.AspNetCore.Mvc;

namespace Favorful.Controllers
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