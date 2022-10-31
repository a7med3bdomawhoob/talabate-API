using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.RedisEntities
{
    public  class BasketItem:BaseEntity
    {
      
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string PictureUrl { get; set; }
        public int Quantity { get; set; }
        public string brand { get; set; }
        public string type { get; set; }

    }
}
