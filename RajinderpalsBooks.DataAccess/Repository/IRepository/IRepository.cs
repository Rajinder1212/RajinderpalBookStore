using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;  // add  using statements



namespace RajinderpalsBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);//  retrieve a category from  database by id
        // list of categories based on requirements
        IEnumerable<T> GetAll(

            Expression<Func<T, bool>> filter = null,
             Func<IQueryable<T>, IOrderedQueryable <T>> orderBy = null,
            string includeProperties = null  // usefull for foreign key references
            );
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null);
        void Add(T entity);  // add entity
        void Remove(int id); // to remove a object or category
        void Remove(T entity); // another way to remove object
        void RemoveRange(IEnumerable<T> entity); // remove   a complete range of entities
    }
}
