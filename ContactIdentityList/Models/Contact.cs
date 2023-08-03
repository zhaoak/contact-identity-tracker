using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactIdentityList.Models;

public class Contact
{
  public int ContactId { get; set; }
  public string ShortName { get; set; }
  [Required(ErrorMessage = "A contact must have a name.")]
  public string FullName { get; set; }

  public List<Identity> Identities { get; set; }
  public List<ContactGroup> JoinEntities { get; }

}
