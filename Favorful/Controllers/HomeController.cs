using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Favorful.Models;

namespace Favorful.Controllers
{
  public class HomeController : Controller
  {
    private readonly FavorfulContext _db;

    public HomeController(FavorfulContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      List<Treat> treatList = _db.Treats.ToList();
      List<Flavor> flavorList = _db.Flavors.ToList();
      model.Add("Treats", treatList);
      model.Add("Flavors", flavorList);
      return View(model);
    }
  }
}