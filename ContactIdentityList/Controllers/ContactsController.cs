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

  // full contact list page
  public ActionResult Index()
  {
    List<Contact> model = _db.Contacts.ToList();
    return View(model);
  }

  // create contact form page
  public ActionResult Create()
  {
    return View();
  }

  // create contact post route
  [HttpPost]
  public ActionResult Create(Contact contact)
  {
    if (ModelState.IsValid == false)
    {
      return View(contact);
    }
    else
    {
    _db.Contacts.Add(contact);
    _db.SaveChanges();
    return RedirectToAction("Index");
    }
  }
}
