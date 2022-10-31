using BLL.Interfaces;
using DAL.RedisEntities;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class BasketRepository : IBasketRepositort
    {
        private readonly IDatabase redis;  //readonly because any change will be from clr 

        public BasketRepository(IConnectionMultiplexer redis)
        {
           this.redis = redis.GetDatabase();
        }

       

        public async Task<bool> DeleteCustomerBasket(string basketid)
        {
         return  await redis.KeyDeleteAsync(basketid);
        }
        //طلاما واجدخ بس جيت مش لازم
        public async Task<CustomerBasket> GetCustomerBasket(string basketid)
        {
            var redisvalue = await redis.StringGetAsync(basketid);  //as json
            return redisvalue.IsNullOrEmpty ? null : JsonSerializer.Deserialize<CustomerBasket>(redisvalue);
        } 

        public async Task<CustomerBasket> UpdateCusomerBasket(CustomerBasket basket)  //creating from update
        {
            var redisvalue = await redis.StringSetAsync(basket.Id,JsonSerializer.Serialize(basket),TimeSpan.FromDays(30));
            if (!redisvalue) return null;
            return await GetCustomerBasket(basket.Id);

        }
    }
}
