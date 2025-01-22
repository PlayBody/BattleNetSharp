using System;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V1
{
	// Token: 0x020005DF RID: 1503
	public static class GameUtilitiesServiceReflection
	{
		// Token: 0x17002C57 RID: 11351
		// (get) Token: 0x06008D79 RID: 36217 RVA: 0x002253B8 File Offset: 0x002235B8
		public static FileDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.descriptor;
			}
		}

		// Token: 0x06008D7A RID: 36218 RVA: 0x002253D0 File Offset: 0x002235D0
		static GameUtilitiesServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Ci5iZ3MvbG93L3BiL2NsaWVudC9nYW1lX3V0aWxpdGllc19zZXJ2aWNlLnBy", "b3RvEh5iZ3MucHJvdG9jb2wuZ2FtZV91dGlsaXRpZXMudjEaJ2Jncy9sb3cv", "cGIvY2xpZW50L2F0dHJpYnV0ZV90eXBlcy5wcm90bxosYmdzL2xvdy9wYi9j", "bGllbnQvY29udGVudF9oYW5kbGVfdHlwZXMucHJvdG8aJGJncy9sb3cvcGIv", "Y2xpZW50L2VudGl0eV90eXBlcy5wcm90bxosYmdzL2xvdy9wYi9jbGllbnQv", "Z2FtZV91dGlsaXRpZXNfdHlwZXMucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50", "L3JwY190eXBlcy5wcm90byKRAgoNQ2xpZW50UmVxdWVzdBIqCglhdHRyaWJ1", "dGUYASADKAsyFy5iZ3MucHJvdG9jb2wuQXR0cmlidXRlEiUKBGhvc3QYAiAB", "KAsyFy5iZ3MucHJvdG9jb2wuUHJvY2Vzc0lkEioKCmFjY291bnRfaWQYAyAB", "KAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5SWQSLwoPZ2FtZV9hY2NvdW50X2lk",
				"GAQgASgLMhYuYmdzLnByb3RvY29sLkVudGl0eUlkEg8KB3Byb2dyYW0YBSAB", "KAcSPwoLY2xpZW50X2luZm8YBiABKAsyKi5iZ3MucHJvdG9jb2wuZ2FtZV91", "dGlsaXRpZXMudjEuQ2xpZW50SW5mbyI8Cg5DbGllbnRSZXNwb25zZRIqCglh", "dHRyaWJ1dGUYASADKAsyFy5iZ3MucHJvdG9jb2wuQXR0cmlidXRlInMKDVNl", "cnZlclJlcXVlc3QSKgoJYXR0cmlidXRlGAEgAygLMhcuYmdzLnByb3RvY29s", "LkF0dHJpYnV0ZRIPCgdwcm9ncmFtGAIgAigHEiUKBGhvc3QYAyABKAsyFy5i", "Z3MucHJvdG9jb2wuUHJvY2Vzc0lkIjwKDlNlcnZlclJlc3BvbnNlEioKCWF0", "dHJpYnV0ZRgBIAMoCzIXLmJncy5wcm90b2NvbC5BdHRyaWJ1dGUixwEKHVBy", "ZXNlbmNlQ2hhbm5lbENyZWF0ZWRSZXF1ZXN0EiIKAmlkGAEgAigLMhYuYmdz", "LnByb3RvY29sLkVudGl0eUlkEi8KD2dhbWVfYWNjb3VudF9pZBgDIAEoCzIW",
				"LmJncy5wcm90b2NvbC5FbnRpdHlJZBIqCgphY2NvdW50X2lkGAQgASgLMhYu", "YmdzLnByb3RvY29sLkVudGl0eUlkEiUKBGhvc3QYBSABKAsyFy5iZ3MucHJv", "dG9jb2wuUHJvY2Vzc0lkIo0BChlHZXRQbGF5ZXJWYXJpYWJsZXNSZXF1ZXN0", "EkkKEHBsYXllcl92YXJpYWJsZXMYASADKAsyLy5iZ3MucHJvdG9jb2wuZ2Ft", "ZV91dGlsaXRpZXMudjEuUGxheWVyVmFyaWFibGVzEiUKBGhvc3QYAiABKAsy", "Fy5iZ3MucHJvdG9jb2wuUHJvY2Vzc0lkImcKGkdldFBsYXllclZhcmlhYmxl", "c1Jlc3BvbnNlEkkKEHBsYXllcl92YXJpYWJsZXMYASADKAsyLy5iZ3MucHJv", "dG9jb2wuZ2FtZV91dGlsaXRpZXMudjEuUGxheWVyVmFyaWFibGVzIosBCh1H", "YW1lQWNjb3VudE9ubGluZU5vdGlmaWNhdGlvbhIvCg9nYW1lX2FjY291bnRf", "aWQYASACKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5SWQSJQoEaG9zdBgCIAEo",
				"CzIXLmJncy5wcm90b2NvbC5Qcm9jZXNzSWQSEgoKc2Vzc2lvbl9pZBgDIAEo", "CSKMAQoeR2FtZUFjY291bnRPZmZsaW5lTm90aWZpY2F0aW9uEi8KD2dhbWVf", "YWNjb3VudF9pZBgBIAIoCzIWLmJncy5wcm90b2NvbC5FbnRpdHlJZBIlCgRo", "b3N0GAIgASgLMhcuYmdzLnByb3RvY29sLlByb2Nlc3NJZBISCgpzZXNzaW9u", "X2lkGAMgASgJIkMKGkdldEFjaGlldmVtZW50c0ZpbGVSZXF1ZXN0EiUKBGhv", "c3QYASABKAsyFy5iZ3MucHJvdG9jb2wuUHJvY2Vzc0lkIlIKG0dldEFjaGll", "dmVtZW50c0ZpbGVSZXNwb25zZRIzCg5jb250ZW50X2hhbmRsZRgBIAEoCzIb", "LmJncy5wcm90b2NvbC5Db250ZW50SGFuZGxlInMKH0dldEFsbFZhbHVlc0Zv", "ckF0dHJpYnV0ZVJlcXVlc3QSFQoNYXR0cmlidXRlX2tleRgBIAEoCRIoCghh", "Z2VudF9pZBgCIAEoCzIWLmJncy5wcm90b2NvbC5FbnRpdHlJZBIPCgdwcm9n",
				"cmFtGAUgASgHIlIKIEdldEFsbFZhbHVlc0ZvckF0dHJpYnV0ZVJlc3BvbnNl", "Ei4KD2F0dHJpYnV0ZV92YWx1ZRgBIAMoCzIVLmJncy5wcm90b2NvbC5WYXJp", "YW50MpAJChRHYW1lVXRpbGl0aWVzU2VydmljZRJ9ChRQcm9jZXNzQ2xpZW50", "UmVxdWVzdBItLmJncy5wcm90b2NvbC5nYW1lX3V0aWxpdGllcy52MS5DbGll", "bnRSZXF1ZXN0Gi4uYmdzLnByb3RvY29sLmdhbWVfdXRpbGl0aWVzLnYxLkNs", "aWVudFJlc3BvbnNlIgaC+SsCCAESdQoWUHJlc2VuY2VDaGFubmVsQ3JlYXRl", "ZBI9LmJncy5wcm90b2NvbC5nYW1lX3V0aWxpdGllcy52MS5QcmVzZW5jZUNo", "YW5uZWxDcmVhdGVkUmVxdWVzdBoULmJncy5wcm90b2NvbC5Ob0RhdGEiBoL5", "KwIIAhKTAQoSR2V0UGxheWVyVmFyaWFibGVzEjkuYmdzLnByb3RvY29sLmdh", "bWVfdXRpbGl0aWVzLnYxLkdldFBsYXllclZhcmlhYmxlc1JlcXVlc3QaOi5i",
				"Z3MucHJvdG9jb2wuZ2FtZV91dGlsaXRpZXMudjEuR2V0UGxheWVyVmFyaWFi", "bGVzUmVzcG9uc2UiBoL5KwIIAxJ9ChRQcm9jZXNzU2VydmVyUmVxdWVzdBIt", "LmJncy5wcm90b2NvbC5nYW1lX3V0aWxpdGllcy52MS5TZXJ2ZXJSZXF1ZXN0", "Gi4uYmdzLnByb3RvY29sLmdhbWVfdXRpbGl0aWVzLnYxLlNlcnZlclJlc3Bv", "bnNlIgaC+SsCCAYSdwoTT25HYW1lQWNjb3VudE9ubGluZRI9LmJncy5wcm90", "b2NvbC5nYW1lX3V0aWxpdGllcy52MS5HYW1lQWNjb3VudE9ubGluZU5vdGlm", "aWNhdGlvbhoZLmJncy5wcm90b2NvbC5OT19SRVNQT05TRSIGgvkrAggHEnkK", "FE9uR2FtZUFjY291bnRPZmZsaW5lEj4uYmdzLnByb3RvY29sLmdhbWVfdXRp", "bGl0aWVzLnYxLkdhbWVBY2NvdW50T2ZmbGluZU5vdGlmaWNhdGlvbhoZLmJn", "cy5wcm90b2NvbC5OT19SRVNQT05TRSIGgvkrAggIEpYBChNHZXRBY2hpZXZl",
				"bWVudHNGaWxlEjouYmdzLnByb3RvY29sLmdhbWVfdXRpbGl0aWVzLnYxLkdl", "dEFjaGlldmVtZW50c0ZpbGVSZXF1ZXN0GjsuYmdzLnByb3RvY29sLmdhbWVf", "dXRpbGl0aWVzLnYxLkdldEFjaGlldmVtZW50c0ZpbGVSZXNwb25zZSIGgvkr", "AggJEqUBChhHZXRBbGxWYWx1ZXNGb3JBdHRyaWJ1dGUSPy5iZ3MucHJvdG9j", "b2wuZ2FtZV91dGlsaXRpZXMudjEuR2V0QWxsVmFsdWVzRm9yQXR0cmlidXRl", "UmVxdWVzdBpALmJncy5wcm90b2NvbC5nYW1lX3V0aWxpdGllcy52MS5HZXRB", "bGxWYWx1ZXNGb3JBdHRyaWJ1dGVSZXNwb25zZSIGgvkrAggKGjiC+SssCipi", "bmV0LnByb3RvY29sLmdhbWVfdXRpbGl0aWVzLkdhbWVVdGlsaXRpZXOK+SsE", "CAEQAUJECh9ibmV0LnByb3RvY29sLmdhbWVfdXRpbGl0aWVzLnYxQhlHYW1l", "VXRpbGl0aWVzU2VydmljZVByb3RvSAGAAQCIAQE="
			}));
			GameUtilitiesServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AttributeTypesReflection.Descriptor,
				ContentHandleTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				GameUtilitiesTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ClientRequest), ClientRequest.Parser, new string[] { "Attribute", "Host", "AccountId", "GameAccountId", "Program", "ClientInfo" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ClientResponse), ClientResponse.Parser, new string[] { "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ServerRequest), ServerRequest.Parser, new string[] { "Attribute", "Program", "Host" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ServerResponse), ServerResponse.Parser, new string[] { "Attribute" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(PresenceChannelCreatedRequest), PresenceChannelCreatedRequest.Parser, new string[] { "Id", "GameAccountId", "AccountId", "Host" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetPlayerVariablesRequest), GetPlayerVariablesRequest.Parser, new string[] { "PlayerVariables", "Host" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetPlayerVariablesResponse), GetPlayerVariablesResponse.Parser, new string[] { "PlayerVariables" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameAccountOnlineNotification), GameAccountOnlineNotification.Parser, new string[] { "GameAccountId", "Host", "SessionId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameAccountOfflineNotification), GameAccountOfflineNotification.Parser, new string[] { "GameAccountId", "Host", "SessionId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetAchievementsFileRequest), GetAchievementsFileRequest.Parser, new string[] { "Host" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetAchievementsFileResponse), GetAchievementsFileResponse.Parser, new string[] { "ContentHandle" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetAllValuesForAttributeRequest), GetAllValuesForAttributeRequest.Parser, new string[] { "AttributeKey", "AgentId", "Program" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetAllValuesForAttributeResponse), GetAllValuesForAttributeResponse.Parser, new string[] { "AttributeValue" }, null, null, null, null)
			}));
		}

		// Token: 0x04003FF5 RID: 16373
		private static FileDescriptor descriptor;
	}
}
