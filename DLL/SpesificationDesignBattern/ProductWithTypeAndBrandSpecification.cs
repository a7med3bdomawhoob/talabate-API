using DAL.Entities;
using DAL.SpesificationDesignBattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SpesificationDesignBattern
{
    public  class ProductWithTypeAndBrandSpecification:BaseSpecification<Product>
    {
        public ProductWithTypeAndBrandSpecification()
        {
            AddInclude(p => p.broducttype);
            AddInclude(p=>p.productbrand);
        }

        public ProductWithTypeAndBrandSpecification(int ? id ): base(p=>p.Id==id)
        {
            AddInclude(p => p.broducttype);
            AddInclude(p => p.productbrand);
        }


    }
}
