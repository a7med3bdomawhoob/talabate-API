using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.RedisEntities
{
    public  class CustomerBasket
    {
     
        public string Id { get; set; }

        public BasketItem item { get; set; }= new BasketItem();
        public CustomerBasket(string id)
        {
            Id = id;
        }

    }
}
