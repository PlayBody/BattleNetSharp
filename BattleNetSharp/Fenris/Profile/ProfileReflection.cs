using System;
using Fenris.Hero;
using Fenris.Items;
using Google.Protobuf.Reflection;

namespace Fenris.Profile
{
	// Token: 0x02000131 RID: 305
	public static class ProfileReflection
	{
		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001EA9 RID: 7849 RVA: 0x00075D44 File Offset: 0x00073F44
		public static FileDescriptor Descriptor
		{
			get
			{
				return ProfileReflection.descriptor;
			}
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x00075D5C File Offset: 0x00073F5C
		static ProfileReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg1Qcm9maWxlLnByb3RvEg5GZW5yaXMuUHJvZmlsZRoLSXRlbXMucHJvdG8a", "EEhlcm9Db21tb24ucHJvdG8iOgoJQ2xhc3NJbmZvEhMKCHBsYXl0aW1lGAEg", "ASgEOgEwEhgKDWhpZ2hlc3RfbGV2ZWwYAiABKA06ATAiIgoMQWN0aXZlU2tp", "bGxzEhIKCnNub19za2lsbHMYASADKA8iTQoKS2lsbGVySW5mbxIWCgpzbm9f", "a2lsbGVyGAEgASgFOgItMRIOCgZyYXJpdHkYAiABKA0SFwoPcmFyZV9uYW1l", "X2diaWRzGAMgAygFIowGCgtIZXJvUHJvZmlsZRIXCg9tb25zdGVyc19raWxs", "ZWQYASABKAQSFQoNZWxpdGVzX2tpbGxlZBgCIAEoBBIWCg5nb2xkX2NvbGxl", "Y3RlZBgDIAEoBBIVCg1oaWdoZXN0X2xldmVsGAQgASgNEhMKC2NyZWF0ZV90", "aW1lGAYgASgNEhIKCml0ZW1fcG93ZXIYDSABKA0SFQoNcmVzaXN0X3NoYWRv", "dxgOIAEoDRITCgtyZXNpc3RfZmlyZRgPIAEoDRIYChByZXNpc3RfbGlnaHRu",
				"aW5nGBAgASgNEhUKDXJlc2lzdF9wb2lzb24YESABKA0SEwoLcmVzaXN0X2Nv", "bGQYEiABKA0SKQoJZXF1aXBtZW50GBMgASgLMhYuRmVucmlzLkl0ZW1zLkl0", "ZW1MaXN0EjcKEXNub19hY3RpdmVfc2tpbGxzGBQgASgLMhwuRmVucmlzLlBy", "b2ZpbGUuQWN0aXZlU2tpbGxzEhIKCmRlYXRoX3RpbWUYFiABKA0SLwoLa2ls", "bGVyX2luZm8YFyABKAsyGi5GZW5yaXMuUHJvZmlsZS5LaWxsZXJJbmZvEhkK", "EXNub19raWxsX2xvY2F0aW9uGBggASgNEg8KB2hlcm9faWQYGyABKAwSEQoJ", "dG91Z2huZXNzGCcgASgCEg8KB2hlYWxpbmcYKCABKAISFgoOc2Vhc29uX2Ny", "ZWF0ZWQYKSABKA0SLgoMcGxheWVyX3RpdGxlGCogASgLMhguRmVucmlzLkhl", "cm8uUGxheWVyVGl0bGUSFAoMcGxheWVyX2ZsYWdzGCsgASgNEhEKCXNub19j", "bGFzcxgsIAEoDRIwCg10cmFuc21vZ19zbG90GC0gAygLMhkuRmVucmlzLkhl",
				"cm8uVHJhbnNtb2dTbG90EjYKEHZpc3VhbF9lcXVpcG1lbnQYLiABKAsyHC5G", "ZW5yaXMuSGVyby5WaXN1YWxFcXVpcG1lbnQSGQoRY2FtcGFpZ25fcHJvZ3Jl", "c3MYLyABKAISFAoMcHJpdmFjeV9mbGFnGDAgASgIIj0KD0hlcm9Qcm9maWxl", "TGlzdBIqCgVoZXJvcxgBIAMoCzIbLkZlbnJpcy5Qcm9maWxlLkhlcm9Qcm9m", "aWxlIrMBCg9IZXJvTWluaVByb2ZpbGUSDwoHaGVyb19pZBgBIAEoDBIRCglo", "ZXJvX25hbWUYAiABKAkSFwoPaGVyb19nYmlkX2NsYXNzGAMgASgPEhIKCmhl", "cm9fZmxhZ3MYBCABKA0SEgoKaGVyb19sZXZlbBgFIAEoDRI7ChVoZXJvX3Zp", "c3VhbF9lcXVpcG1lbnQYBiABKAsyHC5GZW5yaXMuSGVyby5WaXN1YWxFcXVp", "cG1lbnQijgUKDkFjY291bnRQcm9maWxlEhoKD21vbnN0ZXJzX2tpbGxlZBgG", "IAEoBDoBMBIYCg1lbGl0ZXNfa2lsbGVkGAcgASgEOgEwEhkKDmdvbGRfY29s",
				"bGVjdGVkGAggASgEOgEwEh4KFmhpZ2hlc3RfaGFyZGNvcmVfbGV2ZWwYCSAB", "KAQSIAoYaGFyZGNvcmVfbW9uc3RlcnNfa2lsbGVkGAogASgEEi4KC2NsYXNz", "X2RydWlkGAsgASgLMhkuRmVucmlzLlByb2ZpbGUuQ2xhc3NJbmZvEjEKDmNs", "YXNzX3NvcmNlcmVyGAwgASgLMhkuRmVucmlzLlByb2ZpbGUuQ2xhc3NJbmZv", "EjIKD2NsYXNzX2JhcmJhcmlhbhgNIAEoCzIZLkZlbnJpcy5Qcm9maWxlLkNs", "YXNzSW5mbxIuCgtjbGFzc19yb2d1ZRgOIAEoCzIZLkZlbnJpcy5Qcm9maWxl", "LkNsYXNzSW5mbxI0ChFjbGFzc19uZWNyb21hbmNlchgPIAEoCzIZLkZlbnJp", "cy5Qcm9maWxlLkNsYXNzSW5mbxIYCg1oaWdoZXN0X2xldmVsGB8gASgEOgEw", "EiEKFmJsb29kX3NoYXJkc19jb2xsZWN0ZWQYICABKAQ6ATASLwoGaGVyb2Vz", "GCIgAygLMh8uRmVucmlzLlByb2ZpbGUuSGVyb01pbmlQcm9maWxlEhQKCXNl",
				"YXNvbl9pZBgjIAEoDToBMBIdChJkdW5nZW9uc19jb21wbGV0ZWQYJCABKAQ6", "ATASGQoOcGxheWVyc19raWxsZWQYJSABKAQ6ATASGAoNYm9zc2VzX2tpbGxl", "ZBgmIAEoBDoBMBIUCgxwcml2YWN5X2ZsYWcYJyABKAg="
			}));
			ProfileReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				ItemsReflection.Descriptor,
				HeroCommonReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ClassInfo), ClassInfo.Parser, new string[] { "Playtime", "HighestLevel" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ActiveSkills), ActiveSkills.Parser, new string[] { "SnoSkills" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(KillerInfo), KillerInfo.Parser, new string[] { "SnoKiller", "Rarity", "RareNameGbids" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(HeroProfile), HeroProfile.Parser, new string[]
				{
					"MonstersKilled", "ElitesKilled", "GoldCollected", "HighestLevel", "CreateTime", "ItemPower", "ResistShadow", "ResistFire", "ResistLightning", "ResistPoison",
					"ResistCold", "Equipment", "SnoActiveSkills", "DeathTime", "KillerInfo", "SnoKillLocation", "HeroId", "Toughness", "Healing", "SeasonCreated",
					"PlayerTitle", "PlayerFlags", "SnoClass", "TransmogSlot", "VisualEquipment", "CampaignProgress", "PrivacyFlag"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(HeroProfileList), HeroProfileList.Parser, new string[] { "Heros" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(HeroMiniProfile), HeroMiniProfile.Parser, new string[] { "HeroId", "HeroName", "HeroGbidClass", "HeroFlags", "HeroLevel", "HeroVisualEquipment" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AccountProfile), AccountProfile.Parser, new string[]
				{
					"MonstersKilled", "ElitesKilled", "GoldCollected", "HighestHardcoreLevel", "HardcoreMonstersKilled", "ClassDruid", "ClassSorcerer", "ClassBarbarian", "ClassRogue", "ClassNecromancer",
					"HighestLevel", "BloodShardsCollected", "Heroes", "SeasonId", "DungeonsCompleted", "PlayersKilled", "BossesKilled", "PrivacyFlag"
				}, null, null, null, null)
			}));
		}

		// Token: 0x04000D3E RID: 3390
		private static FileDescriptor descriptor;
	}
}
