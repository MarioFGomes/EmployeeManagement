﻿using EmployeeManagement.Domain.Interfaces;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace EmployeeManagement.Infrastructure.Repository;
public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class {
    
    private readonly IMongoCollection<TEntity> _collection;

    public BaseRepository(IMongoDatabase mongoDb, string collectionName)
    {
        MapClasses();
        _collection = mongoDb.GetCollection<TEntity>(collectionName);
    }

    public async Task AddOneAsync(TEntity entity) 
    {
        await _collection.InsertOneAsync(entity);
    }

    public async Task DeleteAsync(Expression<Func<TEntity, bool>> filterExpression) 
    {
        await _collection.DeleteOneAsync(filterExpression);
    }

    public async Task ReplaceOneAsync(Expression<Func<TEntity, bool>> filterExpression, TEntity entity) 
    {
        await _collection.ReplaceOneAsync(filterExpression, entity);
    }

    private static void MapClasses() {
        if (!BsonClassMap.IsClassMapRegistered(typeof(TEntity))) {
            BsonClassMap.TryRegisterClassMap<TEntity>(cm =>
            {
                cm.AutoMap();
                cm.SetIgnoreExtraElements(true);
            });
        }
    }
}
