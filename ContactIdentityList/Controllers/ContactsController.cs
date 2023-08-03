using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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

  // contact detail page
  public ActionResult Detail(int contactId)
  {
    Contact thisContact = _db.Contacts
                                   .Include(contact => contact.JoinEntities)
                                   .ThenInclude(join => join.Group)
                                   .Include(contact => contact.Identities)
                                   .FirstOrDefault(contact => contact.ContactId == contactId);
    return View(thisContact);
  }
}
