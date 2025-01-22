using System;
using Fenris.AttributeSerializer;
using Fenris.Hero;
using Fenris.ItemCrafting;
using Fenris.Items;
using Fenris.Quests;
using Google.Protobuf.Reflection;

namespace Fenris.Account
{
	// Token: 0x020002D0 RID: 720
	public static class AccountReflection
	{
		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x06004C52 RID: 19538 RVA: 0x00123D54 File Offset: 0x00121F54
		public static FileDescriptor Descriptor
		{
			get
			{
				return AccountReflection.descriptor;
			}
		}

		// Token: 0x06004C53 RID: 19539 RVA: 0x00123D6C File Offset: 0x00121F6C
		static AccountReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg1BY2NvdW50LnByb3RvEg5GZW5yaXMuQWNjb3VudBoZQXR0cmlidXRlU2Vy", "aWFsaXplci5wcm90bxoLSXRlbXMucHJvdG8aEkl0ZW1DcmFmdGluZy5wcm90", "bxoLUXVlc3QucHJvdG8aEEhlcm9Db21tb24ucHJvdG8ihAEKBkRpZ2VzdBIP", "Cgd2ZXJzaW9uGAEgASgNEhsKE2xhc3RfcGxheWVkX2hlcm9faWQYAiABKAwS", "DQoFZmxhZ3MYAyABKA0SEQoJc2Vhc29uX2lkGAQgASgNEhIKBmVtYmxlbRgG", "IAEoDzoCLTESFgoOc2Vjb25kc19wbGF5ZWQYByABKA0iOwoKQ29uc3VtYWJs", "ZRIaChJibmV0X2NvbnN1bWFibGVfaWQYASABKAMSEQoJc3RhdHVzX2lkGAIg", "ASgFIm8KFVZpcnR1YWxDdXJyZW5jeUNyZWRpdBIRCgljcmVkaXRfaWQYASAB", "KAkSGwoPYWNoaWV2ZW1lbnRfc25vGAIgASgPOgItMRIRCgZhbW91bnQYAyAB", "KA06ATASEwoLZGVzY3JpcHRpb24YBCABKAkiSgoPU3Rhc2hUYWJTZXR0aW5n",
				"EhEKCXRhYl9pbmRleBgBIAEoDRISCgppY29uX2luZGV4GAIgASgNEhAKCHRh", "Yl9uYW1lGAMgASgJIkUKDVN0YXNoU2V0dGluZ3MSNAoLdGFiX3NldHRpbmcY", "ASADKAsyHy5GZW5yaXMuQWNjb3VudC5TdGFzaFRhYlNldHRpbmciGgoHUmV3", "YXJkcxIPCgdyZXdhcmRzGAEgAygPIpYDChBBY2NvdW50UGFydGl0aW9uEhQK", "DHBhcnRpdGlvbl9pZBgBIAEoBRJFChBzYXZlZF9hdHRyaWJ1dGVzGAIgASgL", "MisuRmVucmlzLkF0dHJpYnV0ZVNlcmlhbGl6ZXIuU2F2ZWRBdHRyaWJ1dGVz", "EiUKBWl0ZW1zGAMgASgLMhYuRmVucmlzLkl0ZW1zLkl0ZW1MaXN0EjYKB2Ny", "YWZ0ZXIYBCABKAsyJS5GZW5yaXMuSXRlbUNyYWZ0aW5nLkNyYWZ0ZXJTYXZl", "ZERhdGESMQoIY3VycmVuY3kYCSABKAsyHy5GZW5yaXMuSXRlbXMuQ3VycmVu", "Y3lTYXZlZERhdGESMgoKcmVwdXRhdGlvbhgKIAEoCzIeLkZlbnJpcy5RdWVz",
				"dHMuU2F2ZWRSZXB1dGF0aW9uEjUKDnN0YXNoX3NldHRpbmdzGA0gASgLMh0u", "RmVucmlzLkFjY291bnQuU3Rhc2hTZXR0aW5ncxIoCgdyZXdhcmRzGA4gASgL", "MhcuRmVucmlzLkFjY291bnQuUmV3YXJkcyKzAQoLRGlzY292ZXJpZXMSPwoN", "dHJhbnNtb2dfZGF0YRgCIAEoCzIoLkZlbnJpcy5JdGVtQ3JhZnRpbmcuQ3Jh", "ZnRlclRyYW5zbW9nRGF0YRI3Cg5zZWVuX3R1dG9yaWFscxgDIAEoCzIfLkZl", "bnJpcy5IZXJvLkFzc2V0TGlzdERhdGFTdG9yZRIqCgVtb3VudBgEIAEoCzIb", "LkZlbnJpcy5IZXJvLk1vdW50U2F2ZWREYXRhIpgBChZDdXJyZW5jeUFuZENv", "bnN1bWFibGVzEkYKF3ZpcnR1YWxfY3VycmVuY3lfY3JlZGl0GAEgAygLMiUu", "RmVucmlzLkFjY291bnQuVmlydHVhbEN1cnJlbmN5Q3JlZGl0EjYKEmFwcGxp", "ZWRfY29uc3VtYWJsZRgCIAMoCzIaLkZlbnJpcy5BY2NvdW50LkNvbnN1bWFi",
				"bGUisAMKD1NhdmVkRGVmaW5pdGlvbhIPCgd2ZXJzaW9uGAEgASgNEiYKBmRp", "Z2VzdBgCIAEoCzIWLkZlbnJpcy5BY2NvdW50LkRpZ2VzdBIbChNsYXN0X2Nv", "bm5lY3RlZF90aW1lGAMgASgEEjQKCnBhcnRpdGlvbnMYBCADKAsyIC5GZW5y", "aXMuQWNjb3VudC5BY2NvdW50UGFydGl0aW9uEkUKEHNhdmVkX2F0dHJpYnV0", "ZXMYBSABKAsyKy5GZW5yaXMuQXR0cmlidXRlU2VyaWFsaXplci5TYXZlZEF0", "dHJpYnV0ZXMSTgoZc2F2ZWRfYXR0cmlidXRlc19oYXJkY29yZRgGIAEoCzIr", "LkZlbnJpcy5BdHRyaWJ1dGVTZXJpYWxpemVyLlNhdmVkQXR0cmlidXRlcxIw", "CgtkaXNjb3ZlcmllcxgHIAEoCzIbLkZlbnJpcy5BY2NvdW50LkRpc2NvdmVy", "aWVzEkgKGGN1cnJlbmN5X2FuZF9jb25zdW1hYmxlcxgIIAEoCzImLkZlbnJp", "cy5BY2NvdW50LkN1cnJlbmN5QW5kQ29uc3VtYWJsZXMiNQoNTGVnYWxEb2N1",
				"bWVudBITCgtkb2N1bWVudF9pZBgBIAEoCRIPCgd2ZXJzaW9uGAIgASgNIkgK", "DkxlZ2FsRG9jdW1lbnRzEjYKD2xlZ2FsX2RvY3VtZW50cxgBIAMoCzIdLkZl", "bnJpcy5BY2NvdW50LkxlZ2FsRG9jdW1lbnQqTAoMQWNjb3VudEZsYWdzEiMK", "H0FMTE9XX0dBTUVfU0VSVkVSX1BPT0xfT1ZFUlJJREUQABIXChNBTExPV19D", "QU1QQUlHTl9TS0lQEAE="
			}));
			AccountReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AttributeSerializerReflection.Descriptor,
				ItemsReflection.Descriptor,
				ItemCraftingReflection.Descriptor,
				QuestReflection.Descriptor,
				HeroCommonReflection.Descriptor
			}, new GeneratedClrTypeInfo(new Type[] { typeof(AccountFlags) }, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(Digest), Digest.Parser, new string[] { "Version", "LastPlayedHeroId", "Flags", "SeasonId", "Emblem", "SecondsPlayed" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Consumable), Consumable.Parser, new string[] { "BnetConsumableId", "StatusId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(VirtualCurrencyCredit), VirtualCurrencyCredit.Parser, new string[] { "CreditId", "AchievementSno", "Amount", "Description" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StashTabSetting), StashTabSetting.Parser, new string[] { "TabIndex", "IconIndex", "TabName" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(StashSettings), StashSettings.Parser, new string[] { "TabSetting" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Rewards), Rewards.Parser, new string[] { "Rewards_" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AccountPartition), AccountPartition.Parser, new string[] { "PartitionId", "SavedAttributes", "Items", "Crafter", "Currency", "Reputation", "StashSettings", "Rewards" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Discoveries), Discoveries.Parser, new string[] { "TransmogData", "SeenTutorials", "Mount" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CurrencyAndConsumables), CurrencyAndConsumables.Parser, new string[] { "VirtualCurrencyCredit", "AppliedConsumable" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavedDefinition), SavedDefinition.Parser, new string[] { "Version", "Digest", "LastConnectedTime", "Partitions", "SavedAttributes", "SavedAttributesHardcore", "Discoveries", "CurrencyAndConsumables" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LegalDocument), LegalDocument.Parser, new string[] { "DocumentId", "Version" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LegalDocuments), LegalDocuments.Parser, new string[] { "LegalDocuments_" }, null, null, null, null)
			}));
		}

		// Token: 0x04002207 RID: 8711
		private static FileDescriptor descriptor;
	}
}
