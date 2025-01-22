using System;
using Google.Protobuf.Reflection;

namespace Fenris.Items
{
	// Token: 0x0200015E RID: 350
	public static class ItemsReflection
	{
		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x0008BF50 File Offset: 0x0008A150
		public static FileDescriptor Descriptor
		{
			get
			{
				return ItemsReflection.descriptor;
			}
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x0008BF68 File Offset: 0x0008A168
		static ItemsReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CgtJdGVtcy5wcm90bxIMRmVucmlzLkl0ZW1zImYKEER1bmdlb25LZXlQYXJh", "bXMSFQoJc25vX3dvcmxkGAEgASgPOgItMRIeChJrZXllZF9kdW5nZW9uX3Rp", "ZXIYAyABKBE6Ai0xEhsKE3Nub19kdW5nZW9uX2FmZml4ZXMYBCADKA8ikAEK", "EUltYnVlZEFmZml4UGFyYW1zEg0KBWFmZml4GAEgASgPEgwKBHNlZWQYAiAB", "KA0SDQoFY2FycnkYAyABKA0SGgoOcmVwbGFjZWRfYWZmaXgYBCABKA86Ai0x", "EhoKEmVzc2VuY2VfaXRlbV9wb3dlchgFIAEoBRIXCg9mcm9tX2RlZmluaXRp", "b24YBiABKAgijgEKFEVuY2hhbnRlZEFmZml4UGFyYW1zEhUKDWVuY2hhbnRf", "Y291bnQYASABKA0SJAoYZW5jaGFudGVkX3JlcGxhY2VkX2FmZml4GAIgASgP", "OgItMRIbCg9lbmNoYW50ZWRfYWZmaXgYAyABKA86Ai0xEhwKFGVuY2hhbnRl", "ZF9hZmZpeF9zZWVkGAQgASgNIpwBCgxSYXJlSXRlbU5hbWUSIgoTaXRlbV9u",
				"YW1lX2lzX3ByZWZpeBgBIAIoCDoFZmFsc2USIQoVc25vX2FmZml4X3N0cmlu", "Z19saXN0GAIgAigPOgItMRIiChdhZmZpeF9zdHJpbmdfbGlzdF9sYWJlbBgF", "IAEoDToBMBIhChZpdGVtX3N0cmluZ19saXN0X2xhYmVsGAYgASgNOgEwIpEB", "CgxQdlBEZWF0aEluZm8SFAoMcGxheWVyX2NsYXNzGAEgASgFEg0KBWxldmVs", "GAIgASgFEhIKCmxldmVsX2FyZWEYAyABKAUSFwoPYm5ldF9hY2NvdW50X2lk", "GAYgASgNEhcKD2dhbWVfYWNjb3VudF9pZBgEIAEoDRIWCg5wbGF5ZXJfaXNf", "bWFsZRgFIAEoCCKPBgoJR2VuZXJhdG9yEg8KBHNlZWQYASACKA06ATASFAoI", "c25vX2l0ZW0YAiABKA86Ai0xEhQKDGJhc2VfYWZmaXhlcxgDIAMoDxIyCg5y", "YXJlX2l0ZW1fbmFtZRgEIAEoCzIaLkZlbnJpcy5JdGVtcy5SYXJlSXRlbU5h", "bWUSEAoFZmxhZ3MYBSACKA06ATASEgoKc3RhY2tfc2l6ZRgGIAIoBBITCgdz",
				"bm9fZHllGAcgASgPOgItMRIdChJpdGVtX3F1YWxpdHlfbGV2ZWwYCCABKBE6", "ATESHQoSaXRlbV9iaW5kaW5nX2xldmVsGAkgASgROgEwEjEKCGNvbnRlbnRz", "GAogAygLMh8uRmVucmlzLkl0ZW1zLkVtYmVkZGVkR2VuZXJhdG9yEhUKCml0", "ZW1fcG93ZXIYECABKBE6ATASFwoMc29ja2V0X2NvdW50GBIgASgNOgEwEjoK", "EmR1bmdlb25fa2V5X3BhcmFtcxgTIAEoCzIeLkZlbnJpcy5JdGVtcy5EdW5n", "ZW9uS2V5UGFyYW1zEjwKE2ltYnVlZF9hZmZpeF9wYXJhbXMYFCABKAsyHy5G", "ZW5yaXMuSXRlbXMuSW1idWVkQWZmaXhQYXJhbXMSHQoSZHVyYWJpbGl0eV9w", "ZXJjZW50GBUgASgCOgExEi4KCmRlYXRoX2luZm8YFiABKAsyGi5GZW5yaXMu", "SXRlbXMuUHZQRGVhdGhJbmZvEhYKDnJlcXVpcmVkX2xldmVsGBcgASgNEh0K", "FWl0ZW1fcXVhbGl0eV9tb2RpZmllchgYIAEoERIWCgp3b3JsZF90aWVyGBkg",
				"ASgROgItMRIZCg1kdW5nZW9uX2xldmVsGBogASgROgItMRIfChdpbmhlcmVu", "dF9yb2xsZWRfYWZmaXhlcxgbIAMoDxJCChZlbmNoYW50ZWRfYWZmaXhfcGFy", "YW1zGBwgASgLMiIuRmVucmlzLkl0ZW1zLkVuY2hhbnRlZEFmZml4UGFyYW1z", "Eh0KEml0ZW1fdXBncmFkZXNfdXNlZBgdIAEoEToBMCI8Cg1HZW5lcmF0b3JM", "aXN0EisKCmdlbmVyYXRvcnMYASADKAsyFy5GZW5yaXMuSXRlbXMuR2VuZXJh", "dG9yIksKEUVtYmVkZGVkR2VuZXJhdG9yEgoKAmlkGAEgAigMEioKCWdlbmVy", "YXRvchgCIAIoCzIXLkZlbnJpcy5JdGVtcy5HZW5lcmF0b3Ii4QEKCVNhdmVk", "SXRlbRIKCgJpZBgBIAIoDBIVCg1vd25lcl9oZXJvX2lkGAIgASgMEhEKCXNv", "Y2tldF9pZBgDIAEoDBIaCg5oaXJlbGluZ19jbGFzcxgEIAIoEToCLTESEQoJ", "aXRlbV9zbG90GAUgAigREhQKDHNxdWFyZV9pbmRleBgGIAIoERIcChF1c2Vk",
				"X3NvY2tldF9jb3VudBgHIAIoDToBMBIqCglnZW5lcmF0b3IYCCABKAsyFy5G", "ZW5yaXMuSXRlbXMuR2VuZXJhdG9yEg8KB2RiX3Nsb3QYCSABKA0iMgoISXRl", "bUxpc3QSJgoFaXRlbXMYASADKAsyFy5GZW5yaXMuSXRlbXMuU2F2ZWRJdGVt", "IpABCglUcmFkZUl0ZW0SGAoQYWNkX25ldHdvcmtfbmFtZRgBIAEoBBIrCgpz", "YXZlZF9pdGVtGAIgASgLMhcuRmVucmlzLkl0ZW1zLlNhdmVkSXRlbRIqCgln", "ZW5lcmF0b3IYAyABKAsyFy5GZW5yaXMuSXRlbXMuR2VuZXJhdG9yEhAKCHF1", "YW50aXR5GAQgASgEIjgKD01haWxBdHRhY2htZW50cxIlCgVpdGVtcxgBIAEo", "CzIWLkZlbnJpcy5JdGVtcy5JdGVtTGlzdCL5AQoETWFpbBIXCg9nYW1lX2Fj", "Y291bnRfdG8YASACKA0SGQoRZ2FtZV9hY2NvdW50X2Zyb20YAiACKA0SDwoH", "bWFpbF9pZBgDIAIoDBINCgV0aXRsZRgEIAEoCRIMCgRib2R5GAUgASgJEg4K",
				"BnN0YXR1cxgGIAEoDRIRCglzZW5kX3RpbWUYByABKAQSMgoLYXR0YWNobWVu", "dHMYCCABKAsyHS5GZW5yaXMuSXRlbXMuTWFpbEF0dGFjaG1lbnRzEhQKDHBh", "cnRpdGlvbl9pZBgJIAEoDRIRCglleHBpcmVfYXQYCyABKAQSDwoHaGVyb19p", "ZBgMIAEoDCIqCgVNYWlscxIhCgVtYWlscxgBIAMoCzISLkZlbnJpcy5JdGVt", "cy5NYWlsIjcKDEN1cnJlbmN5RGF0YRIVCg1jdXJyZW5jeV90eXBlGAEgAigF", "EhAKBWNvdW50GAIgAigEOgEwIkEKEUN1cnJlbmN5U2F2ZWREYXRhEiwKCGN1", "cnJlbmN5GAEgAygLMhouRmVucmlzLkl0ZW1zLkN1cnJlbmN5RGF0YSKBAQoO", "U2hvcEJ1eVJlc3VsdHMSFgoHYnV5YmFjaxgBIAIoCDoFZmFsc2USFgoHZ2Ft", "YmxlZBgCIAIoCDoFZmFsc2USJQoEaXRlbRgDIAIoCzIXLkZlbnJpcy5JdGVt", "cy5HZW5lcmF0b3ISGAoQYWNkX25ldHdvcmtfbmFtZRgEIAEoBA=="
			}));
			ItemsReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(DungeonKeyParams), DungeonKeyParams.Parser, new string[] { "SnoWorld", "KeyedDungeonTier", "SnoDungeonAffixes" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ImbuedAffixParams), ImbuedAffixParams.Parser, new string[] { "Affix", "Seed", "Carry", "ReplacedAffix", "EssenceItemPower", "FromDefinition" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(EnchantedAffixParams), EnchantedAffixParams.Parser, new string[] { "EnchantCount", "EnchantedReplacedAffix", "EnchantedAffix", "EnchantedAffixSeed" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RareItemName), RareItemName.Parser, new string[] { "ItemNameIsPrefix", "SnoAffixStringList", "AffixStringListLabel", "ItemStringListLabel" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PvPDeathInfo), PvPDeathInfo.Parser, new string[] { "PlayerClass", "Level", "LevelArea", "BnetAccountId", "GameAccountId", "PlayerIsMale" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Generator), Generator.Parser, new string[]
				{
					"Seed", "SnoItem", "BaseAffixes", "RareItemName", "Flags", "StackSize", "SnoDye", "ItemQualityLevel", "ItemBindingLevel", "Contents",
					"ItemPower", "SocketCount", "DungeonKeyParams", "ImbuedAffixParams", "DurabilityPercent", "DeathInfo", "RequiredLevel", "ItemQualityModifier", "WorldTier", "DungeonLevel",
					"InherentRolledAffixes", "EnchantedAffixParams", "ItemUpgradesUsed"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GeneratorList), GeneratorList.Parser, new string[] { "Generators" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(EmbeddedGenerator), EmbeddedGenerator.Parser, new string[] { "Id", "Generator" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavedItem), SavedItem.Parser, new string[] { "Id", "OwnerHeroId", "SocketId", "HirelingClass", "ItemSlot", "SquareIndex", "UsedSocketCount", "Generator", "DbSlot" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ItemList), ItemList.Parser, new string[] { "Items" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(TradeItem), TradeItem.Parser, new string[] { "AcdNetworkName", "SavedItem", "Generator", "Quantity" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MailAttachments), MailAttachments.Parser, new string[] { "Items" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Mail), Mail.Parser, new string[]
				{
					"GameAccountTo", "GameAccountFrom", "MailId", "Title", "Body", "Status", "SendTime", "Attachments", "PartitionId", "ExpireAt",
					"HeroId"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Mails), Mails.Parser, new string[] { "Mails_" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CurrencyData), CurrencyData.Parser, new string[] { "CurrencyType", "Count" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CurrencySavedData), CurrencySavedData.Parser, new string[] { "Currency" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ShopBuyResults), ShopBuyResults.Parser, new string[] { "Buyback", "Gambled", "Item", "AcdNetworkName" }, null, null, null, null)
			}));
		}

		// Token: 0x04000FDA RID: 4058
		private static FileDescriptor descriptor;
	}
}
