using System;
using System.Collections.Generic;
using D2Data;

namespace D2GameState
{
	// Token: 0x02000909 RID: 2313
	public class Config
	{
		// Token: 0x04006A57 RID: 27223
		public string AccountName;

		// Token: 0x04006A58 RID: 27224
		public string Password;

		// Token: 0x04006A59 RID: 27225
		public string CharacterName;

		// Token: 0x04006A5A RID: 27226
		public CharacterClass NewClass;

		// Token: 0x04006A5B RID: 27227
		public string Realm;

		// Token: 0x04006A5C RID: 27228
		public GameDifficulty Difficulty;

		// Token: 0x04006A5D RID: 27229
		public string GameInfo;

		// Token: 0x04006A5E RID: 27230
		public string GamePassword;

		// Token: 0x04006A5F RID: 27231
		public string RegCdKey;

		// Token: 0x04006A60 RID: 27232
		public string XpakCdKey;

		// Token: 0x04006A61 RID: 27233
		public object BattleNet;

		// Token: 0x04006A62 RID: 27234
		public Config Leader;

		// Token: 0x04006A63 RID: 27235
		public List<Config> Followers = new List<Config>();

		// Token: 0x04006A64 RID: 27236
		public Type Sequence;

		// Token: 0x04006A65 RID: 27237
		public int CastStatic = 100;

		// Token: 0x04006A66 RID: 27238
		public List<NPCCode> StaticList = new List<NPCCode>
		{
			NPCCode.Andariel,
			NPCCode.Mephisto
		};

		// Token: 0x04006A67 RID: 27239
		public SkillType PreAttackSkill = SkillType.Invalid;

		// Token: 0x04006A68 RID: 27240
		public SkillType PrimaryBossSkill = SkillType.Invalid;

		// Token: 0x04006A69 RID: 27241
		public SkillType PrimaryUntimedBossSkill = SkillType.Invalid;

		// Token: 0x04006A6A RID: 27242
		public SkillType PrimarySkill = SkillType.Invalid;

		// Token: 0x04006A6B RID: 27243
		public SkillType PrimaryUntimedSkill = SkillType.Invalid;

		// Token: 0x04006A6C RID: 27244
		public SkillType ImmuneSkill = SkillType.Invalid;

		// Token: 0x04006A6D RID: 27245
		public SkillType ImmuneUntimedSkill = SkillType.Invalid;

		// Token: 0x04006A6E RID: 27246
		public SkillType LowManaSkill = SkillType.Invalid;

		// Token: 0x04006A6F RID: 27247
		public bool MercWatch = true;

		// Token: 0x04006A70 RID: 27248
		public bool UseMerc = true;

		// Token: 0x04006A71 RID: 27249
		public bool Dodge = true;

		// Token: 0x04006A72 RID: 27250
		public ushort DodgeHP = 50;

		// Token: 0x04006A73 RID: 27251
		public ushort DodgeRange = 15;

		// Token: 0x04006A74 RID: 27252
		public ushort UseHP = 85;

		// Token: 0x04006A75 RID: 27253
		public ushort UseMP = 30;

		// Token: 0x04006A76 RID: 27254
		public ushort UseRejuvHP = 60;

		// Token: 0x04006A77 RID: 27255
		public ushort UseRejuvMP = 0;

		// Token: 0x04006A78 RID: 27256
		public ushort UseMercHP = 80;

		// Token: 0x04006A79 RID: 27257
		public ushort UseMercRejuv = 25;

		// Token: 0x04006A7A RID: 27258
		public ushort HPBuffer = 3;

		// Token: 0x04006A7B RID: 27259
		public ushort MPBuffer = 3;

		// Token: 0x04006A7C RID: 27260
		public ushort StamBuffer = 2;

		// Token: 0x04006A7D RID: 27261
		public ushort AntiBuffer = 2;

		// Token: 0x04006A7E RID: 27262
		public ushort ThawBuffer = 2;

		// Token: 0x04006A7F RID: 27263
		public ushort RejuvBuffer = 3;

		// Token: 0x04006A80 RID: 27264
		public ushort LifeChicken = 20;

		// Token: 0x04006A81 RID: 27265
		public ushort ManaChicken = 0;

		// Token: 0x04006A82 RID: 27266
		public ushort MercChicken = 0;

		// Token: 0x04006A83 RID: 27267
		public ushort TownHP = 0;

		// Token: 0x04006A84 RID: 27268
		public ushort TownMP = 0;

		// Token: 0x04006A85 RID: 27269
		public bool FastPick = false;

		// Token: 0x04006A86 RID: 27270
		public bool HealStatus = true;

		// Token: 0x04006A87 RID: 27271
		public ushort HealHP = 95;

		// Token: 0x04006A88 RID: 27272
		public ushort HealMP = 95;

		// Token: 0x04006A89 RID: 27273
		public List<ItemKind> BeltColumn = new List<ItemKind>
		{
			ItemKind.HealingPotion,
			ItemKind.HealingPotion,
			ItemKind.ManaPotion,
			ItemKind.ManaPotion
		};

		// Token: 0x04006A8A RID: 27274
		public List<byte> MinColumn = new List<byte> { 2, 2, 2, 2 };

		// Token: 0x04006A8B RID: 27275
		public ushort FirstRespecLevel = 26;

		// Token: 0x04006A8C RID: 27276
		public ushort SecondRespecLevel = 63;

		// Token: 0x04006A8D RID: 27277
		public ushort ThirdRespecLevel = 99;
	}
}
