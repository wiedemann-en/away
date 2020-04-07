using Away.Api.Core.Repository.Specification;
using Away.Api.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Away.Api.Data.Repository.Specification
{
    public class SpecificationBase<TEntity> : ISpecification<TEntity>
         where TEntity : ModelBase
    {
        #region Constructors
        public SpecificationBase()
        {
            Filters = new List<Expression<Func<TEntity, bool>>>();
            FilterGenerics = new Dictionary<string, object>();
            Includes = new List<Expression<Func<TEntity, object>>>();
            IncludeStrings = new List<string>();
            Sort = null;
            SortManual = null;
            Pager = null;
        }
        #endregion

        #region ISpecification
        public List<Expression<Func<TEntity, bool>>> Filters { get; }
        public Dictionary<string, object> FilterGenerics { get; }
        public List<Expression<Func<TEntity, object>>> Includes { get; }
        public List<string> IncludeStrings { get; }
        public Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> Sort { get; set; }
        public ISorter SortManual { get; set; }
        public IPager Pager { get; set; }
        #endregion

        #region Public Methods
        public void AddFilter(Expression<Func<TEntity, bool>> filter)
        {
            Filters.Add(filter);
        }
        public void AddFilterRange(List<Expression<Func<TEntity, bool>>> filters)
        {
            Filters.AddRange(filters);
        }
        public void AddFilter(string filterName, object filterValue)
        {
            if (!FilterGenerics.ContainsKey(filterName))
                FilterGenerics.Add(filterName, filterValue);
        }
        public void AddFilterRange(IDictionary<string, object> filters)
        {
            foreach (var filter in filters)
            {
                if (!FilterGenerics.ContainsKey(filter.Key))
                    FilterGenerics.Add(filter.Key, filter.Value);
            }
        }
        public void AddInclude(Expression<Func<TEntity, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
        public void AddIncludeRange(List<Expression<Func<TEntity, object>>> includesExpression)
        {
            Includes.AddRange(includesExpression);
        }
        public void AddInclude(string includeString)
        {
            IncludeStrings.Add(includeString);
        }
        public void AddIncludeRange(List<string> includesString)
        {
            IncludeStrings.AddRange(includesString);
        }
        public void SetSort(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> sort)
        {
            Sort = sort;
        }
        public void SetSortManual(string name, bool isAscending)
        {
            SortManual = new Sorter()
            {
                Name = name,
                IsAscending = isAscending
            };
        }
        public void SetPager(short pageSize, short pageNumber)
        {
            Pager = new Pager()
            {
                PageSize = pageSize,
                PageNumber = pageNumber
            };
        }
        #endregion
    }
}
