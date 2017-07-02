using System;
using DataAccess.EF.Model;
using Microsoft.EntityFrameworkCore;

namespace DataAccessTest.EF
{
	public class EFContext : DbContext
	{
		public EFContext(string databaseName)
		{
			DatabaseName = databaseName;
		}

		public string DatabaseName { get; set; }

		public DbSet<SampleEntity> SampleEntities { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite($"Filename={DatabaseName}");
		}
	}
}
