using System;

namespace BattleNetSharp.D2.Resurrected
{
	// Token: 0x02000B25 RID: 2853
	public static class LadderDb
	{
		// Token: 0x0600C023 RID: 49187 RVA: 0x004A22CB File Offset: 0x004A04CB
		static LadderDb()
		{
			LadderDb.db.Database.EnsureCreated();
		}

		// Token: 0x0600C024 RID: 49188 RVA: 0x004A22F4 File Offset: 0x004A04F4
		public static void AddItem(Ladder character)
		{
			string text = character.BattleTag + ":" + character.CharacterName;
			character.Guid = text;
			Ladder ladder = LadderDb.db.Items.Find(new object[] { text });
			bool flag = ladder == null;
			if (flag)
			{
				LadderDb.db.Items.Add(character);
			}
		}

		// Token: 0x0600C025 RID: 49189 RVA: 0x004A2356 File Offset: 0x004A0556
		public static void Save()
		{
			LadderDb.db.SaveChanges();
		}

		// Token: 0x0400925D RID: 37469
		private static LadderDbContext db = new LadderDbContext();

		// Token: 0x0400925E RID: 37470
		private static object LockObj = new object();
	}
}
