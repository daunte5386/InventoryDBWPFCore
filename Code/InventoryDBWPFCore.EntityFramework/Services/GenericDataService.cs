using InventoryDBWPFCore.Domain.Models;
using InventoryDBWPFCore.Domain.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryDBWPFCore.EntityFramework.Services
{
    public class GenericDataService<T> : IDataServices<T> where T : DomainObject
    {
        private readonly InventoryDbContextFactory _contextFactory;

        public GenericDataService(InventoryDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<T> Create(T entity)
        {
            using(DataContext context = _contextFactory.CreateDbContext())
            {
                EntityEntry<T> createdResult = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();

                return createdResult.Entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (DataContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();

                return true;
            }
        }

        public async Task<T> Get(int id)
        {
            using (DataContext context = _contextFactory.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);                
                return entity;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using(DataContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<T> entities = await context.Set<T>().ToListAsync();
                return entities;
            }
        }

        public async Task<T> Update(int id, T entity)
        {
            using(DataContext context = _contextFactory.CreateDbContext())
            {
                entity.Id = id;

                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();

                return entity;
            }
        }
    }
}
