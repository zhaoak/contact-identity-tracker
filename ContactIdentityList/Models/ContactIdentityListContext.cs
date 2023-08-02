using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ContactIdentityList.Models;

public class ContactIdentityListContext : DbContext
{
  public DbSet<Contact> Contacts { get; set; }
  public DbSet<Identity> Identities { get; set; }
  public DbSet<Group> Groups { get; set; }
  public DbSet<ContactGroup> ContactGroups { get; set; }
  
  public ContactIdentityListContext(DbContextOptions options) : base(options) { }
}
