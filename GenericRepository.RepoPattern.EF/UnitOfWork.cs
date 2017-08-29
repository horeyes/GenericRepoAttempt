using GenericRepoExample.DAL;
using GenericRepoExample.Models;
using GenericRepoExample.RepoPattern.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepository.RepoPattern.EF
{
    class UnitOfWork
    {
        private DataContext context;
        private GenericRepository<Product> productRepository;

        public GenericRepository<Product> ProductRepository
        {
            get
            {
                if(this.productRepository == null)
                {
                    this.productRepository = new GenericRepository<Product>(context);
                }

                return productRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
