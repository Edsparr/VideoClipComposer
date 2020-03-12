using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VideoClipComposer.Abstractions.Data.Repositories;

namespace VideoClipComposer.Infrastructure.Data.Repositories
{
    public abstract class DataRepositoryBase<TItem> : IDataRepository<TItem>
        where TItem : class
    {
        protected readonly DbContext dbContext;

        public DataRepositoryBase(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<TItem> FindFirstAsync()
        {
            return await dbContext.Set<TItem>().FirstAsync();
        }
        public async Task<int> CountAsync()
        {
            return await dbContext.Set<TItem>().CountAsync();
        }

        public virtual async Task<TItem> GetByIdAsync(int id)
        {
            return await dbContext.Set<TItem>().FindAsync(id);
        }

        public async Task<TItem> AddAsync(TItem item)
        {
            await dbContext.AddAsync(item);
            await dbContext.SaveChangesAsync();
            
            return item;
        }

        public async Task UpdateAsync(TItem item)
        {
            dbContext.Entry(item).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(TItem item)
        {
            dbContext.Set<TItem>().Remove(item);
            await dbContext.SaveChangesAsync();
        }
    }
}
