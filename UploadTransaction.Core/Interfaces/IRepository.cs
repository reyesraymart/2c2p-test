using System.Linq.Expressions;
using UploadTransaction.Core.Entities;
using UploadTransaction.Core.Interfaces.Filters;

namespace UploadTransaction.Core.Interfaces;

public interface IRepository<TEntity>
    where TEntity : class, IEntity
{
    IQueryable<TEntity> Find<TFilterSpecification, TRequestData>(TRequestData requestData)
        where TFilterSpecification : IFilterSpecification<TRequestData, TEntity>, new()
        where TRequestData : class, IRequestData;

    IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

    void Add(IEnumerable<TEntity> entity);

    void Add(TEntity entity);

    void Update(TEntity entity);
}