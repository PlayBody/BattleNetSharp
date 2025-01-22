using System;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace BattleNetSharp.D2.Resurrected
{
	// Token: 0x02000B23 RID: 2851
	internal class LadderDbContext : DbContext
	{
		// Token: 0x1700395C RID: 14684
		// (get) Token: 0x0600C010 RID: 49168 RVA: 0x004A21F8 File Offset: 0x004A03F8
		// (set) Token: 0x0600C011 RID: 49169 RVA: 0x004A2200 File Offset: 0x004A0400
		public DbSet<Ladder> Items { get; set; }

		// Token: 0x0600C012 RID: 49170 RVA: 0x004A220C File Offset: 0x004A040C
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string text = new SqliteConnectionStringBuilder
			{
				DataSource = "ladder.sqlite",
				Mode = 0
			}.ToString();
			SqliteDbContextOptionsBuilderExtensions.UseSqlite(optionsBuilder, text, null);
		}
	}
}
