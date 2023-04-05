using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using PublicUtilities.Services;
using PublicUtitilities.DomainClasses.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PublicUtitilities.SQL.Repositories
{
    public class CartRepository: ICartRepository
    {
        private readonly IDistributedCache _redisCache;

        public CartRepository(IDistributedCache redisCache)
        {
            _redisCache = redisCache ?? throw new ArgumentNullException(nameof(redisCache));
        }

    

        public async Task<Cart> GetCart(string userName)
        {
            var cart = await _redisCache.GetStringAsync(userName);

            if (String.IsNullOrEmpty(cart))
                return null;

            return JsonConvert.DeserializeObject<Cart>(cart);
        }

        public async Task<Cart> UpdateCart(Cart cart)
        {
            await _redisCache.SetStringAsync(cart.UserName, JsonConvert.SerializeObject(cart));

            return await GetCart(cart.UserName);
        }

        public async Task DeleteCart(string userName)
        {
            await _redisCache.RemoveAsync(userName);
        }
    }
}
