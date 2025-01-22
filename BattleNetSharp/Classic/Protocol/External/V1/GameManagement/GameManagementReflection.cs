using System;
using Bgs.Protocol;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GameManagement
{
	// Token: 0x0200078B RID: 1931
	public static class GameManagementReflection
	{
		// Token: 0x170036B0 RID: 14000
		// (get) Token: 0x0600B0EC RID: 45292 RVA: 0x002B0AFC File Offset: 0x002AECFC
		public static FileDescriptor Descriptor
		{
			get
			{
				return GameManagementReflection.descriptor;
			}
		}

		// Token: 0x0600B0ED RID: 45293 RVA: 0x002B0B14 File Offset: 0x002AED14
		static GameManagementReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"ChliZ3MvZ2FtZV9tYW5hZ2VtZW50LnByb3RvEixjbGFzc2ljLnByb3RvY29s", "LmV4dGVybmFsLnYxLmdhbWVfbWFuYWdlbWVudBohYmdzL2xvdy9wYi9jbGll", "bnQvcnBjX3R5cGVzLnByb3RvIisKCkdhbWVPcHRpb24SDgoGb3B0aW9uGAEg", "ASgJEg0KBXZhbHVlGAIgASgJIi8KDkdhbWVTZXJ2ZXJQaW5nEg4KBnJlZ2lv", "bhgBIAEoCRINCgV2YWx1ZRgCIAEoDSKFAwoRR2FtZUNyZWF0ZVJlcXVlc3QS", "DwoHY2hhcl9pZBgBIAEoDRIRCglnYW1lX25hbWUYAiABKAkSFQoNZ2FtZV9w", "YXNzd29yZBgDIAEoCRJJCgdvcHRpb25zGAQgAygLMjguY2xhc3NpYy5wcm90", "b2NvbC5leHRlcm5hbC52MS5nYW1lX21hbmFnZW1lbnQuR2FtZU9wdGlvbhIM", "CgRuZWcxGAUgASgNEg0KBWVtcHR5GAYgASgJEksKBXBpbmdzGAcgAygLMjwu", "Y2xhc3NpYy5wcm90b2NvbC5leHRlcm5hbC52MS5nYW1lX21hbmFnZW1lbnQu",
				"R2FtZVNlcnZlclBpbmcSEgoKY2hhcl9sZXZlbBgIIAEoDRIYChBsZXZlbF9k", "aWZmZXJlbmNlGAkgASgNEhMKC21heF9wbGF5ZXJzGAogASgNEg0KBWZsYWdz", "GAsgASgNEgwKBHVuazEYDCABKAkSDAoEdW5rMhgNIAEoCRISCgpkaWZmaWN1", "bHR5GA4gASgNIjUKEkdhbWVDcmVhdGVSZXNwb25zZRIKCgJpZBgBIAEoDRIT", "CgttYXhfcGxheWVycxgCIAEoDSJwCg9HYW1lSm9pblJlcXVlc3QSDwoHY2hh", "cl9pZBgBIAEoDRIRCglnYW1lX25hbWUYAiABKAkSFQoNZ2FtZV9wYXNzd29y", "ZBgDIAEoCRIOCgZyZWdpb24YBCABKAkSEgoKY2hhcl9sZXZlbBgFIAEoDSLi", "AQoPR2FtZUxpc3RSZXF1ZXN0Eg8KB2NoYXJfaWQYASABKA0SDwoHdW5remVy", "bxgCIAEoDRITCgtlbXB0eXN0cmluZxgDIAEoCRIMCgR4RjI4GAQgASgNEg0K", "BWxldmVsGAUgASgNEg4KBnJlZ2lvbhgGIAEoCRISCgpkaWZmaWN1bHR5GAcg",
				"ASgNEgoKAngwGAggASgNEksKBXBpbmdzGAkgAygLMjwuY2xhc3NpYy5wcm90", "b2NvbC5leHRlcm5hbC52MS5nYW1lX21hbmFnZW1lbnQuR2FtZVNlcnZlclBp", "bmci5wEKEEdhbWVKb2luUmVzcG9uc2USEgoKaXBfYWRkcmVzcxgBIAEoCRIM", "CgRwb3J0GAIgASgNEgwKBGhhc2gYAyABKAwSCgoCaWQYBCABKA0SGgoSc2Vy", "dmVyX2dpdF92ZXJzaW9uGAUgASgJEhEKCW9uZU9yWmVybxgGIAEoDRIUCgxm", "aWZ0eXR3bzAwMDQYByABKA0SDAoEb25lMhgIIAEoDRIRCgltYXhfbGV2ZWwY", "CSABKA0SDgoGcmVnaW9uGAogASgJEgwKBHplcm8YCyABKA0SEwoLbWF4X3Bs", "YXllcnMYDCABKA0iJgoRR2FtZURldGFpbFJlcXVlc3QSEQoJZ2FtZV9uYW1l", "GAEgAigJIl8KCkdhbWVQbGF5ZXISDAoEbmFtZRgBIAIoCRINCgVjbGFzcxgC", "IAIoDRINCgVsZXZlbBgDIAIoDRIUCgxjaGFyYWN0ZXJfaWQYBCACKA0SDwoH",
				"Ym5ldF9pZBgFIAIoDSKAAgoSR2FtZURldGFpbFJlc3BvbnNlEhEKCWdhbWVf", "bmFtZRgBIAIoCRIYChBnYW1lX2Rlc2NyaXB0aW9uGAIgAigJEg0KBWZsYWdz", "GAMgAigNEgwKBHRpbWUYBCACKA0SDQoFZW1wdHkYBSACKAkSEgoKY2hhcl9s", "ZXZlbBgGIAIoDRIYChBsZXZlbF9kaWZmZXJlbmNlGAcgAigNEhMKC21heF9w", "bGF5ZXJzGAggAigNEk4KDGdhbWVfcGxheWVycxgJIAMoCzI4LmNsYXNzaWMu", "cHJvdG9jb2wuZXh0ZXJuYWwudjEuZ2FtZV9tYW5hZ2VtZW50LkdhbWVQbGF5", "ZXIiWQoQR2FtZUxpc3RSZXNwb25zZRJFCgVnYW1lcxgDIAMoCzI2LmNsYXNz", "aWMucHJvdG9jb2wuZXh0ZXJuYWwudjEuZ2FtZV9tYW5hZ2VtZW50LkdhbWVJ", "bmZvIowBCghHYW1lSW5mbxIKCgJpZBgBIAEoDRITCgtudW1fcGxheWVycxgC", "IAEoDRITCgttYXhfcGxheWVycxgDIAEoDRINCgVmbGFncxgEIAEoDRIOCgZ1",
				"bnVzZWQYBSABKAkSEQoJZ2FtZV9uYW1lGAYgASgJEhgKEGdhbWVfZGVzY3Jp", "cHRpb24YByABKAkigQIKD0dhbWVNZ210UmVxdWVzdBIPCgdjaGFyX2lkGAEg", "ASgNEhEKCWdhbWVfbmFtZRgCIAEoCRIVCg1nYW1lX3Bhc3N3b3JkGAMgASgJ", "EkkKB29wdGlvbnMYBCADKAsyOC5jbGFzc2ljLnByb3RvY29sLmV4dGVybmFs", "LnYxLmdhbWVfbWFuYWdlbWVudC5HYW1lT3B0aW9uEgwKBG5lZzEYBSABKA0S", "DQoFZW1wdHkYBiABKAkSSwoFcGluZ3MYByADKAsyPC5jbGFzc2ljLnByb3Rv", "Y29sLmV4dGVybmFsLnYxLmdhbWVfbWFuYWdlbWVudC5HYW1lU2VydmVyUGlu", "ZyIgChBHYW1lTWdtdFJlc3BvbnNlEgwKBERhdGEYAyABKAwiLgoIR2FtZVNp", "dGUSEgoKaXBfYWRkcmVzcxgBIAEoCRIOCgZyZWdpb24YAiABKAkieAobR2Ft", "ZUdldFNpdGVQaW5nTGlzdFJlc3BvbnNlEkkKCWdhbWVfc2l0ZRgBIAMoCzI2",
				"LmNsYXNzaWMucHJvdG9jb2wuZXh0ZXJuYWwudjEuZ2FtZV9tYW5hZ2VtZW50", "LkdhbWVTaXRlEg4KBnJlZ2lvbhgCIAMoCTLzCQoOR2FtZU1hbmFnZW1lbnQS", "mwEKCkdhbWVDcmVhdGUSPy5jbGFzc2ljLnByb3RvY29sLmV4dGVybmFsLnYx", "LmdhbWVfbWFuYWdlbWVudC5HYW1lQ3JlYXRlUmVxdWVzdBpALmNsYXNzaWMu", "cHJvdG9jb2wuZXh0ZXJuYWwudjEuZ2FtZV9tYW5hZ2VtZW50LkdhbWVDcmVh", "dGVSZXNwb25zZSIKgvkrBgiZ976YCRKVAQoIR2FtZUpvaW4SPS5jbGFzc2lj", "LnByb3RvY29sLmV4dGVybmFsLnYxLmdhbWVfbWFuYWdlbWVudC5HYW1lSm9p", "blJlcXVlc3QaPi5jbGFzc2ljLnByb3RvY29sLmV4dGVybmFsLnYxLmdhbWVf", "bWFuYWdlbWVudC5HYW1lSm9pblJlc3BvbnNlIgqC+SsGCNGysK4KEpUBCghH", "YW1lTGlzdBI9LmNsYXNzaWMucHJvdG9jb2wuZXh0ZXJuYWwudjEuZ2FtZV9t",
				"YW5hZ2VtZW50LkdhbWVMaXN0UmVxdWVzdBo+LmNsYXNzaWMucHJvdG9jb2wu", "ZXh0ZXJuYWwudjEuZ2FtZV9tYW5hZ2VtZW50LkdhbWVMaXN0UmVzcG9uc2Ui", "CoL5KwYI7b6qrwoSmwEKCkdhbWVEZXRhaWwSPy5jbGFzc2ljLnByb3RvY29s", "LmV4dGVybmFsLnYxLmdhbWVfbWFuYWdlbWVudC5HYW1lRGV0YWlsUmVxdWVz", "dBpALmNsYXNzaWMucHJvdG9jb2wuZXh0ZXJuYWwudjEuZ2FtZV9tYW5hZ2Vt", "ZW50LkdhbWVEZXRhaWxSZXNwb25zZSIKgvkrBgjUprSuCxKdAQoQR2FtZUNy", "ZWF0ZUNhbmNlbBI9LmNsYXNzaWMucHJvdG9jb2wuZXh0ZXJuYWwudjEuZ2Ft", "ZV9tYW5hZ2VtZW50LkdhbWVNZ210UmVxdWVzdBo+LmNsYXNzaWMucHJvdG9j", "b2wuZXh0ZXJuYWwudjEuZ2FtZV9tYW5hZ2VtZW50LkdhbWVNZ210UmVzcG9u", "c2UiCoL5KwYIl4KdwQMSoAEKE0dhbWVDcmVhdGVRdWV1ZVRpbWUSPS5jbGFz",
				"c2ljLnByb3RvY29sLmV4dGVybmFsLnYxLmdhbWVfbWFuYWdlbWVudC5HYW1l", "TWdtdFJlcXVlc3QaPi5jbGFzc2ljLnByb3RvY29sLmV4dGVybmFsLnYxLmdh", "bWVfbWFuYWdlbWVudC5HYW1lTWdtdFJlc3BvbnNlIgqC+SsGCIW2t/kFEpoB", "Cg1HYW1lTWF0Y2htYWtlEj0uY2xhc3NpYy5wcm90b2NvbC5leHRlcm5hbC52", "MS5nYW1lX21hbmFnZW1lbnQuR2FtZU1nbXRSZXF1ZXN0Gj4uY2xhc3NpYy5w", "cm90b2NvbC5leHRlcm5hbC52MS5nYW1lX21hbmFnZW1lbnQuR2FtZU1nbXRS", "ZXNwb25zZSIKgvkrBgjko5ewChKCAQoTR2FtZUdldFNpdGVQaW5nTGlzdBIU", "LmJncy5wcm90b2NvbC5Ob0RhdGEaSS5jbGFzc2ljLnByb3RvY29sLmV4dGVy", "bmFsLnYxLmdhbWVfbWFuYWdlbWVudC5HYW1lR2V0U2l0ZVBpbmdMaXN0UmVz", "cG9uc2UiCoL5KwYIpJW32wsaEIL5KwwKCjB4MTEwRjI3NDE="
			}));
			GameManagementReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[] { RpcTypesReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(GameOption), GameOption.Parser, new string[] { "Option", "Value" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameServerPing), GameServerPing.Parser, new string[] { "Region", "Value" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameCreateRequest), GameCreateRequest.Parser, new string[]
				{
					"CharId", "GameName", "GamePassword", "Options", "Neg1", "Empty", "Pings", "CharLevel", "LevelDifference", "MaxPlayers",
					"Flags", "Unk1", "Unk2", "Difficulty"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameCreateResponse), GameCreateResponse.Parser, new string[] { "Id", "MaxPlayers" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameJoinRequest), GameJoinRequest.Parser, new string[] { "CharId", "GameName", "GamePassword", "Region", "CharLevel" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameListRequest), GameListRequest.Parser, new string[] { "CharId", "Unkzero", "Emptystring", "XF28", "Level", "Region", "Difficulty", "X0", "Pings" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameJoinResponse), GameJoinResponse.Parser, new string[]
				{
					"IpAddress", "Port", "Hash", "Id", "ServerGitVersion", "OneOrZero", "Fiftytwo0004", "One2", "MaxLevel", "Region",
					"Zero", "MaxPlayers"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameDetailRequest), GameDetailRequest.Parser, new string[] { "GameName" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GamePlayer), GamePlayer.Parser, new string[] { "Name", "Class", "Level", "CharacterId", "BnetId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameDetailResponse), GameDetailResponse.Parser, new string[] { "GameName", "GameDescription", "Flags", "Time", "Empty", "CharLevel", "LevelDifference", "MaxPlayers", "GamePlayers" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameListResponse), GameListResponse.Parser, new string[] { "Games" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameInfo), GameInfo.Parser, new string[] { "Id", "NumPlayers", "MaxPlayers", "Flags", "Unused", "GameName", "GameDescription" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameMgmtRequest), GameMgmtRequest.Parser, new string[] { "CharId", "GameName", "GamePassword", "Options", "Neg1", "Empty", "Pings" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameMgmtResponse), GameMgmtResponse.Parser, new string[] { "Data" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameSite), GameSite.Parser, new string[] { "IpAddress", "Region" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameGetSitePingListResponse), GameGetSitePingListResponse.Parser, new string[] { "GameSite", "Region" }, null, null, null, null)
			}));
		}

		// Token: 0x04004FC4 RID: 20420
		private static FileDescriptor descriptor;
	}
}
