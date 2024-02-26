using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tcp.Teste.Infraestrutura.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task<TEntity> UpdateAsync(TEntity entity);
    }
}