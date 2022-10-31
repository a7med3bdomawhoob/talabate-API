using BLL.Interfaces;
using BLL.SpesificationDesignBattern;
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
    public class GenaricRepository<T> : IGenaricRepository<T> where T : class
    {
        private readonly MyContext context;

        public GenaricRepository(MyContext context)
        {
            this.context = context;
        }
        public async Task Add(T entity)
        {
           await context.Set<T>().AddAsync(entity);
        }

        public  void Delete(T entity)
        {
             context.Set<T>().Remove(entity);
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
          return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int? id)
        {
           return await context.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<ProductBrand>> GetAllBrands()
        {
            return await context.brands.ToListAsync();
        }

        public async Task<IReadOnlyList<BroductType>> GetAllTypes()
        {
            return await context.types.ToListAsync();
        }

        public  void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluators<T>.GetQuery(context.Set<T>() , spec);
        }

      
        public async Task<T> GetwithSpec(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).FirstOrDefaultAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllwithSpec(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        async Task<IReadOnlyList<T>> IGenaricRepository<T>.GetAllBrands()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> getall()
        {
            return await context.Set<T>()  .ToListAsync();
        }
    }
}
