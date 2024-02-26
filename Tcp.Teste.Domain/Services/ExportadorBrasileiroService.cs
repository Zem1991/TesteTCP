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
    public class ExportadorBrasileiroService : IExportadorBrasileiroService
    {
        public ExportadorBrasileiroService(TesteContext dbContext)
        {
            DbContext = dbContext;
        }

        public TesteContext DbContext { get; }

        public async Task<List<ExportadorBrasileiro>> GetAllAsync()
        {
            ExportadorBrasileiroRepository repo = new ExportadorBrasileiroRepository(DbContext);
            return await repo.GetAllAsync();
        }

        public async Task<ExportadorBrasileiro> GetByIdAsync(int id)
        {
            ExportadorBrasileiroRepository repo = new ExportadorBrasileiroRepository(DbContext);
            return await repo.GetByIdAsync(id);
        }

        public async Task<ExportadorBrasileiro> CreateAsync(ExportadorBrasileiro entity)
        {
            ExportadorBrasileiroRepository repo = new ExportadorBrasileiroRepository(DbContext);
            return await repo.CreateAsync(entity);
        }

        public async Task<ExportadorBrasileiro> UpdateAsync(ExportadorBrasileiro entity)
        {
            ExportadorBrasileiroRepository repo = new ExportadorBrasileiroRepository(DbContext);
            return await repo.UpdateAsync(entity);
        }

        public async Task DeleteAsync(ExportadorBrasileiro entity)
        {
            ExportadorBrasileiroRepository repo = new ExportadorBrasileiroRepository(DbContext);
            await repo.DeleteAsync(entity);
        }
    }
}
