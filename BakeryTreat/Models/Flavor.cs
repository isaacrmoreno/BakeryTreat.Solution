using System.Collections.Generic;

namespace BakeryTreat.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }
    public int FlavorId { get; set; }
    [Display(Name = "Flavor")]
    public string FlavorName { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
  }
}