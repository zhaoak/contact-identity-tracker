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
    List<Group> model = _db.Groups.ToList();
    return View(model);
  }

  public ActionResult Create()
  {
    return View();
  }
}
