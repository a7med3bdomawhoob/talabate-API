using DAL.RedisEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IBasketRepositort
    {
         Task <CustomerBasket> GetCustomerBasket(string basketid);
         Task<CustomerBasket> UpdateCusomerBasket(CustomerBasket basket);
         Task<bool> DeleteCustomerBasket(string basketid);
    }
}
