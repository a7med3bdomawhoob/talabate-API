using DAL.SpesificationDesignBattern;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.SpesificationDesignBattern
{
    public  class SpecificationEvaluators<TEntity> where TEntity : class
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inpute_query, ISpecification<TEntity> spec)
        {
            var query = inpute_query;
                //if (spec.Critiria != null)
                //    query = query.Where(spec.Critiria);
                //if (spec.OrderBy != null)
                //    query = query.OrderBy(spec.OrderBy);
                //if (spec.OrderByDes != null)
                //    query = query.OrderByDescending(spec.OrderByDes);
                //if (spec.Isbagingenable == true)
                //    query = query.Skip(spec.Skip).Take(spec.Take);

            query = spec.Includes.Aggregate(query, (currentQuery, include) => currentQuery.Include(include));
            //context.Set<Product>().Include(p=>p.Brand).Include(p=p.Type);
            return query;
        }
    }
}
