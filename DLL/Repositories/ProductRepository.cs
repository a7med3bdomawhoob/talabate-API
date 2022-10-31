using BLL.Interfaces;
using DAL.Context;
using DAL.Entities;
using DAL.SpesificationDesignBattern;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyContext context;

        public ProductRepository( MyContext context)
        {
            this.context = context;
        }

        public async Task<IReadOnlyList<ProductBrand>> GetAllBrands()
        {
            return await context.brands.ToListAsync();
        }

      

        public async Task<IReadOnlyList<BroductType>> GetAllTypes()
        {
            return await context.types.ToListAsync();
        }

        public async Task<Product> GetById(int? id)
        {
            return await context.products.
               
                FindAsync(id);
        }

        public async Task<IReadOnlyList<Product>> GtBroduct()
        {

            // return await context.products.ToListAsync();
            //   return await context.products.

            return await context.products.OrderBy(p => p.Price)
             .Include(p => p.productbrand).ToListAsync();



        }


        public async Task<IReadOnlyList<Product>> GtBroductfiltration(int ? price) //can be null
        {

            // return await context.products.ToListAsync();
            //   return await context.products.

           var objname=   await context.products.Where(p=>p.Price<=price)
             .Include(p => p.productbrand)
                 .Include(p => p.broducttype).ToListAsync();
            return objname;

        }

        public  async Task<Product> search(string name)
        {
           return await context.products.FirstOrDefaultAsync(p=>p.Name==name);
            
        }

        public async Task<IReadOnlyList<Product>> skipTake(int pageindex,int pagesize)
        {
          return   await context.products.Skip(pagesize*(pageindex-1)).Take(pagesize).ToListAsync();
            
        }

        //public IEnumerable<Product> sorting(string sort,int typeid,int brandid) //not used for my programe
        //{
        //    if (!string.IsNullOrEmpty(sort))
        //    {
        //        switch (sort)
        //        {
        //            case "priceAsc":
        //                return context.products.OrderBy(p => p.Price);
        //                break;
        //            case "priceDesc":
        //                return context.products.OrderBy(p => p.Price);
        //                    break;
        //            default:
        //                return context.products.OrderBy(p => p.Name);
        //        }
        //    }
        //    return context.products.OrderBy(p => p.Id);
        //}




    }
}
