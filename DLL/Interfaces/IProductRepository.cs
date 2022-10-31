using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IProductRepository
    {
        Task<IReadOnlyList<BroductType>> GetAllTypes ();
        Task<IReadOnlyList<ProductBrand>> GetAllBrands();

      public  Task<IReadOnlyList<Product>> GtBroduct();
        Task<Product> GetById(int? id);
        public  Task<IReadOnlyList<Product>> GtBroductfiltration(int? price);
        public Task<IReadOnlyList<Product>> skipTake(int pageindex,int pagesize);

        public Task<Product> search(string name);
    }
}
