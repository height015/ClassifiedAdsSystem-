using System;
using System.Linq.Expressions;
using System.Transactions;
using Core;
using Data.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public partial class EfRepository<T> : IRepository<T> where T : BaseEntity
    {

        #region Fields
        public ApplicationDbContext _DbContext { get; set; }

        #endregion

        #region Constructor

        public EfRepository(ApplicationDbContext applicationDbContext)
        {
            _DbContext = applicationDbContext;
        }

        #endregion

        #region Utility

        #endregion

        #region Methods




        public virtual async Task<T> GetByIdAsync(int id)
        {

            if (id == 0)
                throw new ArgumentNullException();

            return await _DbContext.Set<T>().FindAsync(id);
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _DbContext.Set<T>().ToListAsync();
        }


        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _DbContext.Set<T>().Where(expression);
        }


        public virtual async Task<IList<T>> GetByIdsAsync(IList<int> ids)
        {
            if (!ids?.Any() ?? true)
                return new List<T>();

            async Task<IList<T>> getByIdsAsync()
            {
                var query = _DbContext.Set<T>();

                //get entries
                var entries = await query.Where(entry => ids.Contains(entry.Id)).ToListAsync();

                //sort by passed identifiers
                var sortedEntries = new List<T>();
                foreach (var id in ids)
                {
                    var sortedEntry = entries.Find(entry => entry.Id == id);
                    if (sortedEntry != null)
                        sortedEntries.Add(sortedEntry);
                }

                return sortedEntries;
            }

            return await getByIdsAsync();


        }



        public virtual async Task InsertAsync(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            await _DbContext.Set<T>().AddAsync(entity);
        }

        public virtual async Task InsertAsync(IList<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            using var transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
            await _DbContext.AddRangeAsync(entities);
            transaction.Complete();
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _DbContext.Set<T>().Update(entity);
        }

        public virtual void UpdateList(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            if (entities.Count() == 0)
            {
                return;
            }


            _DbContext.Set<T>().UpdateRange(entities);

        }

        public virtual void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _DbContext.Set<T>().Remove(entity);


        }

        public virtual void DeleteRange(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));


            _DbContext.Set<T>().RemoveRange(entities);

        }


        public virtual IQueryable<T> Table
        {
            get
            {
                return this._DbContext.Set<T>();
            }
        }



        #endregion

    }
}

