using System.Collections.Generic;

namespace BakeryTreat.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }

    [Display(Name = "Treat")]
    public string TreatName { get; set; }
    public virtual ApplicationUser User { get; set; }

    public virtual ICollection<CategoryTreat> JoinEntities { get; }
  }
}