using Microsoft.AspNetCore.Mvc;
using ContactIdentityList.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContactIdentityList.Controllers;

public class GroupsController : Controller
{
  private readonly ContactIdentityListContext _db;

  public GroupsController(ContactIdentityListContext db)
  {
    _db = db;
  }

  public ActionResult Index()
  {
    return View();
  }

  public ActionResult Create()
  {
    return View();
  }
}
