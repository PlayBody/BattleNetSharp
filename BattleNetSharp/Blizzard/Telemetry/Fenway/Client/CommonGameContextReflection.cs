using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenway.Client
{
	// Token: 0x02000325 RID: 805
	public static class CommonGameContextReflection
	{
		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x0600543F RID: 21567 RVA: 0x001457E4 File Offset: 0x001439E4
		public static FileDescriptor Descriptor
		{
			get
			{
				return CommonGameContextReflection.descriptor;
			}
		}

		// Token: 0x06005440 RID: 21568 RVA: 0x001457FC File Offset: 0x001439FC
		static CommonGameContextReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[] { "Chljb21tb25fZ2FtZV9jb250ZXh0LnByb3RvEiBCbGl6emFyZC5UZWxlbWV0", "cnkuRmVud2F5LkNsaWVudCIhCgVMZXZlbBIKCgJpZBgBIAEoDRIMCgRuYW1l", "GAIgASgJIrMCCgtHYW1lQ29udGV4dBIRCglnYW1lX3R5cGUYASABKAkSFwoP", "Z2FtZV9kaWZmaWN1bHR5GAIgASgJEhQKDGlzX2V4cGFuc2lvbhgDIAEoCBIR", "Cglpc19sYWRkZXIYBCABKAgSFgoOY29tcGxldGVkX2dhbWUYBSABKAgSFgoO", "Y29tcGxldGluZ19hY3QYBiABKA0SEwoLcHJlc2V0X25hbWUYByABKAkSEwoL", "aW5fZnJvbnRlbmQYCCABKAgSPgoNY3VycmVudF9sZXZlbBgJIAEoCzInLkJs", "aXp6YXJkLlRlbGVtZXRyeS5GZW53YXkuQ2xpZW50LkxldmVsEhAKCHBsYXll", "cl94GAogASgNEhAKCHBsYXllcl95GAsgASgNEhEKCWdhbWVfc2VlZBgMIAEo", "DQ==" }));
			CommonGameContextReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Level), Level.Parser, new string[] { "Id", "Name" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameContext), GameContext.Parser, new string[]
				{
					"GameType", "GameDifficulty", "IsExpansion", "IsLadder", "CompletedGame", "CompletingAct", "PresetName", "InFrontend", "CurrentLevel", "PlayerX",
					"PlayerY", "GameSeed"
				}, null, null, null, null)
			}));
		}

		// Token: 0x0400263F RID: 9791
		private static FileDescriptor descriptor;
	}
}
