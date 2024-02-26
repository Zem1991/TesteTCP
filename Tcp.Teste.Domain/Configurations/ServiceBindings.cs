using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Tcp.Teste.Domain.Interfaces;
using Tcp.Teste.Domain.Services;

namespace Tcp.Teste.Domain.Configurations
{
    public class ServiceBindings
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IExportadorBrasileiroService, ExportadorBrasileiroService>();
            services.AddScoped<IExportadorParaguaiService, ExportadorParaguaiService>();
        }
    }
}
