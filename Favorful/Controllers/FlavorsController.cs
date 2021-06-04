using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Favorful.Models;
using System.Collections.Generic;
using System.Linq;

namespace Favorful.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly FavorfulContext _db;

    public FlavorsController(FavorfulContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Flavor> model = _db.Flavors.ToList();
      return View(model);
    }
  }
}