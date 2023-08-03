using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContactIdentityList.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ContactIdentityList.Controllers;

public class IdentitiesController : Controller
{
  private readonly ContactIdentityListContext _db;

  public IdentitiesController(ContactIdentityListContext db)
  {
    _db = db;
  }

  public ActionResult Index()
  {
    List<Identity> model = _db.Identities.Include(identity => identity.Contact).ToList();
    return View(model);
  }

  public ActionResult Create()
  {
    ViewBag.ContactId = new SelectList(_db.Contacts, "ContactId", "FullName");
    return View();
  }

  [HttpPost]
  public ActionResult Create(Identity identity)
  {
    if (ModelState.IsValid == false)
    {
      ViewBag.ContactId = new SelectList(_db.Contacts, "ContactId", "FullName");
      return View(identity);
    }
    else
    {
    _db.Identities.Add(identity);
    _db.SaveChanges();
    return RedirectToAction("Index");
    }
  }
}
