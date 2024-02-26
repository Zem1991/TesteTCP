using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Tcp.Teste.Infraestrutura.Interfaces;
using Tcp.Teste.Infraestrutura.Repositories;

namespace Tcp.Teste.Infraestrutura.Configurations
{
    public class RepositoryBindings
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            services.AddScoped<IExportadorBrasileiroRepository, ExportadorBrasileiroRepository>();
            services.AddScoped<IExportadorParaguaiRepository, ExportadorParaguaiRepository>();
        }
    }
}
