﻿
using System.Linq.Expressions;

namespace EmployeeManagement.Domain.Interfaces; 
public interface IBaseRepository<TEntity> where TEntity : class 
{
    Task AddOneAsync(TEntity entity);
    Task ReplaceOneAsync(Expression<Func<TEntity, bool>> filterExpression,TEntity entity);
    Task DeleteAsync(Expression<Func<TEntity, bool>> filterExpression);
}
