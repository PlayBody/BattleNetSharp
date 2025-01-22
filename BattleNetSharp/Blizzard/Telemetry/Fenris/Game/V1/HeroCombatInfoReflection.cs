using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Game.V1
{
	// Token: 0x020002E9 RID: 745
	public static class HeroCombatInfoReflection
	{
		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x06004E87 RID: 20103 RVA: 0x0012CA28 File Offset: 0x0012AC28
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeroCombatInfoReflection.descriptor;
			}
		}

		// Token: 0x06004E88 RID: 20104 RVA: 0x0012CA40 File Offset: 0x0012AC40
		static HeroCombatInfoReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChRIZXJvQ29tYmF0SW5mby5wcm90bxIhQmxpenphcmQuVGVsZW1ldHJ5LkZl", "bnJpcy5HYW1lLnYxIvIHCg5IZXJvQ29tYmF0SW5mbxIVCg1hdHRhY2tfcmF0", "aW5nGAEgASgREhYKDmRlZmVuc2VfcmF0aW5nGAIgASgREhwKFGVmZmVjdGl2", "ZV9pdGVtX3Bvd2VyGAMgASgREhgKEHRvdGFsX2l0ZW1fcG93ZXIYBCABKBES", "RwoGdGFsZW50GAUgAygLMjcuQmxpenphcmQuVGVsZW1ldHJ5LkZlbnJpcy5H", "YW1lLnYxLkhlcm9Db21iYXRJbmZvLlBvd2VyEkYKBXNraWxsGAYgAygLMjcu", "QmxpenphcmQuVGVsZW1ldHJ5LkZlbnJpcy5HYW1lLnYxLkhlcm9Db21iYXRJ", "bmZvLlBvd2VyEh0KFXBvdGlvbl9pc19vbl9jb29sZG93bhgHIAEoCBJICgdl", "bmNoYW50GAggAygLMjcuQmxpenphcmQuVGVsZW1ldHJ5LkZlbnJpcy5HYW1l", "LnYxLkhlcm9Db21iYXRJbmZvLlBvd2VyElQKE2NsYXNzX3Bhc3NpdmVfc2tp",
				"bGwYCSADKAsyNy5CbGl6emFyZC5UZWxlbWV0cnkuRmVucmlzLkdhbWUudjEu", "SGVyb0NvbWJhdEluZm8uUG93ZXISFAoMcG90aW9uX2NvdW50GAogASgREhgK", "EG1heF9wb3Rpb25fY291bnQYCyABKBESEwoLcG90aW9uX3RpZXIYDCABKBES", "GQoRZHJ1aWRfc3Bpcml0X2JvbmQYDSABKBEajAEKBVBvd2VyEhEKCXBvd2Vy", "X3NubxgBIAEoERITCgtwb3dlcl9yYW5rcxgDIAEoDRJbCgR0eXBlGAQgASgO", "MjsuQmxpenphcmQuVGVsZW1ldHJ5LkZlbnJpcy5HYW1lLnYxLkhlcm9Db21i", "YXRJbmZvLlBvd2VyVHlwZToQUE9XRVJfVFlQRV9TS0lMTCK5AgoJUG93ZXJU", "eXBlEhQKEFBPV0VSX1RZUEVfU0tJTEwQABIVChFQT1dFUl9UWVBFX1RBTEVO", "VBABEhYKElBPV0VSX1RZUEVfRU5DSEFOVBACEigKJFBPV0VSX1RZUEVfQ0xB", "U1NfUEFTU0lWRV9TS0lMTF9NSU5PUhADEigKJFBPV0VSX1RZUEVfQ0xBU1Nf",
				"UEFTU0lWRV9TS0lMTF9NQUpPUhAEEiIKHlBPV0VSX1RZUEVfQ0xBU1NfUEFT", "U0lWRV9TS0lMTBAFEiMKH1BPV0VSX1RZUEVfUk9HVUVfU1BFQ0lBTElaQVRJ", "T04QBhIfChtQT1dFUl9UWVBFX1dFQVBPTl9FWFBFUlRJU0UQBxIpCiVQT1dF", "Ul9UWVBFX05FQ1JPTUFOQ0VSX1NQRUNJQUxJWkFUSU9OEAg="
			}));
			HeroCombatInfoReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(HeroCombatInfo), HeroCombatInfo.Parser, new string[]
				{
					"AttackRating", "DefenseRating", "EffectiveItemPower", "TotalItemPower", "Talent", "Skill", "PotionIsOnCooldown", "Enchant", "ClassPassiveSkill", "PotionCount",
					"MaxPotionCount", "PotionTier", "DruidSpiritBond"
				}, null, new Type[] { typeof(HeroCombatInfo.Types.PowerType) }, null, new GeneratedClrTypeInfo[]
				{
					new GeneratedClrTypeInfo(typeof(HeroCombatInfo.Types.Power), HeroCombatInfo.Types.Power.Parser, new string[] { "PowerSno", "PowerRanks", "Type" }, null, null, null, null)
				})
			}));
		}

		// Token: 0x04002314 RID: 8980
		private static FileDescriptor descriptor;
	}
}
