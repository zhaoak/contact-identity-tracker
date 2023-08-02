using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactIdentityList.Models;

public class Group
{
  [Range(1, int.MaxValue)]
  public int GroupId { get; set; }
  [Required(ErrorMessage = "A group must have a name.")]
  public string Name { get; set; }
  public string Description { get; set; }

  public List<ContactGroup> JoinEntities { get; }
}
