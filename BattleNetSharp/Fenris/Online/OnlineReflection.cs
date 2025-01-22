using System;
using Fenris.AccountMigration;
using Fenris.Clan;
using Fenris.Hero;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x0200013E RID: 318
	public static class OnlineReflection
	{
		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x0007FA38 File Offset: 0x0007DC38
		public static FileDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.descriptor;
			}
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x0007FA50 File Offset: 0x0007DC50
		static OnlineReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CgxPbmxpbmUucHJvdG8SDUZlbnJpcy5PbmxpbmUaEEhlcm9Db21tb24ucHJv", "dG8aEk9ubGluZUNvbW1vbi5wcm90bxoWQWNjb3VudE1pZ3JhdGlvbi5wcm90", "bxoKQ2xhbi5wcm90byKOAgoQR2FtZUNyZWF0ZVBhcmFtcxIRCglnYW1lX3R5", "cGUYASACKBESGQoOY3JlYXRpb25fZmxhZ3MYAiACKA06ATASFwoLc25vX3N1", "YnpvbmUYAyABKBE6Ai0xEhUKCXNub193b3JsZBgEIAEoEToCLTESGQoRaXRl", "bXBvd2VyX2JyYWNrZXQYBSABKA0SDAoEbmFtZRgGIAEoCRIWCg5wYXJ0aXRp", "b25fdHlwZRgHIAEoDRITCgtzZXJ2ZXJfcG9vbBgIIAEoCRIyCg5jYW1wYWln", "bl9zdGF0ZRgJIAEoCzIaLkZlbnJpcy5IZXJvLkNhbXBhaWduU3RhdGUSEgoK", "cHZwX2J1Y2tldBgKIAEoDSKGAQoUUGxheWVyVHJhbnNmZXJQYXJhbXMSKgoi", "dHJhbnNmZXJfZnJvbV9zZXJ2ZXJfbWVzc2FnZV9xdWV1ZRgBIAEoCRIeChJ0",
				"cmFuc2Zlcl9mcm9tX2dhbWUYAiABKA86Ai0xEiIKE2lzX2RlbGF5ZWRfdHJh", "bnNmZXIYAyABKAg6BWZhbHNlIjEKDFByZXNoYXJlZEtleRIPCgdtb2R1bHVz", "GAEgASgMEhAKCGV4cG9uZW50GAIgASgMIn0KGENvbm5lY3Rpb25FbmNyeXB0", "aW9uSW5mbxIyCg1wcmVzaGFyZWRfa2V5GAEgASgLMhsuRmVucmlzLk9ubGlu", "ZS5QcmVzaGFyZWRLZXkSDQoFdG9rZW4YAiABKAQSHgoWZGVwcmVjYXRlZF9j", "b21tb25fbmFtZRgGIAEoCSKfAwoOQ29ubmVjdGlvbkluZm8SLgoLZ2FtZV9o", "YW5kbGUYASABKAsyGS5GZW5yaXMuT25saW5lLkdhbWVIYW5kbGUSDwoHZ2Ft", "ZV9pZBgCIAEoBxI0CgtnYW1lX3BhcmFtcxgDIAEoCzIfLkZlbnJpcy5Pbmxp", "bmUuR2FtZUNyZWF0ZVBhcmFtcxIPCgdhZGRyZXNzGAQgASgJEgwKBHBvcnQY", "BSABKA0SHQoVc2VydmljZV9tZXNzYWdlX3F1ZXVlGAggASgJEjQKBnBsYXll",
				"chgJIAMoCzIkLkZlbnJpcy5PbmxpbmUuQ29ubmVjdGlvbkluZm8uUGxheWVy", "GqEBCgZQbGF5ZXISFwoPYm5ldF9hY2NvdW50X2lkGAEgASgNEhcKD2dhbWVf", "YWNjb3VudF9pZBgCIAEoDRISCgphdXRoX3Rva2VuGAMgASgGEkAKD2VuY3J5", "cHRpb25faW5mbxgEIAEoCzInLkZlbnJpcy5PbmxpbmUuQ29ubmVjdGlvbkVu", "Y3J5cHRpb25JbmZvEg8KB3RlYW1faWQYBSABKA0i6wEKElBpbmdDb25uZWN0", "aW9uSW5mbxIPCgdhZGRyZXNzGAEgASgJEgwKBHBvcnQYAiABKA0SQAoPZW5j", "cnlwdGlvbl9pbmZvGAMgASgLMicuRmVucmlzLk9ubGluZS5Db25uZWN0aW9u", "RW5jcnlwdGlvbkluZm8SEwoLc2VydmVyX3Bvb2wYBCABKAkSGwoTbWF4X3Nh", "bXBsZV9pbnRlcnZhbBgFIAEoDRIYChBjYXB0dXJlX2R1cmF0aW9uGAYgASgN", "EhMKC21pbl9zYW1wbGVzGAcgASgNEhMKC21heF9zYW1wbGVzGAggASgNInoK",
				"FlBpbmdDb25uZWN0aW9uSW5mb0xpc3QSOwoQY29ubmVjdGlvbl9pbmZvcxgB", "IAMoCzIhLkZlbnJpcy5PbmxpbmUuUGluZ0Nvbm5lY3Rpb25JbmZvEiMKBXRy", "YWNlGAIgASgLMhQuRmVucmlzLk9ubGluZS5UcmFjZSIyCgpQaW5nUmVzdWx0", "EhMKC3NlcnZlcl9wb29sGAEgASgJEg8KB2xhdGVuY3kYAiABKA0iPwoJQ2hh", "bm5lbElkEgoKAmlkGAEgASgNEhIKCmhvc3RfbGFiZWwYAyABKA0SEgoKaG9z", "dF9lcG9jaBgEIAEoDSJuChBIZXJvQ3JlYXRlUGFyYW1zEgwKBG5hbWUYASAC", "KAkSFgoKZ2JpZF9jbGFzcxgCIAIoDzoCLTESGgoLaXNfaGFyZGNvcmUYAyAC", "KAg6BWZhbHNlEhgKCWlzX2ZlbWFsZRgEIAIoCDoFZmFsc2UiPgoPQ29uc29s", "ZVByZXNlbmNlEhIKCmFjY291bnRfaWQYASABKA0SFwoPZ2FtZV9hY2NvdW50", "X2lkGAIgASgEIpkBCghYVmFyaWFudBIUCgpib29sX3ZhbHVlGAEgASgISAAS",
				"FAoKdWludF92YWx1ZRgCIAEoBEgAEhMKCWludF92YWx1ZRgDIAEoA0gAEhYK", "DGRvdWJsZV92YWx1ZRgEIAEoAUgAEhYKDHN0cmluZ192YWx1ZRgGIAEoCUgA", "EhQKCmJsb2JfdmFsdWUYByABKAxIAEIGCgR0eXBlIj8KCUF0dHJpYnV0ZRIK", "CgJpZBgBIAEoDRImCgV2YWx1ZRgCIAEoCzIXLkZlbnJpcy5PbmxpbmUuWFZh", "cmlhbnQiPQoNQXR0cmlidXRlTGlzdBIsCgphdHRyaWJ1dGVzGAEgAygLMhgu", "RmVucmlzLk9ubGluZS5BdHRyaWJ1dGUiPQoHUXVldWVJZBISCgpxdWV1ZV90", "eXBlGAEgASgNEgoKAmlkGAIgASgJEhIKCnNlcnZlcnBvb2wYAyABKAkiSwoN", "UXVldWVFbnRyeUtleRIoCghxdWV1ZV9pZBgBIAEoCzIWLkZlbnJpcy5Pbmxp", "bmUuUXVldWVJZBIQCghlbnRyeV9pZBgCIAEoCSJKCgpRdWV1ZUVudHJ5EhAK", "CGVudHJ5X2lkGAEgASgJEg8KB3BheWxvYWQYAiABKAwSGQoRYWNxdWlzaXRp",
				"b25fdG9rZW4YAyABKA0iTgoTQ2x1c3RlcmVkU2VydmVySW5mbxIMCgRndWlk", "GAEgASgGEhIKCmVwb2NoX3RpbWUYAiABKAYSFQoNbWVzc2FnZV9xdWV1ZRgD", "IAEoCSJhCg9UcmFuc2FjdGlvbkJsb2ISQwoRYWNjb3VudF9taWdyYXRpb24Y", "ASABKAsyJi5GZW5yaXMuQWNjb3VudE1pZ3JhdGlvbi5NaWdyYXRpb25EYXRh", "SABCCQoHbWVzc2FnZSJjCgxDbGFuVUdDUmVzZXQSQAoMY29udGVudF90eXBl", "GAEgASgOMhwuRmVucmlzLkNsYW4uQ2xhbkNvbnRlbnRUeXBlOgxJTlZBTElE", "X1RZUEUSEQoJY2xhbl9uYW1lGAIgASgJIpIEChJQbGF5ZXJOb3RpZmljYXRp", "b24SCgoCaWQYASABKAkSPQoEdHlwZRgCIAEoDjImLkZlbnJpcy5PbmxpbmUu", "UGxheWVyTm90aWZpY2F0aW9uLlR5cGU6B0lOVkFMSUQSGAoOY29tcGxhaW50", "X3R5cGUYBCABKAlIABIXCg1uZXdfY2xhbl9yYW5rGAUgASgNSAASEwoJY2xh",
				"bl9uYW1lGAYgASgJSAASHgoUZmFsbGVuX2hlcm9fcmVwbGFjZWQYByABKAhI", "ABI1Cg5jbGFuX3VnY19yZXNldBgIIAEoCzIbLkZlbnJpcy5PbmxpbmUuQ2xh", "blVHQ1Jlc2V0SAAiiQIKBFR5cGUSCwoHSU5WQUxJRBAAEiIKHkNPTVBMQUlO", "VF9ORUFSX1BFTkFMVFlfV0FSTklORxABEhoKFkNPTVBMQUlOVF9BQ1RJT05f", "VEFLRU4QAhISCg5DTEFOX1BST01PVElPThADEhEKDUNMQU5fREVNT1RJT04Q", "BBINCglDTEFOX0tJQ0sQBRIMCghDTEFOX0JBThAGEhAKDENMQU5fRElTQkFO", "RBAHEhcKE0ZBTExFTl9IRVJPX0NSRUFURUQQCBIZChVIQVJEQ09SRV9IRVJP", "X0RFTEVURUQQCRISCg5DTEFOX1VHQ19SRVNFVBAKEhYKEkhFUk9fRk9SQ0Vf", "UkVOQU1FRBALQgYKBGRhdGEiZgoFVHJhY2USCgoCaWQYASABKAkSDwoHc3Bh", "bl9pZBgCIAEoCRIXCg9nYW1lX2FjY291bnRfaWQYAyABKA0SDAoEbmFtZRgE",
				"IAEoCRIZCgppc190cmFja2VkGAUgASgIOgVmYWxzZQ=="
			}));
			OnlineReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				HeroCommonReflection.Descriptor,
				OnlineCommonReflection.Descriptor,
				AccountMigrationReflection.Descriptor,
				ClanReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(GameCreateParams), GameCreateParams.Parser, new string[] { "GameType", "CreationFlags", "SnoSubzone", "SnoWorld", "ItempowerBracket", "Name", "PartitionType", "ServerPool", "CampaignState", "PvpBucket" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PlayerTransferParams), PlayerTransferParams.Parser, new string[] { "TransferFromServerMessageQueue", "TransferFromGame", "IsDelayedTransfer" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PresharedKey), PresharedKey.Parser, new string[] { "Modulus", "Exponent" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ConnectionEncryptionInfo), ConnectionEncryptionInfo.Parser, new string[] { "PresharedKey", "Token", "DeprecatedCommonName" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ConnectionInfo), ConnectionInfo.Parser, new string[] { "GameHandle", "GameId", "GameParams", "Address", "Port", "ServiceMessageQueue", "Player" }, null, null, null, new GeneratedClrTypeInfo[]
				{
					new GeneratedClrTypeInfo(typeof(ConnectionInfo.Types.Player), ConnectionInfo.Types.Player.Parser, new string[] { "BnetAccountId", "GameAccountId", "AuthToken", "EncryptionInfo", "TeamId" }, null, null, null, null)
				}),
				new GeneratedClrTypeInfo(typeof(PingConnectionInfo), PingConnectionInfo.Parser, new string[] { "Address", "Port", "EncryptionInfo", "ServerPool", "MaxSampleInterval", "CaptureDuration", "MinSamples", "MaxSamples" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PingConnectionInfoList), PingConnectionInfoList.Parser, new string[] { "ConnectionInfos", "Trace" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PingResult), PingResult.Parser, new string[] { "ServerPool", "Latency" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ChannelId), ChannelId.Parser, new string[] { "Id", "HostLabel", "HostEpoch" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(HeroCreateParams), HeroCreateParams.Parser, new string[] { "Name", "GbidClass", "IsHardcore", "IsFemale" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ConsolePresence), ConsolePresence.Parser, new string[] { "AccountId", "GameAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(XVariant), XVariant.Parser, new string[] { "BoolValue", "UintValue", "IntValue", "DoubleValue", "StringValue", "BlobValue" }, new string[] { "Type" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(Attribute), Attribute.Parser, new string[] { "Id", "Value" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AttributeList), AttributeList.Parser, new string[] { "Attributes" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueueId), QueueId.Parser, new string[] { "QueueType", "Id", "Serverpool" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueueEntryKey), QueueEntryKey.Parser, new string[] { "QueueId", "EntryId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(QueueEntry), QueueEntry.Parser, new string[] { "EntryId", "Payload", "AcquisitionToken" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClusteredServerInfo), ClusteredServerInfo.Parser, new string[] { "Guid", "EpochTime", "MessageQueue" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(TransactionBlob), TransactionBlob.Parser, new string[] { "AccountMigration" }, new string[] { "Message" }, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClanUGCReset), ClanUGCReset.Parser, new string[] { "ContentType", "ClanName" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PlayerNotification), PlayerNotification.Parser, new string[] { "Id", "Type", "ComplaintType", "NewClanRank", "ClanName", "FallenHeroReplaced", "ClanUgcReset" }, new string[] { "Data" }, new Type[] { typeof(PlayerNotification.Types.Type) }, null, null),
				new GeneratedClrTypeInfo(typeof(Trace), Trace.Parser, new string[] { "Id", "SpanId", "GameAccountId", "Name", "IsTracked" }, null, null, null, null)
			}));
		}

		// Token: 0x04000E77 RID: 3703
		private static FileDescriptor descriptor;
	}
}
