using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Favorful.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }
    public string Name { get; set; }

    [Display(Name = "Customer Rating")]
    public int CustomerRating { get; set; }

    public int Price { get; set; }

    public string Description { get; set; }

    [Display(Name = "Current Stock")]
    public int CurrentStock { get; set; }
    
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; set; }
  }
}