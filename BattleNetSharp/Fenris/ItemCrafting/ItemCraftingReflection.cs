using System;
using Google.Protobuf.Reflection;

namespace Fenris.ItemCrafting
{
	// Token: 0x02000170 RID: 368
	public static class ItemCraftingReflection
	{
		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06002664 RID: 9828 RVA: 0x000950A0 File Offset: 0x000932A0
		public static FileDescriptor Descriptor
		{
			get
			{
				return ItemCraftingReflection.descriptor;
			}
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x000950B8 File Offset: 0x000932B8
		static ItemCraftingReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChJJdGVtQ3JhZnRpbmcucHJvdG8SE0ZlbnJpcy5JdGVtQ3JhZnRpbmciqwEK", "C0NyYWZ0ZXJEYXRhEg8KB3JlY2lwZXMYASADKA8SJQodZGVwcmVjYXRlZF9h", "dmFpbGFibGVfZW5jaGFudHMYAiADKA8SFAoMY29vbGRvd25fZW5kGAQgAigQ", "EhgKEHJlY2lwZXNfYml0ZmllbGQYBSABKAwSIwobYml0ZmllbGRfbGVhZGlu", "Z19udWxsX2J5dGVzGAYgASgFEg8KB3RhbGVudHMYByADKA0ieQoRVW5sb2Nr", "ZWRUcmFuc21vZ3MSGgoSdW5sb2NrZWRfdHJhbnNtb2dzGAEgAygPEiMKG3Vu", "bG9ja2VkX3RyYW5zbW9nc19iaXRmaWVsZBgCIAEoDBIjChtiaXRmaWVsZF9s", "ZWFkaW5nX251bGxfYnl0ZXMYAyABKAUioAEKE0NyYWZ0ZXJUcmFuc21vZ0Rh", "dGESQgoSdW5sb2NrZWRfdHJhbnNtb2dzGAQgASgLMiYuRmVucmlzLkl0ZW1D", "cmFmdGluZy5VbmxvY2tlZFRyYW5zbW9ncxJFChVhY2hpZXZlbWVudF90cmFu",
				"c21vZ3MYBSABKAsyJi5GZW5yaXMuSXRlbUNyYWZ0aW5nLlVubG9ja2VkVHJh", "bnNtb2dzIkoKEENyYWZ0ZXJTYXZlZERhdGESNgoMY3JhZnRlcl9kYXRhGAEg", "AygLMiAuRmVucmlzLkl0ZW1DcmFmdGluZy5DcmFmdGVyRGF0YQ=="
			}));
			ItemCraftingReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(CrafterData), CrafterData.Parser, new string[] { "Recipes", "DeprecatedAvailableEnchants", "CooldownEnd", "RecipesBitfield", "BitfieldLeadingNullBytes", "Talents" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UnlockedTransmogs), UnlockedTransmogs.Parser, new string[] { "UnlockedTransmogs_", "UnlockedTransmogsBitfield", "BitfieldLeadingNullBytes" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CrafterTransmogData), CrafterTransmogData.Parser, new string[] { "UnlockedTransmogs", "AchievementTransmogs" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CrafterSavedData), CrafterSavedData.Parser, new string[] { "CrafterData" }, null, null, null, null)
			}));
		}

		// Token: 0x040010F5 RID: 4341
		private static FileDescriptor descriptor;
	}
}
