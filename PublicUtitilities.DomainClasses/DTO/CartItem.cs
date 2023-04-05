using System;
using System.Collections.Generic;
using System.Text;

namespace PublicUtitilities.DomainClasses.DTO
{
   public  class CartItem
    {
        public int Units { get; set; }
      
        public decimal Price { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
