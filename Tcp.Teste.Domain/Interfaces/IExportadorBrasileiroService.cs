using System.Collections.Generic;
using System.Threading.Tasks;
using Tcp.Teste.Infraestrutura.Context;
using Tcp.Teste.Infraestrutura.Context.Entities;

namespace Tcp.Teste.Domain.Interfaces
{
    public interface IExportadorBrasileiroService
    {
        TesteContext DbContext { get; }

        Task<ExportadorBrasileiro> CreateAsync(ExportadorBrasileiro entity);
        Task DeleteAsync(ExportadorBrasileiro entity);
        Task<List<ExportadorBrasileiro>> GetAllAsync();
        Task<ExportadorBrasileiro> GetByIdAsync(int id);
        Task<ExportadorBrasileiro> UpdateAsync(ExportadorBrasileiro entity);
    }
}