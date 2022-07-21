using System.Linq.Expressions;
using Core;

namespace Data
{
    public interface IRepository<T> where T : BaseEntity
    {

        Task<T> GetByIdAsync(int id);

        Task<IList<T>> GetByIdsAsync(IList<int> ids);

        Task<IEnumerable<T>> GetAll();

        IEnumerable<T> Find(Expression<Func<T, bool>> expression);


        Task InsertAsync(T entity);

        Task InsertAsync(IList<T> entities);

        void Update(T entity);


        void UpdateList(IEnumerable<T> entities);


        void Delete(T entity);

        void DeleteRange(IEnumerable<T> entities);

        /// <summary>
        /// Gets a table
        /// </summary>
        IQueryable<T> Table { get; }




    }
}