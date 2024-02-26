using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tcp.Teste.Infraestrutura.Context.Entities;

namespace Tcp.Teste.Infraestrutura.Context
{
	public class TesteContext : DbContext
	{
		public string DbPath { get; }

		public TesteContext()
		{
			var path = Environment.CurrentDirectory;
			DbPath = System.IO.Path.Join(path, "teste.db");
		}

        public DbSet<ExportadorBrasileiro> ExportadorBrasileiro { get; set; }
        public DbSet<ExportadorParaguai> ExportadorParaguai { get; set; }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseSqlite($"Data Source={DbPath}");
	}
}
