namespace ContactIdentityList.Models;
using System.ComponentModel.DataAnnotations;

public class Identity
{
  public int IdentityId { get; set; }
  [Required(ErrorMessage = "An identity must have a type to distinguish it from others.")]
  public string Type { get; set; } // type of identity--website, phone, etc
  public string Identifier { get; set; } // specific phone num, email address, etc
  public string ProfileURL { get; set; } // online profile or presence, like for social media, if applicable
  public string Notes { get; set; } // misc notes about identity
 
  public int ContactId { get; set; } // no validation -- allow anonymous identities
  public Contact Contact { get; set; }
}
