using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tcp.Teste.Infraestrutura.Context.Entities;

namespace Tcp.Teste.Infraestrutura.Repositories
{
    public class ExportadorParaguaiRepository : RepositoryBase<ExportadorParaguai>
    {
        public ExportadorParaguaiRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
