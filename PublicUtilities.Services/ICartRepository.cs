using PublicUtitilities.DomainClasses.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PublicUtilities.Services
{
   public interface ICartRepository
    {
        Task<Cart> GetCart(string userName);
        Task<Cart> UpdateCart(Cart cart);
        Task DeleteCart(string userName);      
    }
}
