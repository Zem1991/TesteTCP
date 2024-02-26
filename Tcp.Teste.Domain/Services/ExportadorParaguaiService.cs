using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tcp.Teste.Domain.Interfaces;
using Tcp.Teste.Infraestrutura.Context;
using Tcp.Teste.Infraestrutura.Context.Entities;
using Tcp.Teste.Infraestrutura.Repositories;

namespace Tcp.Teste.Domain.Services
{
    public class ExportadorParaguaiService : IExportadorParaguaiService
    {
        public ExportadorParaguaiService(TesteContext dbContext)
        {
            DbContext = dbContext;
        }

        public TesteContext DbContext { get; }

        public async Task<List<ExportadorParaguai>> GetAllAsync()
        {
            ExportadorParaguaiRepository repo = new ExportadorParaguaiRepository(DbContext);
            return await repo.GetAllAsync();
        }

        public async Task<ExportadorParaguai> GetByIdAsync(int id)
        {
            ExportadorParaguaiRepository repo = new ExportadorParaguaiRepository(DbContext);
            return await repo.GetByIdAsync(id);
        }

        public async Task<ExportadorParaguai> CreateAsync(ExportadorParaguai entity)
        {
            ExportadorParaguaiRepository repo = new ExportadorParaguaiRepository(DbContext);
            return await repo.CreateAsync(entity);
        }

        public async Task<ExportadorParaguai> UpdateAsync(ExportadorParaguai entity)
        {
            ExportadorParaguaiRepository repo = new ExportadorParaguaiRepository(DbContext);
            return await repo.UpdateAsync(entity);
        }

        public async Task DeleteAsync(ExportadorParaguai entity)
        {
            ExportadorParaguaiRepository repo = new ExportadorParaguaiRepository(DbContext);
            await repo.DeleteAsync(entity);
        }
    }
}
