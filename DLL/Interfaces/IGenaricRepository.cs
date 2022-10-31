using BLL.SpesificationDesignBattern;
using DAL.Entities;
using DAL.SpesificationDesignBattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public  interface IGenaricRepository<T> where T: class
    {
        Task<IReadOnlyList<T>> GetAll();
        Task<T> GetById(int? id);
        Task Add(T entity);
       public void Delete(T entity);
        void Update(T entity);

        public  Task<IReadOnlyList<T>> GetAllBrands();
        public Task<IReadOnlyList<BroductType>> GetAllTypes();
        public Task<T> GetwithSpec(ISpecification<T> spec);
        public Task<IReadOnlyList<T>> GetAllwithSpec(ISpecification<T> spec);

        public Task<IReadOnlyList<T>> getall();
    }
}
