using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SpesificationDesignBattern
{
    public  class BaseSpecification<T>
    {
        public Expression<System.Func<T, bool>> Critiria { get; set; }
        public List<Expression<Func<T, object>>> Includes { get; set; } = new List<Expression<Func<T, object>>>();



        public Expression<Func<T, object>> OrderBy { get; set; }
        public Expression<Func<T, object>> OrderByDes { get; set; }
        public int Take { get; set; }
        public int Skip { get; set; }
        public bool Isbagingenable { get; set; }

        public BaseSpecification(Expression<Func<T, bool>> Critiria)
        {
            this.Critiria = Critiria;
        }
        public BaseSpecification()
        {

        }

        public void AddInclude(Expression<Func<T, object>> Include)
        {
            Includes.Add(Include);
        }

        public void AddOrderBy(Expression<Func<T, object>> orderBy)
        {
            OrderBy = orderBy;
        }
        public void AddOrderDesinding(Expression<Func<T, object>> orderDesinding)
        {
            OrderByDes = orderDesinding;
        }
        public void ApplyPaging(int skip, int take)
        {
            Skip = skip;
            Take = take;
            Isbagingenable = true;
        }
    }
}
