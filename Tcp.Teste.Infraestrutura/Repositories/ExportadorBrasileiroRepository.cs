using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tcp.Teste.Infraestrutura.Context.Entities;
using Tcp.Teste.Infraestrutura.Interfaces;

namespace Tcp.Teste.Infraestrutura.Repositories
{
    public class ExportadorBrasileiroRepository : RepositoryBase<ExportadorBrasileiro>, IExportadorBrasileiroRepository
    {
        public ExportadorBrasileiroRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
