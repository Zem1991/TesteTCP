using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tcp.Teste.Domain.Configurations;
using Tcp.Teste.Infraestrutura.Configurations;

namespace Tcp.Teste
{
	public class Program
	{
		public static void Main(string[] args)
		{
            CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					//TODO:
					//ServiceBindings.Configure(builder.Services);
					//RepositoryBindings.Configure(builder.Services);
					webBuilder.UseStartup<Startup>();
				});
	}
}
