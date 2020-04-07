using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Away.Api.Core.Repository.Specification
{
    public interface ISpecification<TEntity>
         where TEntity : ModelBase
    {
        List<Expression<Func<TEntity, bool>>> Filters { get; }
        Dictionary<string, object> FilterGenerics { get; }
        List<Expression<Func<TEntity, object>>> Includes { get; }
        List<string> IncludeStrings { get; }
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> Sort { get; }
        ISorter SortManual { get; }
        IPager Pager { get; }

        void AddFilter(Expression<Func<TEntity, bool>> filter);
        void AddFilterRange(List<Expression<Func<TEntity, bool>>> filters);
        void AddFilter(string filterName, object filterValue);
        void AddFilterRange(IDictionary<string, object> filters);
        void AddInclude(Expression<Func<TEntity, object>> includeExpression);
        void AddIncludeRange(List<Expression<Func<TEntity, object>>> includesExpression);
        void AddInclude(string includeString);
        void AddIncludeRange(List<string> includesString);
        void SetSort(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> sort);
        void SetPager(short pageSize, short pageNumber);
    }
}
