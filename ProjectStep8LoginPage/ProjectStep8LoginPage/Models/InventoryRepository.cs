using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectStep8LoginPage.Models
{
   public class InventoryRepository
   {
      //   F i e l d s   &   P r o p e r t i e s

      private static List<Inventory> responses
         = new List<Inventory>();

      //   C o n s t r u c t o r s

      //   M e t h o d s

      public static void AddResponse(Inventory response)
      {
         responses.Add(response);
      }

      public static IEnumerable<Inventory> Responses
         => responses;

   }
}
