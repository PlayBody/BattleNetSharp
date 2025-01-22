using System;
using Fenris.Online;
using Google.Protobuf.Reflection;

namespace Fenris.Hero
{
	// Token: 0x02000199 RID: 409
	public static class HeroCommonReflection
	{
		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06002B52 RID: 11090 RVA: 0x000AA6F8 File Offset: 0x000A88F8
		public static FileDescriptor Descriptor
		{
			get
			{
				return HeroCommonReflection.descriptor;
			}
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x000AA710 File Offset: 0x000A8910
		static HeroCommonReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChBIZXJvQ29tbW9uLnByb3RvEgtGZW5yaXMuSGVybxoST25saW5lQ29tbW9u", "LnByb3RvIjIKClZpc3VhbEl0ZW0SDwoDc25vGAEgASgPOgItMRITCgdzbm9f", "ZHllGAIgASgPOgItMSI/Cg9WaXN1YWxFcXVpcG1lbnQSLAoLdmlzdWFsX2l0", "ZW0YASADKAsyFy5GZW5yaXMuSGVyby5WaXN1YWxJdGVtIqUBCgpTYXZlZFF1", "ZXN0EhUKCXNub19xdWVzdBgBIAIoDzoCLTESIAoVZGlmZmljdWx0eV9kZXBy", "ZWNhdGVkGAIgASgROgEwEhwKEGN1cnJlbnRfc3RlcF91aWQYAyACKBE6Ai0x", "EhsKD29iamVjdGl2ZV9zdGF0ZRgEIAMoEUICEAESIwoXZmFpbHVyZV9jb25k", "aXRpb25fc3RhdGUYBSADKBFCAhABIm8KC0xlYXJuZWRMb3JlEhgKEHNub19s", "b3JlX2xlYXJuZWQYASADKA8SIQoZc25vX2xvcmVfbGVhcm5lZF9iaXRmaWVs", "ZBgCIAEoDBIjChtiaXRmaWVsZF9sZWFkaW5nX251bGxfYnl0ZXMYAyABKAUi",
				"SQoUQ29udmVyc2F0aW9uQ29vbGRvd24SGAoQc25vX2NvbnZlcnNhdGlvbhgB", "IAIoDxIXCg9leHBpcmF0aW9uX3RpbWUYAiACKAQixwEKElNhdmVkQ29udmVy", "c2F0aW9ucxIfChdzbm9fc2F2ZWRfY29udmVyc2F0aW9ucxgCIAMoDxIoCiBz", "bm9fc2F2ZWRfY29udmVyc2F0aW9uc19iaXRmaWVsZBgDIAEoDBIjChtiaXRm", "aWVsZF9sZWFkaW5nX251bGxfYnl0ZXMYBCABKAUSQQoWY29udmVyc2F0aW9u", "X2Nvb2xkb3ducxgFIAMoCzIhLkZlbnJpcy5IZXJvLkNvbnZlcnNhdGlvbkNv", "b2xkb3duImUKE1NhdmVQb2ludERhdGFfUHJvdG8SFQoJc25vX3dvcmxkGAEg", "AigPOgItMRIcChBzYXZlcG9pbnRfbnVtYmVyGAIgAigROgItMRIZCg5jcmVh", "dGVzX3BvcnRhbBgDIAIoDToBMCIeCgVTa2lsbBIVCglzbm9fc2tpbGwYASAC", "KA86Ai0xIi0KDVNhdmVkSXRlbUxpbmsSDQoBeBgBIAIoEToCLTESDQoBeRgC",
				"IAIoEToCLTEiNgoKVGltZXN0YW1wcxITCgtjcmVhdGVfdGltZRgBIAIoEhIT", "CgtkZWxldGVfdGltZRgCIAEoEiIYCghOYW1lVGV4dBIMCgRuYW1lGAEgAigJ", "IhwKCEhlcm9MaXN0EhAKCGhlcm9faWRzGAEgAygJIj8KDlNhdmVkUXVlc3RM", "aXN0Ei0KDHNhdmVkX3F1ZXN0cxgBIAMoCzIXLkZlbnJpcy5IZXJvLlNhdmVk", "UXVlc3QirQEKGVdvcmxkQ3JlYXRlRGVidWdPdmVycmlkZXMSEgoKd29ybGRf", "c2VlZBgBIAEoBRIVCg1mb3JjZWRfbGFiZWxzGAIgAygPEh0KFWZvcmNlZF9k", "dW5nZW9uX3N0YXRlcxgDIAMoDxIeChZkaXNhYmxlX2RlZmF1bHRfbGFiZWxz", "GAQgASgIEiYKHmRpc2FibGVfZGVmYXVsdF9kdW5nZW9uX3N0YXRlcxgFIAEo", "CCK6AQoQS2V5ZWREdW5nZW9uRGF0YRIVCglzbm9fd29ybGQYASABKA86Ai0x", "Eh4KEmtleWVkX2R1bmdlb25fdGllchgDIAEoEToCLTESGAoMcmV2aXZlX2Nv",
				"dW50GAQgASgROgItMRI4ChVrZXllZF9kdW5nZW9uX2dhbWVfaWQYBSABKAsy", "GS5GZW5yaXMuT25saW5lLkdhbWVIYW5kbGUSGwoTc25vX2R1bmdlb25fYWZm", "aXhlcxgGIAMoDyKDAgoNQ2FtcGFpZ25TdGF0ZRIeChZzb3VyY2VfYm5ldF9h", "Y2NvdW50X2lkGAEgASgNEh4KFnNvdXJjZV9nYW1lX2FjY291bnRfaWQYAiAB", "KA0SFQoJc25vX3F1ZXN0GAMgAygHQgIQARI5ChJrZXllZF9kdW5nZW9uX2Rh", "dGEYBCABKAsyHS5GZW5yaXMuSGVyby5LZXllZER1bmdlb25EYXRhEkwKHHdv", "cmxkX2NyZWF0ZV9kZWJ1Z19vdmVycmlkZXMYBSABKAsyJi5GZW5yaXMuSGVy", "by5Xb3JsZENyZWF0ZURlYnVnT3ZlcnJpZGVzEhIKCndvcmxkX3RpZXIYBiAB", "KBEiiQEKDkdhbWVRdWVzdFN0YXRlEhcKC3Nub19zdWJ6b25lGAEgASgPOgIt", "MRIeChJzbm9faW5zdGFuY2VfcXVlc3QYAiABKA86Ai0xEhUKCXBoYXNlX3Vp",
				"ZBgDIAEoEToCLTESJwofcGFydHlfaW5zdGFuY2VfY29udGVudF9jb21wbGV0", "ZRgEIAEoCCIiCglNb3VudERhdGESFQoJc25vX21vdW50GAEgAigPOgItMSJR", "Cg5Nb3VudFNhdmVkRGF0YRImCgZtb3VudHMYASADKAsyFi5GZW5yaXMuSGVy", "by5Nb3VudERhdGESFwoPdW5sb2NrZWRfcmlkaW5nGAIgASgIIowBChNTb2Np", "YWxXaGVlbE92ZXJyaWRlEhAKCHdoZWVsX2lkGAEgASgNEg8KB3Nsb3RfaWQY", "AiABKA0SGQoPcXVpY2tfYWN0aW9uX2lkGAMgASgNSAASEwoJc25vX2Vtb3Rl", "GAQgASgHSAASGAoOc25vX2NvbnN1bWFibGUYBSABKAdIAEIICgZhY3Rpb24i", "VQoYU29jaWFsV2hlZWxDb25maWd1cmF0aW9uEjkKD3doZWVsX292ZXJyaWRl", "cxgBIAMoCzIgLkZlbnJpcy5IZXJvLlNvY2lhbFdoZWVsT3ZlcnJpZGUiXgoM", "VHJhbnNtb2dTbG90EgwKBHNsb3QYASABKAUSFAoIaXRlbV9zbm8YAiABKA86",
				"Ai0xEhMKB2R5ZV9zbm8YAyABKA86Ai0xEhUKB2VuYWJsZWQYBCABKAg6BHRy", "dWUiVQoSQXNzZXRMaXN0RGF0YVN0b3JlEhEKCWFzc2V0X2lkcxgBIAMoDxIQ", "CghiaXRmaWVsZBgCIAEoDBIaChJsZWFkaW5nX251bGxfYnl0ZXMYAyABKAUi", "RgoZRGVzaWduZXJWYXJpYWJsZURhdGFTdG9yZRIVCg10cmFja2VkX3ZhbHVl", "GAEgASgFEhIKCnJlc2V0X2RhdGEYAiABKAUi1gEKJEFzc2V0TGlzdEV4RGVz", "aWduZXJWYXJpYWJsZURhdGFTdG9yZRIzCgphc3NldF9saXN0GAEgASgLMh8u", "RmVucmlzLkhlcm8uQXNzZXRMaXN0RGF0YVN0b3JlEjwKDHBhY2tlZF9kYXRh", "cxgCIAMoCzImLkZlbnJpcy5IZXJvLkRlc2lnbmVyVmFyaWFibGVEYXRhU3Rv", "cmUSOwoLbG9vc2VfZGF0YXMYAyADKAsyJi5GZW5yaXMuSGVyby5EZXNpZ25l", "clZhcmlhYmxlRGF0YVN0b3JlIocCChVQYXJhZ29uQm9hcmRTYXZlZERhdGES",
				"IAoYcHVyY2hhc2VkX25vZGVzX2JpdGZpZWxkGAEgASgMEiEKGWxhc3RfcHVy", "Y2hhc2VkX25vZGVfaW5kZXgYAiABKA0SGwoTc29ja2V0ZWRfZ2x5cGhfc25v", "cxgDIAMoDxIbChNlcXVpcHBlZF9ib2FyZF9zbm9zGAQgAygPEigKIGVxdWlw", "cGVkX2JvYXJkX3JvdGF0aW9uX2JpdGZpZWxkGAUgASgMEigKIGVxdWlwcGVk", "X2JvYXJkX2dhdGVfbm9kZV9pbmRleGVzGAYgAygNEhsKE2JvYXJkX2VxdWlw", "X2luZGV4ZXMYByADKA0iRgoQUGFyYWdvbkdseXBoRGF0YRIVCglzbm9fZ2x5", "cGgYASABKA86Ai0xEhsKEGdseXBoX2V4cGVyaWVuY2UYAiABKA06ATAiSgoV", "UGFyYWdvbkdseXBoU2F2ZWREYXRhEjEKCmdseXBoX2RhdGEYASADKAsyHS5G", "ZW5yaXMuSGVyby5QYXJhZ29uR2x5cGhEYXRhIj0KC1BsYXllclRpdGxlEhYK", "CnNub19wcmVmaXgYASABKA86Ai0xEhYKCnNub19zdWZmaXgYAiABKA86Ai0x"
			}));
			HeroCommonReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { OnlineCommonReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(VisualItem), VisualItem.Parser, new string[] { "Sno", "SnoDye" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(VisualEquipment), VisualEquipment.Parser, new string[] { "VisualItem" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavedQuest), SavedQuest.Parser, new string[] { "SnoQuest", "DifficultyDeprecated", "CurrentStepUid", "ObjectiveState", "FailureConditionState" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LearnedLore), LearnedLore.Parser, new string[] { "SnoLoreLearned", "SnoLoreLearnedBitfield", "BitfieldLeadingNullBytes" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ConversationCooldown), ConversationCooldown.Parser, new string[] { "SnoConversation", "ExpirationTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavedConversations), SavedConversations.Parser, new string[] { "SnoSavedConversations", "SnoSavedConversationsBitfield", "BitfieldLeadingNullBytes", "ConversationCooldowns" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavePointData_Proto), SavePointData_Proto.Parser, new string[] { "SnoWorld", "SavepointNumber", "CreatesPortal" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Skill), Skill.Parser, new string[] { "SnoSkill" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavedItemLink), SavedItemLink.Parser, new string[] { "X", "Y" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Timestamps), Timestamps.Parser, new string[] { "CreateTime", "DeleteTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(NameText), NameText.Parser, new string[] { "Name" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(HeroList), HeroList.Parser, new string[] { "HeroIds" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SavedQuestList), SavedQuestList.Parser, new string[] { "SavedQuests" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(WorldCreateDebugOverrides), WorldCreateDebugOverrides.Parser, new string[] { "WorldSeed", "ForcedLabels", "ForcedDungeonStates", "DisableDefaultLabels", "DisableDefaultDungeonStates" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(KeyedDungeonData), KeyedDungeonData.Parser, new string[] { "SnoWorld", "KeyedDungeonTier", "ReviveCount", "KeyedDungeonGameId", "SnoDungeonAffixes" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CampaignState), CampaignState.Parser, new string[] { "SourceBnetAccountId", "SourceGameAccountId", "SnoQuest", "KeyedDungeonData", "WorldCreateDebugOverrides", "WorldTier" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameQuestState), GameQuestState.Parser, new string[] { "SnoSubzone", "SnoInstanceQuest", "PhaseUid", "PartyInstanceContentComplete" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MountData), MountData.Parser, new string[] { "SnoMount" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MountSavedData), MountSavedData.Parser, new string[] { "Mounts", "UnlockedRiding" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SocialWheelOverride), SocialWheelOverride.Parser, new string[] { "WheelId", "SlotId", "QuickActionId", "SnoEmote", "SnoConsumable" }, new string[] { "Action" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(SocialWheelConfiguration), SocialWheelConfiguration.Parser, new string[] { "WheelOverrides" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(TransmogSlot), TransmogSlot.Parser, new string[] { "Slot", "ItemSno", "DyeSno", "Enabled" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AssetListDataStore), AssetListDataStore.Parser, new string[] { "AssetIds", "Bitfield", "LeadingNullBytes" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DesignerVariableDataStore), DesignerVariableDataStore.Parser, new string[] { "TrackedValue", "ResetData" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AssetListExDesignerVariableDataStore), AssetListExDesignerVariableDataStore.Parser, new string[] { "AssetList", "PackedDatas", "LooseDatas" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ParagonBoardSavedData), ParagonBoardSavedData.Parser, new string[] { "PurchasedNodesBitfield", "LastPurchasedNodeIndex", "SocketedGlyphSnos", "EquippedBoardSnos", "EquippedBoardRotationBitfield", "EquippedBoardGateNodeIndexes", "BoardEquipIndexes" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ParagonGlyphData), ParagonGlyphData.Parser, new string[] { "SnoGlyph", "GlyphExperience" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ParagonGlyphSavedData), ParagonGlyphSavedData.Parser, new string[] { "GlyphData" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PlayerTitle), PlayerTitle.Parser, new string[] { "SnoPrefix", "SnoSuffix" }, null, null, null, null)
			}));
		}

		// Token: 0x040013A1 RID: 5025
		private static FileDescriptor descriptor;
	}
}
