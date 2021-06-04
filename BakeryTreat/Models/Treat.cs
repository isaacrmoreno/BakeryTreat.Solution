using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BakeryTreat.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }

    [Required]
    [Display(Name = "Treat")]
    public string TreatName { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; }
  }
}