using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryDBWPFCore.Domain.Services
{
    public interface IDataServices<T>
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> Get(int id);

        Task<T> Create(T entity);

        Task<T> Update(int id, T entity);

        Task<bool> Delete(int id);
    }
}
