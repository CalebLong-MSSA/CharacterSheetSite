using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectStep8LoginPage.Models
{
   public class Inventory
   {
      public string Invent { get; set; }

      [Required(ErrorMessage = "Must have an AV.")]
      public int AV { get; set; }
   }
}
