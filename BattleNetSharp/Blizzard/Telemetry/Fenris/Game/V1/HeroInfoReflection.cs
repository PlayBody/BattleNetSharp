using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Game.V1
{
	// Token: 0x020002EB RID: 747
	public static class HeroInfoReflection
	{
		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x06004EC2 RID: 20162 RVA: 0x0012DD20 File Offset: 0x0012BF20
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeroInfoReflection.descriptor;
			}
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x0012DD38 File Offset: 0x0012BF38
		static HeroInfoReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg5IZXJvSW5mby5wcm90bxIhQmxpenphcmQuVGVsZW1ldHJ5LkZlbnJpcy5H", "YW1lLnYxGhJIZXJvTG9jYXRpb24ucHJvdG8aFEhlcm9Db21iYXRJbmZvLnBy", "b3RvGgpJdGVtLnByb3RvIsAFCghIZXJvSW5mbxIPCgdoZXJvX2lkGAEgASgJ", "EhIKCmFjY291bnRfaWQYAiABKA0SFwoPZ2FtZV9hY2NvdW50X2lkGA0gASgN", "EhAKCHBhcnR5X2lkGAMgASgJEhIKCmhlcm9fY2xhc3MYBCABKAUSEwoLdGlt", "ZV9wbGF5ZWQYBSABKA0SEgoKaGVyb19sZXZlbBgGIAEoBRJBCghsb2NhdGlv", "bhgHIAEoCzIvLkJsaXp6YXJkLlRlbGVtZXRyeS5GZW5yaXMuR2FtZS52MS5I", "ZXJvTG9jYXRpb24SRgoLY29tYmF0X2luZm8YCCABKAsyMS5CbGl6emFyZC5U", "ZWxlbWV0cnkuRmVucmlzLkdhbWUudjEuSGVyb0NvbWJhdEluZm8SEgoKc2Vz", "c2lvbl9pZBgJIAEoCRIVCg1wZXJzb25hX2luZGV4GAogASgFEhYKDmhhaXJf",
				"ZHllX2luZGV4GAsgASgFEhAKCHNub19mYWNlGBQgASgPEg8KB2NsYW5faWQY", "DCABKAQSSwoLZ2FtZV9oYW5kbGUYDiABKAsyNi5CbGl6emFyZC5UZWxlbWV0", "cnkuRmVucmlzLkdhbWUudjEuSGVyb0luZm8uR2FtZUhhbmRsZRIVCg1wYXJh", "Z29uX2xldmVsGA8gASgFEhIKCnYyX2NsYW5faWQYECABKAkSPwoOZXF1aXBw", "ZWRfaXRlbXMYESADKAsyJy5CbGl6emFyZC5UZWxlbWV0cnkuRmVucmlzLkdh", "bWUudjEuSXRlbRISCgp3b3JsZF90aWVyGBIgASgFEhAKCHBsYXRmb3JtGBMg", "ASgFGlcKCkdhbWVIYW5kbGUSFQoNbWF0Y2htYWtlcl9pZBgBIAEoBBIYChBn", "YW1lX3NlcnZlcl9ndWlkGAIgASgEEhgKEGdhbWVfaW5zdGFuY2VfaWQYAyAB", "KA0="
			}));
			HeroInfoReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				HeroLocationReflection.Descriptor,
				HeroCombatInfoReflection.Descriptor,
				ItemReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(HeroInfo), HeroInfo.Parser, new string[]
				{
					"HeroId", "AccountId", "GameAccountId", "PartyId", "HeroClass", "TimePlayed", "HeroLevel", "Location", "CombatInfo", "SessionId",
					"PersonaIndex", "HairDyeIndex", "SnoFace", "ClanId", "GameHandle", "ParagonLevel", "V2ClanId", "EquippedItems", "WorldTier", "Platform"
				}, null, null, null, new GeneratedClrTypeInfo[]
				{
					new GeneratedClrTypeInfo(typeof(HeroInfo.Types.GameHandle), HeroInfo.Types.GameHandle.Parser, new string[] { "MatchmakerId", "GameServerGuid", "GameInstanceId" }, null, null, null, null)
				})
			}));
		}

		// Token: 0x0400233F RID: 9023
		private static FileDescriptor descriptor;
	}
}
