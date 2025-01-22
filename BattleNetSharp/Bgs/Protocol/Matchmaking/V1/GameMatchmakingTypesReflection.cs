using System;
using Bgs.Protocol.Account.V1;
using Bgs.Protocol.V2;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003E1 RID: 993
	public static class GameMatchmakingTypesReflection
	{
		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x060062FB RID: 25339 RVA: 0x0017ED94 File Offset: 0x0017CF94
		public static FileDescriptor Descriptor
		{
			get
			{
				return GameMatchmakingTypesReflection.descriptor;
			}
		}

		// Token: 0x060062FC RID: 25340 RVA: 0x0017EDAC File Offset: 0x0017CFAC
		static GameMatchmakingTypesReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Ci5iZ3MvbG93L3BiL2NsaWVudC9nYW1lX21hdGNobWFraW5nX3R5cGVzLnBy", "b3RvEhtiZ3MucHJvdG9jb2wubWF0Y2htYWtpbmcudjEaIWJncy9sb3cvcGIv", "Y2xpZW50L3JwY190eXBlcy5wcm90bxo1YmdzL2xvdy9wYi9jbGllbnQvYXBp", "L2NsaWVudC92Mi9hdHRyaWJ1dGVfdHlwZXMucHJvdG8aJWJncy9sb3cvcGIv", "Y2xpZW50L2FjY291bnRfdHlwZXMucHJvdG8iXgoNSG9zdFByb3h5UGFpchIl", "CgRob3N0GAEgASgLMhcuYmdzLnByb3RvY29sLlByb2Nlc3NJZBImCgVwcm94", "eRgCIAEoCzIXLmJncy5wcm90b2NvbC5Qcm9jZXNzSWQiewoXTWF0Y2htYWtl", "ckF0dHJpYnV0ZUluZm8SDAoEbmFtZRgBIAEoCRIPCgdwcm9ncmFtGAIgASgH", "Ei0KCWF0dHJpYnV0ZRgDIAMoCzIaLmJncy5wcm90b2NvbC52Mi5BdHRyaWJ1", "dGUSEgoKaXNfcHJpdmF0ZRgEIAEoCCI/ChtNYXRjaG1ha2VyQ29udHJvbFBy",
				"b3BlcnRpZXMSIAoSYWNjZXB0X25ld19lbnRyaWVzGAEgASgIOgR0cnVlIkUK", "FEdhbWVNYXRjaG1ha2VyRmlsdGVyEi0KCWF0dHJpYnV0ZRgBIAMoCzIaLmJn", "cy5wcm90b2NvbC52Mi5BdHRyaWJ1dGUieQoGUGxheWVyEkAKDGdhbWVfYWNj", "b3VudBgBIAEoCzIqLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLkdhbWVBY2Nv", "dW50SGFuZGxlEi0KCWF0dHJpYnV0ZRgCIAMoCzIaLmJncy5wcm90b2NvbC52", "Mi5BdHRyaWJ1dGUiFwoJUmVxdWVzdElkEgoKAmlkGAEgASgGIkcKFkdhbWVD", "cmVhdGlvblByb3BlcnRpZXMSLQoJYXR0cmlidXRlGAEgAygLMhouYmdzLnBy", "b3RvY29sLnYyLkF0dHJpYnV0ZSLtAQoWR2FtZU1hdGNobWFraW5nT3B0aW9u", "cxJMChFtYXRjaG1ha2VyX2ZpbHRlchgBIAEoCzIxLmJncy5wcm90b2NvbC5t", "YXRjaG1ha2luZy52MS5HYW1lTWF0Y2htYWtlckZpbHRlchJQChNjcmVhdGlv",
				"bl9wcm9wZXJ0aWVzGAIgASgLMjMuYmdzLnByb3RvY29sLm1hdGNobWFraW5n", "LnYxLkdhbWVDcmVhdGlvblByb3BlcnRpZXMSMwoGcGxheWVyGAMgAygLMiMu", "YmdzLnByb3RvY29sLm1hdGNobWFraW5nLnYxLlBsYXllciKYAQoUR2FtZU1h", "dGNobWFraW5nRW50cnkSRAoHb3B0aW9ucxgBIAEoCzIzLmJncy5wcm90b2Nv", "bC5tYXRjaG1ha2luZy52MS5HYW1lTWF0Y2htYWtpbmdPcHRpb25zEjoKCnJl", "cXVlc3RfaWQYAiABKAsyJi5iZ3MucHJvdG9jb2wubWF0Y2htYWtpbmcudjEu", "UmVxdWVzdElkImQKC0Nvbm5lY3RJbmZvEiYKB2FkZHJlc3MYASABKAsyFS5i", "Z3MucHJvdG9jb2wuQWRkcmVzcxItCglhdHRyaWJ1dGUYAiADKAsyGi5iZ3Mu", "cHJvdG9jb2wudjIuQXR0cmlidXRlIlgKEE1hdGNobWFrZXJIYW5kbGUSOAoE", "YWRkchgBIAEoCzIqLmJncy5wcm90b2NvbC5tYXRjaG1ha2luZy52MS5Ib3N0",
				"UHJveHlQYWlyEgoKAmlkGAIgASgHIuUBCgpHYW1lSGFuZGxlEkUKCm1hdGNo", "bWFrZXIYASABKAsyLS5iZ3MucHJvdG9jb2wubWF0Y2htYWtpbmcudjEuTWF0", "Y2htYWtlckhhbmRsZUICGAESQwoLZ2FtZV9zZXJ2ZXIYAiABKAsyKi5iZ3Mu", "cHJvdG9jb2wubWF0Y2htYWtpbmcudjEuSG9zdFByb3h5UGFpckICGAESGAoQ", "Z2FtZV9pbnN0YW5jZV9pZBgDIAEoBxIXCg9tYXRjaG1ha2VyX2d1aWQYBCAB", "KAYSGAoQZ2FtZV9zZXJ2ZXJfZ3VpZBgFIAEoBiLwAQocQ3JlYXRlR2FtZVJl", "c3VsdE5vdGlmaWNhdGlvbhI8CgtnYW1lX2hhbmRsZRgBIAEoCzInLmJncy5w", "cm90b2NvbC5tYXRjaG1ha2luZy52MS5HYW1lSGFuZGxlEhAKCGVycm9yX2lk", "GAIgASgHEkAKDGdhbWVfYWNjb3VudBgDIAMoCzIqLmJncy5wcm90b2NvbC5h", "Y2NvdW50LnYxLkdhbWVBY2NvdW50SGFuZGxlEj4KDGNvbm5lY3RfaW5mbxgE",
				"IAMoCzIoLmJncy5wcm90b2NvbC5tYXRjaG1ha2luZy52MS5Db25uZWN0SW5m", "byLwAQocQWRkUGxheWVyc1Jlc3VsdE5vdGlmaWNhdGlvbhI8CgtnYW1lX2hh", "bmRsZRgBIAEoCzInLmJncy5wcm90b2NvbC5tYXRjaG1ha2luZy52MS5HYW1l", "SGFuZGxlEkAKDGdhbWVfYWNjb3VudBgCIAMoCzIqLmJncy5wcm90b2NvbC5h", "Y2NvdW50LnYxLkdhbWVBY2NvdW50SGFuZGxlEhAKCGVycm9yX2lkGAMgASgH", "Ej4KDGNvbm5lY3RfaW5mbxgEIAMoCzIoLmJncy5wcm90b2NvbC5tYXRjaG1h", "a2luZy52MS5Db25uZWN0SW5mbyKiAQoRVXBkYXRlR2FtZU9wdGlvbnMSPAoL", "Z2FtZV9oYW5kbGUYASABKAsyJy5iZ3MucHJvdG9jb2wubWF0Y2htYWtpbmcu", "djEuR2FtZUhhbmRsZRItCglhdHRyaWJ1dGUYAiADKAsyGi5iZ3MucHJvdG9j", "b2wudjIuQXR0cmlidXRlEiAKEnJlcGxhY2VfYXR0cmlidXRlcxgDIAEoCDoE",
				"dHJ1ZSKVAQoTUmVtb3ZlUGxheWVyT3B0aW9ucxI8CgtnYW1lX2hhbmRsZRgB", "IAEoCzInLmJncy5wcm90b2NvbC5tYXRjaG1ha2luZy52MS5HYW1lSGFuZGxl", "EkAKDGdhbWVfYWNjb3VudBgCIAEoCzIqLmJncy5wcm90b2NvbC5hY2NvdW50", "LnYxLkdhbWVBY2NvdW50SGFuZGxlIlEKEVJlbW92ZUdhbWVPcHRpb25zEjwK", "C2dhbWVfaGFuZGxlGAEgASgLMicuYmdzLnByb3RvY29sLm1hdGNobWFraW5n", "LnYxLkdhbWVIYW5kbGVCAkgB"
			}));
			GameMatchmakingTypesReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				RpcTypesReflection.Descriptor,
				AttributeTypesReflection.Descriptor,
				AccountTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(HostProxyPair), HostProxyPair.Parser, new string[] { "Host", "Proxy" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MatchmakerAttributeInfo), MatchmakerAttributeInfo.Parser, new string[] { "Name", "Program", "Attribute", "IsPrivate" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MatchmakerControlProperties), MatchmakerControlProperties.Parser, new string[] { "AcceptNewEntries" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameMatchmakerFilter), GameMatchmakerFilter.Parser, new string[] { "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(Player), Player.Parser, new string[] { "GameAccount", "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RequestId), RequestId.Parser, new string[] { "Id" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameCreationProperties), GameCreationProperties.Parser, new string[] { "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameMatchmakingOptions), GameMatchmakingOptions.Parser, new string[] { "MatchmakerFilter", "CreationProperties", "Player" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameMatchmakingEntry), GameMatchmakingEntry.Parser, new string[] { "Options", "RequestId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ConnectInfo), ConnectInfo.Parser, new string[] { "Address", "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MatchmakerHandle), MatchmakerHandle.Parser, new string[] { "Addr", "Id" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameHandle), GameHandle.Parser, new string[] { "Matchmaker", "GameServer", "GameInstanceId", "MatchmakerGuid", "GameServerGuid" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateGameResultNotification), CreateGameResultNotification.Parser, new string[] { "GameHandle", "ErrorId", "GameAccount", "ConnectInfo" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AddPlayersResultNotification), AddPlayersResultNotification.Parser, new string[] { "GameHandle", "GameAccount", "ErrorId", "ConnectInfo" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateGameOptions), UpdateGameOptions.Parser, new string[] { "GameHandle", "Attribute", "ReplaceAttributes" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RemovePlayerOptions), RemovePlayerOptions.Parser, new string[] { "GameHandle", "GameAccount" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RemoveGameOptions), RemoveGameOptions.Parser, new string[] { "GameHandle" }, null, null, null, null)
			}));
		}

		// Token: 0x04002D33 RID: 11571
		private static FileDescriptor descriptor;
	}
}
