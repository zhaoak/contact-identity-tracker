using Microsoft.AspNetCore.Mvc;
using ContactIdentityList.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContactIdentityList.Controllers;

public class ContactsController : Controller
{
  private readonly ContactIdentityListContext _db;

  public ContactsController(ContactIdentityListContext db)
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
