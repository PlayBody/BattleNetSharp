using System;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace BattleNetSharp.D2.Resurrected
{
	// Token: 0x02000B20 RID: 2848
	internal class ItemDbContext : DbContext
	{
		// Token: 0x17003959 RID: 14681
		// (get) Token: 0x0600C000 RID: 49152 RVA: 0x004A1EF0 File Offset: 0x004A00F0
		// (set) Token: 0x0600C001 RID: 49153 RVA: 0x004A1EF8 File Offset: 0x004A00F8
		public DbSet<Item> Items { get; set; }

		// Token: 0x0600C002 RID: 49154 RVA: 0x004A1F04 File Offset: 0x004A0104
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string text = new SqliteConnectionStringBuilder
			{
				DataSource = "items.sqlite",
				Mode = 0
			}.ToString();
			// [Ares] should be review
//			SqliteDbContextOptionsBuilderExtensions.UseSqlite(optionsBuilder, text, null);
		}
	}
}
