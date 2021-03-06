﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarCare.Core.IRepositories
{
    public interface IRepository<T>
    {
        Task<T> PutEntity(int id, string values);
        Task<T> PostEntity(T Entity);
        Task<List<T>> PostEntities(string values);
        Task<T> DeleteEntity(int id);
        ValueTask<T> FindEntity(int id);
        IQueryable<T> GetEntities();
        IQueryable<T> GetIncludableEntities<EntityToInclude>(params Expression<Func<T, EntityToInclude>>[] navigationPropertyPaths);

    }
}
