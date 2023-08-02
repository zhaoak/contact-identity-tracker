using Microsoft.AspNetCore.Mvc;
using ContactIdentityList.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContactIdentityList.Controllers;

public class HomeController : Controller
{
  private readonly ContactIdentityListContext _db;

  public HomeController(ContactIdentityListContext db)
  {
    _db = db;
  }

  [HttpGet("/")]
  public ActionResult Index()
  {
    return View();
  }
}
