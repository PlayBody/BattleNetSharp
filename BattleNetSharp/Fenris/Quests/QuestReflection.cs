using System;
using Fenris.Hero;
using Fenris.Items;
using Google.Protobuf.Reflection;

namespace Fenris.Quests
{
	// Token: 0x02000126 RID: 294
	public static class QuestReflection
	{
		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x0006FBD8 File Offset: 0x0006DDD8
		public static FileDescriptor Descriptor
		{
			get
			{
				return QuestReflection.descriptor;
			}
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x0006FBF0 File Offset: 0x0006DDF0
		static QuestReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CgtRdWVzdC5wcm90bxINRmVucmlzLlF1ZXN0cxoLSXRlbXMucHJvdG8aEEhl", "cm9Db21tb24ucHJvdG8ilQEKD1NhdmVkUmVwdXRhdGlvbhJDCgZ2YWx1ZXMY", "ASADKAsyMy5GZW5yaXMuUXVlc3RzLlNhdmVkUmVwdXRhdGlvbi5TYXZlZFJl", "cHV0YXRpb25WYWx1ZRo9ChRTYXZlZFJlcHV0YXRpb25WYWx1ZRIWCg5zbm9f", "cmVwdXRhdGlvbhgBIAEoBRINCgV2YWx1ZRgCIAEoDSLbCAoPUXVlc3RTYXZl", "ZFN0YXRlEhEKCXNub19xdWVzdBgBIAIoBRIRCglwaGFzZV91aWQYAiACKA0S", "RQoPY2FsbGJhY2tfY291bnRzGAMgAygLMiwuRmVucmlzLlF1ZXN0cy5RdWVz", "dFNhdmVkU3RhdGUuQ2FsbGJhY2tDb3VudBJgCh1jYWxsYmFja19sb290aW5q", "ZWN0aW9uX2NvdW50cxgEIAMoCzI5LkZlbnJpcy5RdWVzdHMuUXVlc3RTYXZl", "ZFN0YXRlLkNhbGxiYWNrTG9vdEluamVjdGlvbkNvdW50EhUKDWFzc2lnbmVk",
				"X3RpbWUYBSACKAQSHAoRdGltZWRfcXVlc3Rfc3RhcnQYBiABKA06ATASGgoP", "dGltZWRfcXVlc3RfZW5kGAcgASgNOgEwEloKGG9iamVjdGl2ZV9yZXdhcmRf", "Y2hvaWNlcxgIIAEoCzI4LkZlbnJpcy5RdWVzdHMuUXVlc3RTYXZlZFN0YXRl", "Lk9iamVjdGl2ZVNldFJld2FyZENob2ljZXMSJwobc25vX2ZvbGxvd2VyX25w", "Y19kZXByZWNhdGVkGAkgASgFOgItMRIZChFmb2xsb3dlcl9ucGNfc25vcxgK", "IAMoBRJkCh9xdWVzdF9naXptb19jb21wbGV0ZWRfY2FsbGJhY2tzGAsgAygL", "MjsuRmVucmlzLlF1ZXN0cy5RdWVzdFNhdmVkU3RhdGUuUXVlc3RHaXptb0Nv", "bXBsZXRlZENhbGxiYWNrcxJECg5mb2xsb3dlcl9jbG9uZRgMIAMoCzIsLkZl", "bnJpcy5RdWVzdHMuUXVlc3RTYXZlZFN0YXRlLkZvbGxvd2VyQ2xvbmUaUQoN", "Q2FsbGJhY2tDb3VudBILCgN1aWQYASACKA0SDwoHY3VycmVudBgCIAIoBRIR",
				"Cgljb21wbGV0ZWQYAyABKAgSDwoHZmFpbHVyZRgEIAEoCBo4ChpDYWxsYmFj", "a0xvb3RJbmplY3Rpb25Db3VudBILCgN1aWQYASACKA0SDQoFY291bnQYAiAC", "KA0aLQocUXVlc3RHaXptb0NvbXBsZXRlZENhbGxiYWNrcxINCgV2YWx1ZRgB", "IAIoDRp9ChlPYmplY3RpdmVTZXRSZXdhcmRDaG9pY2VzEhkKEW9iamVjdGl2", "ZV9zZXRfdWlkGAEgASgNEhQKDGNhbGxiYWNrX3VpZBgCIAEoDRIvCg5yZXdh", "cmRfY2hvaWNlcxgDIAMoCzIXLkZlbnJpcy5JdGVtcy5HZW5lcmF0b3IaoAEK", "DUZvbGxvd2VyQ2xvbmUSGgoSZm9sbG93ZXJfYWN0b3Jfc25vGAEgAigPEiEK", "GW5wY19jbG9uZWRfZnJvbV9hY3Rvcl9zbm8YAiACKA8SGAoQYW5pbXNldF9v", "dmVycmlkZRgDIAEoDxI2ChB2aXN1YWxfZXF1aXBtZW50GAQgASgLMhwuRmVu", "cmlzLkhlcm8uVmlzdWFsRXF1aXBtZW50IpsBChpRdWVzdENhbGxiYWNrVXBk",
				"YXRlTWVzc2FnZRIQCghxdWVzdF9pZBgBIAIoBRITCgtjYWxsYmFja19pZBgC", "IAIoBRIPCgdjdXJyZW50GAMgAigFEhEKCWNvbXBsZXRlZBgEIAIoCBIPCgdm", "YWlsdXJlGAUgAigIEiEKGWlzX3F1ZXN0X2dpem1vX2NvbXBsZXRpb24YBiAB", "KAgi2AcKF1F1ZXN0U3RhdGVVcGRhdGVNZXNzYWdlElEKC3VwZGF0ZV90eXBl", "GAEgAigOMjEuRmVucmlzLlF1ZXN0cy5RdWVzdFN0YXRlVXBkYXRlTWVzc2Fn", "ZS5VcGRhdGVUeXBlOglVVF9DUkVBVEUSMwoLcXVlc3Rfc3RhdGUYAiACKAsy", "Hi5GZW5yaXMuUXVlc3RzLlF1ZXN0U2F2ZWRTdGF0ZRIQCghxdWVzdF9pZBgD", "IAIoBRIdChVvd25lcl9nYW1lX2FjY291bnRfaWQYBCACKA0STwoLZXZlbnRf", "c3RhdGUYBSABKA4yMS5GZW5yaXMuUXVlc3RzLlF1ZXN0U3RhdGVVcGRhdGVN", "ZXNzYWdlLkV2ZW50U3RhdGU6B0VTX05PTkUSGwoTZXZlbnRfYWN0aXZhdGVf",
				"dGltZRgGIAEoBBIcChRzbm9fZXZlbnRfbGV2ZWxfYXJlYRgHIAEoBRIaChJv", "YmplY3RpdmVfaXNfa25vd24YCCABKAgSFAoMZnJvbV9yZXN0b3JlGAkgASgI", "Eh0KFWhhZF9sdWFfcnVudGltZV9lcnJvchgKIAEoCBIZChFsdWFfcnVudGlt", "ZV9lcnJvchgLIAEoCRIXCg9waGFzZV9pc19oaWRkZW4YDCABKAgSUQoKcGFy", "YW1fZGF0YRgNIAMoCzI9LkZlbnJpcy5RdWVzdHMuUXVlc3RTdGF0ZVVwZGF0", "ZU1lc3NhZ2UuQ3VzdG9tUGFyYW1NZXNzYWdlRGF0YRIYChBudW1fcGFydGlj", "aXBhbnRzGA4gASgNGp4BChZDdXN0b21QYXJhbU1lc3NhZ2VEYXRhEhMKC3Bh", "cmFtX3ZhbHVlGAEgASgFEhUKCXNub19hY3RvchgCIAEoBToCLTESFgoOZ2Jp", "ZF9yYXJlX25hbWUYAyADKA8SFgoObW9uc3Rlcl9yYXJpdHkYBCABKAUSFAoM", "dXNlX2FsdF9uYW1lGAUgASgIEhIKCmdpem1vX3R5cGUYBiABKAUiqwEKClVw",
				"ZGF0ZVR5cGUSDQoJVVRfQ1JFQVRFEAESDQoJVVRfVVBEQVRFEAISEAoMVVRf", "Q09NUExFVEVEEAMSDQoJVVRfREVMRVRFEAQSGQoVVVRfV09STERfRVZFTlRf", "Tk9USUZZEAUSFAoQVVRfUEFSVElDSVBBVElORxAGEhEKDVVUX0VYSVRfUkFO", "R0UQBxIaChZVVF9QQVJUSUNJUEFOVF9SRU1PVkVEEAgiNwoKRXZlbnRTdGF0", "ZRILCgdFU19OT05FEAESDQoJRVNfV0FSTVVQEAISDQoJRVNfQUNUSVZFEAMi", "YwocUXVlc3RCb251c1BoYXNlVXBkYXRlTWVzc2FnZRIQCghxdWVzdF9pZBgB", "IAIoBRIWCg5ib251c19waGFzZV9pZBgCIAIoBRIZChFib251c19waGFzZV9z", "dGF0ZRgDIAIoBSJQChBSZXB1dGF0aW9uUmV3YXJkEhYKDnNub19yZXB1dGF0", "aW9uGAEgASgFEhMKC3JlcF9jdXJyZW50GAIgASgFEg8KB3JlcF9tYXgYAyAB", "KAUiSgobUXVlc3RMdWFSdW50aW1lRXJyb3JNZXNzYWdlEhAKCHF1ZXN0X2lk",
				"GAEgAigFEhkKEWx1YV9ydW50aW1lX2Vycm9yGAIgASgJIo0BChFRdWVzdEdy", "YW50ZWRJdGVtcxIdChVvd25lcl9nYW1lX2FjY291bnRfaWQYASABKA0SFQoJ", "c25vX3F1ZXN0GAIgASgPOgItMRImCgVpdGVtcxgFIAMoCzIXLkZlbnJpcy5J", "dGVtcy5HZW5lcmF0b3ISGgoSd2FzX2ZsaXBweV9jcmVhdGVkGAYgASgIIosD", "CgtRdWVzdFJld2FyZBIdChVvd25lcl9nYW1lX2FjY291bnRfaWQYASABKA0S", "FQoJc25vX3F1ZXN0GAIgASgPOgItMRIVCgp4cF9ncmFudGVkGAMgASgEOgEw", "EhcKDGdvbGRfZ3JhbnRlZBgEIAEoBToBMBImCgVpdGVtcxgFIAMoCzIXLkZl", "bnJpcy5JdGVtcy5HZW5lcmF0b3ISGwoQYm9udXNfeHBfZ3JhbnRlZBgGIAEo", "BDoBMBJDChBjdXJyZW5jeV9ncmFudGVkGAcgAygLMikuRmVucmlzLlF1ZXN0", "cy5RdWVzdFJld2FyZC5DdXJyZW5jeVJld2FyZBI0CgtyZXBfZ3JhbnRlZBgI",
				"IAMoCzIfLkZlbnJpcy5RdWVzdHMuUmVwdXRhdGlvblJld2FyZBImChpzbm9f", "dHJhY2tlZF9yZXdhcmRfZ3JhbnRlZBgJIAEoDzoCLTEaLgoOQ3VycmVuY3lS", "ZXdhcmQSDAoEdHlwZRgBIAEoBRIOCgZhbW91bnQYAiABKAUidgoNUXVlc3RD", "b21wbGV0ZRIRCglzbm9fcXVlc3QYASACKAUSKwoHcmV3YXJkcxgCIAMoCzIa", "LkZlbnJpcy5RdWVzdHMuUXVlc3RSZXdhcmQSEgoKaXNfZmFpbHVyZRgDIAIo", "CBIRCglpc19zeW5jZWQYBCACKAg="
			}));
			QuestReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				ItemsReflection.Descriptor,
				HeroCommonReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(SavedReputation), SavedReputation.Parser, new string[] { "Values" }, null, null, null, new GeneratedClrTypeInfo[]
				{
					new GeneratedClrTypeInfo(typeof(SavedReputation.Types.SavedReputationValue), SavedReputation.Types.SavedReputationValue.Parser, new string[] { "SnoReputation", "Value" }, null, null, null, null)
				}),
				new GeneratedClrTypeInfo(typeof(QuestSavedState), QuestSavedState.Parser, new string[]
				{
					"SnoQuest", "PhaseUid", "CallbackCounts", "CallbackLootinjectionCounts", "AssignedTime", "TimedQuestStart", "TimedQuestEnd", "ObjectiveRewardChoices", "SnoFollowerNpcDeprecated", "FollowerNpcSnos",
					"QuestGizmoCompletedCallbacks", "FollowerClone"
				}, null, null, null, new GeneratedClrTypeInfo[]
				{
					new GeneratedClrTypeInfo(typeof(QuestSavedState.Types.CallbackCount), QuestSavedState.Types.CallbackCount.Parser, new string[] { "Uid", "Current", "Completed", "Failure" }, null, null, null, null),
					new GeneratedClrTypeInfo(typeof(QuestSavedState.Types.CallbackLootInjectionCount), QuestSavedState.Types.CallbackLootInjectionCount.Parser, new string[] { "Uid", "Count" }, null, null, null, null),
					new GeneratedClrTypeInfo(typeof(QuestSavedState.Types.QuestGizmoCompletedCallbacks), QuestSavedState.Types.QuestGizmoCompletedCallbacks.Parser, new string[] { "Value" }, null, null, null, null),
					new GeneratedClrTypeInfo(typeof(QuestSavedState.Types.ObjectiveSetRewardChoices), QuestSavedState.Types.ObjectiveSetRewardChoices.Parser, new string[] { "ObjectiveSetUid", "CallbackUid", "RewardChoices" }, null, null, null, null),
					new GeneratedClrTypeInfo(typeof(QuestSavedState.Types.FollowerClone), QuestSavedState.Types.FollowerClone.Parser, new string[] { "FollowerActorSno", "NpcClonedFromActorSno", "AnimsetOverride", "VisualEquipment" }, null, null, null, null)
				}),
				new GeneratedClrTypeInfo(typeof(QuestCallbackUpdateMessage), QuestCallbackUpdateMessage.Parser, new string[] { "QuestId", "CallbackId", "Current", "Completed", "Failure", "IsQuestGizmoCompletion" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QuestStateUpdateMessage), QuestStateUpdateMessage.Parser, new string[]
				{
					"UpdateType", "QuestState", "QuestId", "OwnerGameAccountId", "EventState", "EventActivateTime", "SnoEventLevelArea", "ObjectiveIsKnown", "FromRestore", "HadLuaRuntimeError",
					"LuaRuntimeError", "PhaseIsHidden", "ParamData", "NumParticipants"
				}, null, new Type[]
				{
					typeof(QuestStateUpdateMessage.Types.UpdateType),
					typeof(QuestStateUpdateMessage.Types.EventState)
				}, null, new GeneratedClrTypeInfo[]
				{
					new GeneratedClrTypeInfo(typeof(QuestStateUpdateMessage.Types.CustomParamMessageData), QuestStateUpdateMessage.Types.CustomParamMessageData.Parser, new string[] { "ParamValue", "SnoActor", "GbidRareName", "MonsterRarity", "UseAltName", "GizmoType" }, null, null, null, null)
				}),
				new GeneratedClrTypeInfo(typeof(QuestBonusPhaseUpdateMessage), QuestBonusPhaseUpdateMessage.Parser, new string[] { "QuestId", "BonusPhaseId", "BonusPhaseState" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ReputationReward), ReputationReward.Parser, new string[] { "SnoReputation", "RepCurrent", "RepMax" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QuestLuaRuntimeErrorMessage), QuestLuaRuntimeErrorMessage.Parser, new string[] { "QuestId", "LuaRuntimeError" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QuestGrantedItems), QuestGrantedItems.Parser, new string[] { "OwnerGameAccountId", "SnoQuest", "Items", "WasFlippyCreated" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QuestReward), QuestReward.Parser, new string[] { "OwnerGameAccountId", "SnoQuest", "XpGranted", "GoldGranted", "Items", "BonusXpGranted", "CurrencyGranted", "RepGranted", "SnoTrackedRewardGranted" }, null, null, null, new GeneratedClrTypeInfo[]
				{
					new GeneratedClrTypeInfo(typeof(QuestReward.Types.CurrencyReward), QuestReward.Types.CurrencyReward.Parser, new string[] { "Type", "Amount" }, null, null, null, null)
				}),
				new GeneratedClrTypeInfo(typeof(QuestComplete), QuestComplete.Parser, new string[] { "SnoQuest", "Rewards", "IsFailure", "IsSynced" }, null, null, null, null)
			}));
		}

		// Token: 0x04000C74 RID: 3188
		private static FileDescriptor descriptor;
	}
}
