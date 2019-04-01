
using Common.Helpers.ExceptionHandling;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {

        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                //context.Set<TEntity>().Add(entity);
                //context.SaveChanges();
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                //context.Set<TEntity>().Remove(entity);
                //context.SaveChanges();
                try
                {
                    var deletedEntity = context.Entry(entity);
                    deletedEntity.State = EntityState.Deleted;
                    context.SaveChanges();
                }
                catch(Exception ex)
                {
                    bool rethrow = DataAccessExceptionHandler.HandleException(ref ex);
                    if (rethrow)
                        throw ex;
                }

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
