using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BakeryTreat.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }
    public int FlavorId { get; set; }
    [Required]
    [Display(Name = "Flavor")]
    public string FlavorName { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
  }
}