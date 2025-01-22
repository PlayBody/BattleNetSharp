using System;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry.Fenris.Game.V1
{
	// Token: 0x020002F1 RID: 753
	public static class ItemReflection
	{
		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x06004F74 RID: 20340 RVA: 0x00131120 File Offset: 0x0012F320
		public static FileDescriptor Descriptor
		{
			get
			{
				return ItemReflection.descriptor;
			}
		}

		// Token: 0x06004F75 RID: 20341 RVA: 0x00131138 File Offset: 0x0012F338
		static ItemReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CgpJdGVtLnByb3RvEiFCbGl6emFyZC5UZWxlbWV0cnkuRmVucmlzLkdhbWUu", "djEaGk5pZ2h0bWFyZUR1bmdlb25JbmZvLnByb3RvIoQDCgRJdGVtEhIKCnNu", "b19oYW5kbGUYASABKBESEgoKaXRlbV9wb3dlchgCIAEoERIVCg1xdWFsaXR5", "X2xldmVsGAMgASgREiEKGWF0dGFja19kZWZlbnNlX2JvbnVzX3JvbGwYBCAB", "KAISEQoJYm9keV9zbG90GAUgASgREg8KB2l0ZW1faWQYBiABKAkSEQoJZ2Vu", "ZXJhdG9yGAcgASgMEh0KFWl0ZW1fcXVhbGl0eV9tb2RpZmllchgIIAEoERIb", "ChNzbm9fbGVnZW5kYXJ5X2FmZml4GAkgASgREhgKEHNub19pbWJ1ZWRfYWZm", "aXgYCiABKBESGgoSc25vX3JlcGxhY2VkX2FmZml4GAsgASgRElcKFm5pZ2h0", "bWFyZV9kdW5nZW9uX2luZm8YDCABKAsyNy5CbGl6emFyZC5UZWxlbWV0cnku", "RmVucmlzLkdhbWUudjEuTmlnaHRtYXJlRHVuZ2VvbkluZm8SGAoQaXRlbV9w",
				"b3dlcl9ib251cxgNIAEoEQ=="
			}));
			ItemReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { NightmareDungeonInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Item), Item.Parser, new string[]
				{
					"SnoHandle", "ItemPower", "QualityLevel", "AttackDefenseBonusRoll", "BodySlot", "ItemId", "Generator", "ItemQualityModifier", "SnoLegendaryAffix", "SnoImbuedAffix",
					"SnoReplacedAffix", "NightmareDungeonInfo", "ItemPowerBonus"
				}, null, null, null, null)
			}));
		}

		// Token: 0x040023AA RID: 9130
		private static FileDescriptor descriptor;
	}
}
