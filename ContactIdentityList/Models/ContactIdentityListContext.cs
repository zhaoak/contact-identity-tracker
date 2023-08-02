using Microsoft.EntityFrameworkCore;

namespace ContactIdentityList.Models;

public class ContactIdentityListContext : DbContext
{
  
  public ContactIdentityListContext(dbContextOptions options) : base(options) { }
}
