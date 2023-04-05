using System;
using System.Collections.Generic;
using System.Text;

namespace PublicUtitilities.DomainClasses.DTO
{
   public class Cart
    {
        public string UserName { get; set; }

        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public  Cart () { }

        public Cart (string userName) {
            UserName = userName;
        }

        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                foreach (var item in Items)
                {
                    totalPrice += item.Price * item.Units;
                }
                return totalPrice;
            }
        }
    }
}
