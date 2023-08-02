using System.Collections.Generic;
using ContactIdentityList.Models;
using System.ComponentModel.DataAnnotations;

public class ContactGroup
{
  [Range(1, int.MaxValue)]
  public int ContactGroupId { get; set; }
  public int ContactId { get; set; }
  public Contact Contact { get; set; }
  public int GroupId { get; set; }
  public Group Group { get; set; }

}
