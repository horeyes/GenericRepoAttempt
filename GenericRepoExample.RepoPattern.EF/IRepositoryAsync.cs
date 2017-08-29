using GenericRepoExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepoExample.RepoPattern
{
    public interface IRepositoryAsync<TEntity> where TEntity: class
    {
        IEnumerable<Product> Get();
        Product GetByID(Object id);
        void Insert(TEntity entity);
        void Delete(int id);
        void Delete(TEntity entityToDelete);
        void Update(TEntity entityToUpdate);
        void Save();


    }
}
