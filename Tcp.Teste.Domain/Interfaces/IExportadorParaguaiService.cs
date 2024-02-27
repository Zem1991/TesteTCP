using System.Collections.Generic;
using System.Threading.Tasks;
using Tcp.Teste.Infraestrutura.Context;
using Tcp.Teste.Infraestrutura.Context.Entities;

namespace Tcp.Teste.Domain.Interfaces
{
    public interface IExportadorParaguaiService
    {
        TesteContext DbContext { get; }

        Task<ExportadorParaguai> CreateAsync(ExportadorParaguai entity);
        Task DeleteAsync(int id);
        Task<List<ExportadorParaguai>> GetAllAsync();
        Task<ExportadorParaguai> GetByIdAsync(int id);
        Task<ExportadorParaguai> UpdateAsync(ExportadorParaguai entity);
    }
}