using System;
using Fenris.Account;
using Fenris.Achievements;
using Fenris.Clan;
using Fenris.Client;
using Fenris.Gift;
using Fenris.Hero;
using Fenris.Items;
using Fenris.Profile;
using Google.Protobuf.Reflection;

namespace Fenris.CS
{
	// Token: 0x020001FF RID: 511
	public static class CSReflection
	{
		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x06003805 RID: 14341 RVA: 0x000DD878 File Offset: 0x000DBA78
		public static FileDescriptor Descriptor
		{
			get
			{
				return CSReflection.descriptor;
			}
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x000DD890 File Offset: 0x000DBA90
		static CSReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CghDUy5wcm90bxIJRmVucmlzLkNTGgtJdGVtcy5wcm90bxoKSGVyby5wcm90", "bxoNQWNjb3VudC5wcm90bxoNUHJvZmlsZS5wcm90bxoOU2V0dGluZ3MucHJv", "dG8aCkNsYW4ucHJvdG8aEkFjaGlldmVtZW50cy5wcm90bxoKR2lmdC5wcm90", "byK6AgoHVG9vbFRpcBIOCgZpdGVtSWQYASACKAYSGAoQSXRlbVF1YWxpdHlM", "ZXZlbBgCIAIoDRIMCgROYW1lGAMgAigJEgwKBFR5cGUYBCACKAkSDwoHU2V0", "SXRlbRgFIAIoBRIOCgZGbGF2b3IYBiACKAkSDAoEQ29zdBgHIAIoCRIdChVE", "dXJhYmlsaXR5X2RlcHJlY2F0ZWQYCCACKAkSEQoJQ2xhc3NSZXFzGAkgAigJ", "EhQKDFJlcXVpcmVtZW50cxgKIAIoCRIeChZFbmhhbmNlbWVudF9kZXByZWNh", "dGVkGAsgAigJEhIKClN0YWNrQ291bnQYDCACKAQSEgoKTnVtU29ja2V0cxgN", "IAIoDRIVCg1GaWxsZWRTb2NrZXRzGA4gAigNEhMKC0Rpc3BsYXlOYW1lGA8g",
				"AigJIjMKC1Rvb2x0aXBMaXN0EiQKCHRvb2x0aXBzGAEgAygLMhIuRmVucmlz", "LkNTLlRvb2xUaXAi7gIKCFNuYXBzaG90Eg8KB3ZlcnNpb24YASABKAQSFwoP", "Z2FtZV9hY2NvdW50X2lkGAIgASgNEjMKCmRlZmluaXRpb24YAyABKAsyHy5G", "ZW5yaXMuQWNjb3VudC5TYXZlZERlZmluaXRpb24SLAoGaGVyb2VzGAQgAygL", "MhwuRmVucmlzLkhlcm8uU2F2ZWREZWZpbml0aW9uEjYKDWhlcm9fcHJvZmls", "ZXMYBSABKAsyHy5GZW5yaXMuUHJvZmlsZS5IZXJvUHJvZmlsZUxpc3QSIgoF", "bWFpbHMYBiABKAsyEy5GZW5yaXMuSXRlbXMuTWFpbHMSOAoQYWNjb3VudF9w", "cm9maWxlcxgHIAMoCzIeLkZlbnJpcy5Qcm9maWxlLkFjY291bnRQcm9maWxl", "Ei8KC3ByZWZlcmVuY2VzGAggASgLMhouRmVucmlzLkNsaWVudC5QcmVmZXJl", "bmNlcxIOCgZiYW5uZWQYCSABKAgiSQoPU25hcHNob3RWZXJzaW9uEg8KB3Zl",
				"cnNpb24YASABKAQSJQoIc25hcHNob3QYAiABKAsyEy5GZW5yaXMuQ1MuU25h", "cHNob3QiQAoQU25hcHNob3RWZXJzaW9ucxIsCgh2ZXJzaW9ucxgBIAMoCzIa", "LkZlbnJpcy5DUy5TbmFwc2hvdFZlcnNpb24iNQoPUGFydGl0aW9uZWRHQklE", "EgwKBGdiaWQYASACKA8SFAoMcGFydGl0aW9uX2lkGAIgAigNIkwKE1BhcnRp", "dGlvbmVkR0JJRExpc3QSNQoRcGFydGl0aW9uZWRfZ2JpZHMYASADKAsyGi5G", "ZW5yaXMuQ1MuUGFydGl0aW9uZWRHQklEIlYKGlBhcnRpdGlvbmVkR0JJRENh", "cFF1YW50aXR5EgwKBGdiaWQYASACKA8SFAoMcGFydGl0aW9uX2lkGAIgAigN", "EhQKDGNhcF9xdWFudGl0eRgDIAIoBCJiCh5QYXJ0aXRpb25lZEdCSURDYXBR", "dWFudGl0eUxpc3QSQAoRcGFydGl0aW9uZWRfZ2JpZHMYASADKAsyJS5GZW5y", "aXMuQ1MuUGFydGl0aW9uZWRHQklEQ2FwUXVhbnRpdHkiawoLQWNjb3VudERh",
				"dGESJgoGZGlnZXN0GAEgAigLMhYuRmVucmlzLkFjY291bnQuRGlnZXN0EjQK", "CnBhcnRpdGlvbnMYAiADKAsyIC5GZW5yaXMuQWNjb3VudC5BY2NvdW50UGFy", "dGl0aW9uIkAKDkZhbGxlbkhlcm9EYXRhEi4KDWZhbGxlbl9oZXJvZXMYASAD", "KAsyFy5GZW5yaXMuSGVyby5GYWxsZW5IZXJvIpcCCghDbGFuRGF0YRIjCgRp", "bmZvGAEgASgLMhUuRmVucmlzLkNsYW4uQ2xhbkluZm8SLAoLbWVtYmVyX2lu", "Zm8YAiABKAsyFy5GZW5yaXMuQ2xhbi5DbGFuTWVtYmVyEigKB2ludml0ZXMY", "AyADKAsyFy5GZW5yaXMuQ2xhbi5DbGFuSW52aXRlEjIKDGFwcGxpY2F0aW9u", "cxgEIAMoCzIcLkZlbnJpcy5DbGFuLkNsYW5BcHBsaWNhdGlvbhIsCgluZXdz", "X2xpc3QYBSABKAsyGS5GZW5yaXMuQ2xhbi5DbGFuTmV3c0xpc3QSFgoOcmVt", "b3ZhbF9yZWFzb24YBiABKA0SFAoMcmVtb3ZhbF90aW1lGAcgASgEIlYKD0Fj",
				"aGlldmVtZW50RGF0YRJDChNwYXJ0aXRpb25fc25hcHNob3RzGAEgAygLMiYu", "RmVucmlzLkFjaGlldmVtZW50cy5QYXJ0aXRpb25TbmFwc2hvdCIwCghHaWZ0", "RGF0YRIkCgVnaWZ0cxgBIAMoCzIVLkZlbnJpcy5HaWZ0LkdpZnRJbmZvIv0B", "ChFHRFBSUGxheWVyRGF0YUFsbBItChBhY2NvdW50X3NuYXBzaG90GAEgASgL", "MhMuRmVucmlzLkNTLlNuYXBzaG90EjMKEGZhbGxlbl9oZXJvX2RhdGEYAiAB", "KAsyGS5GZW5yaXMuQ1MuRmFsbGVuSGVyb0RhdGESJgoJY2xhbl9kYXRhGAMg", "ASgLMhMuRmVucmlzLkNTLkNsYW5EYXRhEjQKEGFjaGlldmVtZW50X2RhdGEY", "BCABKAsyGi5GZW5yaXMuQ1MuQWNoaWV2ZW1lbnREYXRhEiYKCWdpZnRfZGF0", "YRgFIAEoCzITLkZlbnJpcy5DUy5HaWZ0RGF0YQ=="
			}));
			CSReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				ItemsReflection.Descriptor,
				HeroReflection.Descriptor,
				AccountReflection.Descriptor,
				ProfileReflection.Descriptor,
				SettingsReflection.Descriptor,
				ClanReflection.Descriptor,
				AchievementsReflection.Descriptor,
				GiftReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ToolTip), ToolTip.Parser, new string[]
				{
					"ItemId", "ItemQualityLevel", "Name", "Type", "SetItem", "Flavor", "Cost", "DurabilityDeprecated", "ClassReqs", "Requirements",
					"EnhancementDeprecated", "StackCount", "NumSockets", "FilledSockets", "DisplayName"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(TooltipList), TooltipList.Parser, new string[] { "Tooltips" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Snapshot), Snapshot.Parser, new string[] { "Version", "GameAccountId", "Definition", "Heroes", "HeroProfiles", "Mails", "AccountProfiles", "Preferences", "Banned" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SnapshotVersion), SnapshotVersion.Parser, new string[] { "Version", "Snapshot" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SnapshotVersions), SnapshotVersions.Parser, new string[] { "Versions" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartitionedGBID), PartitionedGBID.Parser, new string[] { "Gbid", "PartitionId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartitionedGBIDList), PartitionedGBIDList.Parser, new string[] { "PartitionedGbids" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartitionedGBIDCapQuantity), PartitionedGBIDCapQuantity.Parser, new string[] { "Gbid", "PartitionId", "CapQuantity" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PartitionedGBIDCapQuantityList), PartitionedGBIDCapQuantityList.Parser, new string[] { "PartitionedGbids" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AccountData), AccountData.Parser, new string[] { "Digest", "Partitions" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(FallenHeroData), FallenHeroData.Parser, new string[] { "FallenHeroes" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanData), ClanData.Parser, new string[] { "Info", "MemberInfo", "Invites", "Applications", "NewsList", "RemovalReason", "RemovalTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AchievementData), AchievementData.Parser, new string[] { "PartitionSnapshots" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GiftData), GiftData.Parser, new string[] { "Gifts" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GDPRPlayerDataAll), GDPRPlayerDataAll.Parser, new string[] { "AccountSnapshot", "FallenHeroData", "ClanData", "AchievementData", "GiftData" }, null, null, null, null)
			}));
		}

		// Token: 0x04001A22 RID: 6690
		private static FileDescriptor descriptor;
	}
}
