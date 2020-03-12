using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VideoClipComposer.Abstractions.Data.Repositories
{
    public interface IDataRepository<TItem>
        where TItem : class
    {
        Task<TItem> FindFirstAsync();
        Task<int> CountAsync();
        Task<TItem> GetByIdAsync(int id);
        Task<TItem> AddAsync(TItem item);
        Task UpdateAsync(TItem item);
        Task DeleteAsync(TItem item);
    }
}
