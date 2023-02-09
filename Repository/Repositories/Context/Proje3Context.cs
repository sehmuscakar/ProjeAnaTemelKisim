using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Context
{
	public class Proje3Context:DbContext
	{
		public DbSet<Tanıtım> Tanıtıms { get; set; }
		public DbSet<Notlar> Notlars { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				//IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
				//optionsBuilder.UseSqlServer(configuration.GetConnectionString("ArvesoftConnectionStringProje1"));

				IConfigurationRoot configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();//ConfigurationBuilder,AddJsonFile bu ikisi için iki ayrı kütüphane gerekkli
				optionsBuilder.UseSqlServer(configuration.GetConnectionString("ArvesoftConnectionStringProje3"));
			}
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
		
		}
	}
}
