using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace SweetAndSavoryTreats.Models
{
  public class Flavor
  {
    public Flavor() 
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }
    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntities { get; }

  }
}