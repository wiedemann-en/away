using Away.Api.Core.Repository.Base;
using Away.Api.Core.Repository.Specification;
using Away.Api.Data.Entities.Audit;
using Away.Api.Data.Entities.Base;
using Away.Api.Data.Entities.Query;
using Away.Api.Data.Repository.Specification;
using Away.Api.Misc.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Away.Api.Data.Repository.Base
{
    public class Repository<TEntity> : RepositoryBase, IRepository<TEntity>
        where TEntity : ModelBase
    {
        #region Protected Attributes
        protected DbSet<TEntity> _dbSet;
        #endregion

        #region IRepository
        public virtual async Task<TEntity> GetByIdAsync(long id, params string[] includes)
        {
            IQueryable<TEntity> query = _dbSet.AsNoTracking();

            if ((includes != null) && (includes.Any()))
                query = AggregateIncludes(query, includes.ToList());
            else
                query = SetDefaultIncludes(query);

            return await query.FirstOrDefaultAsync(x => x.Id == id);
        }

        public virtual TEntity GetById(long id, params string[] includes)
        {
            return GetByIdAsync(id, includes).Result;
        }

        public virtual async Task<ResponseQuery<TEntity>> GetAsync(ISpecification<TEntity> specification = null)
        {
            ResponseQuery<TEntity> result = new ResponseQuery<TEntity>();

            IQueryable<TEntity> query = _dbSet.AsNoTracking();

            bool applyIncludes = false;
            bool applyPager = false;
            int? skip = null;
            int? take = null;

            specification = InitializeSpecification(specification);

            if (specification.Includes != null)
            {
                applyIncludes = specification.Includes.Any();
                query = AggregateIncludes(query, specification.Includes);
            }

            if (specification.IncludeStrings != null)
            {
                applyIncludes = specification.IncludeStrings.Any();
                query = AggregateIncludes(query, specification.IncludeStrings);
            }

            if (!applyIncludes)
                query = SetDefaultIncludes(query);

            if (specification.FilterGenerics != null)
                query = AggregateFilterGenerics(query, specification.FilterGenerics);

            if ((specification.Filters != null) && (specification.Filters.Any()))
            {
                foreach (var filter in specification.Filters)
                    query = query.Where(filter);
            }

            //Filtros específicos de la entidad
            query = SetSpecificFilters(query, specification);

            if (specification.Sort != null)
                query = specification.Sort(query);

            if (specification.SortManual != null)
                query = AggregateSortManual(query, specification.SortManual);

            if (specification.Pager != null)
                applyPager = AggregatePager(specification.Pager, out skip, out take);

            result.Items = (applyPager)
                ? await query.Skip(skip.Value).Take(take.Value).ToListAsync()
                : await query.ToListAsync();

            result.Total = await query.CountAsync();

            return result;
        }

        public virtual ResponseQuery<TEntity> Get(ISpecification<TEntity> specification = null)
        {
            return GetAsync(specification).Result;
        }

        public virtual async Task<ResponseQuery<TEntity>> GetActivesAsync(params string[] includes)
        {
            ResponseQuery<TEntity> result = new ResponseQuery<TEntity>();

            IQueryable<TEntity> query = _dbSet.AsNoTracking();
            query = query.Where(x => x.Activo);
        
            if (includes != null && includes.Length > 0)
            {
                query = AggregateIncludes(query, includes.ToList());
            }
            else
            {
                query = SetDefaultIncludes(query);
            }

            result.Items = await query.ToListAsync();
            result.Total = result.Items.Count;

            return result;
        }

        public virtual ResponseQuery<TEntity> GetActives(params string[] includes)
        {
            return GetActivesAsync(includes).Result;
        }

        public virtual void Add(TEntity entity)
        {
            if (entity == null)
                return;

            entity.Activo = true;
            _dbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            if (entity == null)
                return;

            var exist = _dbSet.Find(entity.Id);
            if (exist != null)
            {
                CheckUpdateAudit(entity, exist);
                _context.Entry(exist).CurrentValues.SetValues(entity);
            }
        }

        public virtual void Delete(long id)
        {
            var exists = _dbSet.Find(id);
            if (_context.Entry(exists).State == EntityState.Detached)
                _dbSet.Attach(exists);
            _dbSet.Remove(exists);
        }

        public virtual void Delete(TEntity entity)
        {
            if (entity == null)
                return;

            if (_context.Entry(entity).State == EntityState.Detached)
                _dbSet.Attach(entity);

            _dbSet.Remove(entity);
        }

        public virtual void Disable(long id, RecordAudit audit)
        {
            var exists = _dbSet.Find(id);
            if (exists != null)
            {
                CheckUpdateAudit(audit, exists);
                exists.Activo = false;
            }
        }

        public virtual void Disable(TEntity entity)
        {
            var exists = _dbSet.Find(entity.Id);
            if (exists != null)
            {
                CheckUpdateAudit(entity, exists);
                exists.Activo = false;
            }
        }

        public virtual void Enable(long id, RecordAudit audit)
        {
            var exists = _dbSet.Find(id);
            if (exists != null)
            {
                CheckUpdateAudit(audit, exists);
                exists.Activo = true;
            }
        }

        public virtual void Enable(TEntity entity)
        {
            var exists = _dbSet.Find(entity.Id);
            if (exists != null)
            {
                CheckUpdateAudit(entity, exists);
                exists.Activo = true;
            }
        }
        #endregion

        #region IRepositoryBase
        public override void SetContext(DbContext context)
        {
            if (context is DataContext dataContext)
            {
                _context = dataContext;
                _dbSet = _context.Set<TEntity>();
            }
            else
            {
                throw new InvalidCastException("The provided DbContext was not an instance of DataContext");
            }
        }
        #endregion

        #region Protected Helpers
        protected void CheckUpdateAudit(TEntity source, TEntity destination)
        {
            if (destination is IRecordAudit)
            {
                var entityAudit = (IRecordAudit)destination;
                entityAudit.Auditoria.FechaModificacion = ((IRecordAudit)source).Auditoria.FechaModificacion;
                entityAudit.Auditoria.UsuarioModificacion = ((IRecordAudit)source).Auditoria.UsuarioModificacion;
            }
        }
        protected void CheckUpdateAudit(RecordAudit audit, TEntity destination)
        {
            if (destination is IRecordAudit)
            {
                var entityAudit = (IRecordAudit)destination;
                entityAudit.Auditoria.FechaModificacion = audit.FechaModificacion;
                entityAudit.Auditoria.UsuarioModificacion = audit.UsuarioModificacion;
            }
        }
        protected IQueryable<TEntity> AggregateIncludes(IQueryable<TEntity> queryConstruct, List<Expression<Func<TEntity, object>>> includes) => includes.Aggregate(queryConstruct, (query, include) => query.Include(include));
        protected IQueryable<TEntity> AggregateIncludes(IQueryable<TEntity> queryConstruct, List<string> includes) => includes.Aggregate(queryConstruct, (query, include) => query.Include(include));
        protected IQueryable<TEntity> AggregateFilterGenerics(IQueryable<TEntity> queryConstruct, Dictionary<string, object> filterGenerics)
        {
            if (filterGenerics.Any())
            {
                Expression predicateBody = null;
                var pe = Expression.Parameter(typeof(TEntity), "x");
                var contains = typeof(string).GetMethod("Contains", new[] { typeof(string) });

                foreach (var filterGeneric in filterGenerics)
                {
                    var filterTypeof = typeof(TEntity).GetProperty(filterGeneric.Key, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                    var left = Expression.Property(pe, filterTypeof);
                    var right = Expression.Constant(filterGeneric.Value, filterTypeof.PropertyType);

                    if (filterTypeof.PropertyType != typeof(string))
                    {
                        predicateBody = (predicateBody == null)
                            ? Expression.Equal(left, right)
                            : Expression.AndAlso(predicateBody, Expression.Equal(left, right));
                    }
                    else
                    {
                        predicateBody = (predicateBody == null)
                            ? (Expression)Expression.Call(left, contains, right)
                            : Expression.AndAlso(predicateBody, Expression.Call(left, contains, right));
                    }
                }

                if (predicateBody != null)
                {
                    var whereCallExpression = Expression.Call(
                        typeof(Queryable),
                        "Where",
                        new[] { _dbSet.AsQueryable().ElementType },
                        _dbSet.AsQueryable().Expression,
                        Expression.Lambda<Func<TEntity, bool>>(predicateBody, pe));

                    queryConstruct = queryConstruct.Provider.CreateQuery<TEntity>(whereCallExpression);
                }
            }
            return queryConstruct;
        }
        protected IQueryable<TEntity> AggregateSortManual(IQueryable<TEntity> queryConstruct, ISorter sorter)
        {
            if (!string.IsNullOrEmpty(sorter.Name))
            {
                var sortColumn = sorter.Name.First().ToString().ToUpper() + sorter.Name.Substring(1);
                var sortIsAsc = sorter.IsAscending;
                queryConstruct = sortIsAsc
                    ? queryConstruct.OrderByAsc(sortColumn)
                    : queryConstruct.OrderByDesc(sortColumn);
            }
            return queryConstruct;
        }
        protected bool AggregatePager(IPager pager, out int? skip, out int? take)
        {
            var applyPager = false;
            skip = null;
            take = null;

            if ((pager.PageNumber.GetValueOrDefault(0) > 0) && (pager.PageSize.GetValueOrDefault(0) > 0))
            {
                applyPager = true;
                skip = (pager.PageNumber.Value - 1) * pager.PageSize.Value;
                take = pager.PageSize.Value;
            }

            return applyPager;
        }
        protected ISpecification<TEntity> InitializeSpecification(ISpecification<TEntity> specification)
        {
            if (specification == null)
                specification = new SpecificationBase<TEntity>();
            return specification;
        }
        #endregion

        #region Protected Virtuals
        protected virtual IQueryable<TEntity> SetDefaultIncludes(IQueryable<TEntity> queryConstruct)
        {
            return queryConstruct;
        }
        protected virtual IQueryable<TEntity> SetSpecificFilters(IQueryable<TEntity> queryConstruct, ISpecification<TEntity> specification)
        {
            return queryConstruct;
        }
        #endregion
    }
}
