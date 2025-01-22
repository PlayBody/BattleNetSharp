using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x02000604 RID: 1540
	public static class AuthenticationServiceReflection
	{
		// Token: 0x17002D05 RID: 11525
		// (get) Token: 0x0600900A RID: 36874 RVA: 0x0022EBD8 File Offset: 0x0022CDD8
		public static FileDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.descriptor;
			}
		}

		// Token: 0x0600900B RID: 36875 RVA: 0x0022EBF0 File Offset: 0x0022CDF0
		static AuthenticationServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"Ci5iZ3MvbG93L3BiL2NsaWVudC9hdXRoZW50aWNhdGlvbl9zZXJ2aWNlLnBy", "b3RvEh5iZ3MucHJvdG9jb2wuYXV0aGVudGljYXRpb24udjEaJWJncy9sb3cv", "cGIvY2xpZW50L2FjY291bnRfdHlwZXMucHJvdG8aLGJncy9sb3cvcGIvY2xp", "ZW50L2NvbnRlbnRfaGFuZGxlX3R5cGVzLnByb3RvGiRiZ3MvbG93L3BiL2Ns", "aWVudC9lbnRpdHlfdHlwZXMucHJvdG8aIWJncy9sb3cvcGIvY2xpZW50L3Jw", "Y190eXBlcy5wcm90byJYChFNb2R1bGVMb2FkUmVxdWVzdBIyCg1tb2R1bGVf", "aGFuZGxlGAEgAigLMhsuYmdzLnByb3RvY29sLkNvbnRlbnRIYW5kbGUSDwoH", "bWVzc2FnZRgCIAEoDCI3ChJNb2R1bGVOb3RpZmljYXRpb24SEQoJbW9kdWxl", "X2lkGAIgASgFEg4KBnJlc3VsdBgDIAEoDSI6ChRNb2R1bGVNZXNzYWdlUmVx", "dWVzdBIRCgltb2R1bGVfaWQYASACKAUSDwoHbWVzc2FnZRgCIAEoDCLMAgoM",
				"TG9nb25SZXF1ZXN0Eg8KB3Byb2dyYW0YASABKAkSEAoIcGxhdGZvcm0YAiAB", "KAkSDgoGbG9jYWxlGAMgASgJEg0KBWVtYWlsGAQgASgJEg8KB3ZlcnNpb24Y", "BSABKAkSGwoTYXBwbGljYXRpb25fdmVyc2lvbhgGIAEoBRIXCg9wdWJsaWNf", "Y29tcHV0ZXIYByABKAgSLgofYWxsb3dfbG9nb25fcXVldWVfbm90aWZpY2F0", "aW9ucxgKIAEoCDoFZmFsc2USJgoXd2ViX2NsaWVudF92ZXJpZmljYXRpb24Y", "CyABKAg6BWZhbHNlEh4KFmNhY2hlZF93ZWJfY3JlZGVudGlhbHMYDCABKAwS", "EgoKdXNlcl9hZ2VudBgOIAEoCRIRCglkZXZpY2VfaWQYDyABKAkSFAoMcGhv", "bmVfbnVtYmVyGBAgASgJIq0CCgtMb2dvblJlc3VsdBISCgplcnJvcl9jb2Rl", "GAEgAigNEioKCmFjY291bnRfaWQYAiABKAsyFi5iZ3MucHJvdG9jb2wuRW50", "aXR5SWQSLwoPZ2FtZV9hY2NvdW50X2lkGAMgAygLMhYuYmdzLnByb3RvY29s",
				"LkVudGl0eUlkEg0KBWVtYWlsGAQgASgJEhgKEGF2YWlsYWJsZV9yZWdpb24Y", "BSADKA0SGAoQY29ubmVjdGVkX3JlZ2lvbhgGIAEoDRISCgpiYXR0bGVfdGFn", "GAcgASgJEhUKDWdlb2lwX2NvdW50cnkYCCABKAkSEwoLc2Vzc2lvbl9rZXkY", "CSABKAwSFwoPcmVzdHJpY3RlZF9tb2RlGAogASgIEhEKCWNsaWVudF9pZBgL", "IAEoCSIqChdHZW5lcmF0ZVNTT1Rva2VuUmVxdWVzdBIPCgdwcm9ncmFtGAEg", "ASgHIj4KGEdlbmVyYXRlU1NPVG9rZW5SZXNwb25zZRIOCgZzc29faWQYASAB", "KAwSEgoKc3NvX3NlY3JldBgCIAEoDCIoChJMb2dvblVwZGF0ZVJlcXVlc3QS", "EgoKZXJyb3JfY29kZRgBIAIoDSJhChdMb2dvblF1ZXVlVXBkYXRlUmVxdWVz", "dBIQCghwb3NpdGlvbhgBIAIoDRIWCg5lc3RpbWF0ZWRfdGltZRgCIAIoBBIc", "ChRldGFfZGV2aWF0aW9uX2luX3NlYxgDIAIoBCK+AQobQWNjb3VudFNldHRp",
				"bmdzTm90aWZpY2F0aW9uEjkKCGxpY2Vuc2VzGAEgAygLMicuYmdzLnByb3Rv", "Y29sLmFjY291bnQudjEuQWNjb3VudExpY2Vuc2USFAoMaXNfdXNpbmdfcmlk", "GAIgASgIEhsKE2lzX3BsYXlpbmdfZnJvbV9pZ3IYAyABKAgSGQoRY2FuX3Jl", "Y2VpdmVfdm9pY2UYBCABKAgSFgoOY2FuX3NlbmRfdm9pY2UYBSABKAgiPQoY", "U2VydmVyU3RhdGVDaGFuZ2VSZXF1ZXN0Eg0KBXN0YXRlGAEgAigNEhIKCmV2", "ZW50X3RpbWUYAiACKAQiVAoLVmVyc2lvbkluZm8SDgoGbnVtYmVyGAEgASgN", "Eg0KBXBhdGNoGAIgASgJEhMKC2lzX29wdGlvbmFsGAMgASgIEhEKCWtpY2tf", "dGltZRgEIAEoBCJcChdWZXJzaW9uSW5mb05vdGlmaWNhdGlvbhJBCgx2ZXJz", "aW9uX2luZm8YASABKAsyKy5iZ3MucHJvdG9jb2wuYXV0aGVudGljYXRpb24u", "djEuVmVyc2lvbkluZm8iXwoUTWVtTW9kdWxlTG9hZFJlcXVlc3QSKwoGaGFu",
				"ZGxlGAEgAigLMhsuYmdzLnByb3RvY29sLkNvbnRlbnRIYW5kbGUSCwoDa2V5", "GAIgAigMEg0KBWlucHV0GAMgAigMIiUKFU1lbU1vZHVsZUxvYWRSZXNwb25z", "ZRIMCgRkYXRhGAEgAigMIksKGFNlbGVjdEdhbWVBY2NvdW50UmVxdWVzdBIv", "Cg9nYW1lX2FjY291bnRfaWQYASACKAsyFi5iZ3MucHJvdG9jb2wuRW50aXR5", "SWQiXQoaR2FtZUFjY291bnRTZWxlY3RlZFJlcXVlc3QSDgoGcmVzdWx0GAEg", "AigNEi8KD2dhbWVfYWNjb3VudF9pZBgCIAEoCzIWLmJncy5wcm90b2NvbC5F", "bnRpdHlJZCIwCh1HZW5lcmF0ZVdlYkNyZWRlbnRpYWxzUmVxdWVzdBIPCgdw", "cm9ncmFtGAEgASgHIjkKHkdlbmVyYXRlV2ViQ3JlZGVudGlhbHNSZXNwb25z", "ZRIXCg93ZWJfY3JlZGVudGlhbHMYASABKAwiNgobVmVyaWZ5V2ViQ3JlZGVu", "dGlhbHNSZXF1ZXN0EhcKD3dlYl9jcmVkZW50aWFscxgBIAEoDDKfCQoWQXV0",
				"aGVudGljYXRpb25MaXN0ZW5lchJnCgxPbk1vZHVsZUxvYWQSMS5iZ3MucHJv", "dG9jb2wuYXV0aGVudGljYXRpb24udjEuTW9kdWxlTG9hZFJlcXVlc3QaGS5i", "Z3MucHJvdG9jb2wuTk9fUkVTUE9OU0UiCYgCAYL5KwIIARJoCg9Pbk1vZHVs", "ZU1lc3NhZ2USNC5iZ3MucHJvdG9jb2wuYXV0aGVudGljYXRpb24udjEuTW9k", "dWxlTWVzc2FnZVJlcXVlc3QaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIgmIAgGC", "+SsCCAIScgoTT25TZXJ2ZXJTdGF0ZUNoYW5nZRI4LmJncy5wcm90b2NvbC5h", "dXRoZW50aWNhdGlvbi52MS5TZXJ2ZXJTdGF0ZUNoYW5nZVJlcXVlc3QaGS5i", "Z3MucHJvdG9jb2wuTk9fUkVTUE9OU0UiBoL5KwIIBBJhCg9PbkxvZ29uQ29t", "cGxldGUSKy5iZ3MucHJvdG9jb2wuYXV0aGVudGljYXRpb24udjEuTG9nb25S", "ZXN1bHQaGS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9OU0UiBoL5KwIIBRKGAQoP",
				"T25NZW1Nb2R1bGVMb2FkEjQuYmdzLnByb3RvY29sLmF1dGhlbnRpY2F0aW9u", "LnYxLk1lbU1vZHVsZUxvYWRSZXF1ZXN0GjUuYmdzLnByb3RvY29sLmF1dGhl", "bnRpY2F0aW9uLnYxLk1lbU1vZHVsZUxvYWRSZXNwb25zZSIGgvkrAggGEmYK", "DU9uTG9nb25VcGRhdGUSMi5iZ3MucHJvdG9jb2wuYXV0aGVudGljYXRpb24u", "djEuTG9nb25VcGRhdGVSZXF1ZXN0GhkuYmdzLnByb3RvY29sLk5PX1JFU1BP", "TlNFIgaC+SsCCAoScgoUT25WZXJzaW9uSW5mb1VwZGF0ZWQSNy5iZ3MucHJv", "dG9jb2wuYXV0aGVudGljYXRpb24udjEuVmVyc2lvbkluZm9Ob3RpZmljYXRp", "b24aGS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9OU0UiBoL5KwIICxJwChJPbkxv", "Z29uUXVldWVVcGRhdGUSNy5iZ3MucHJvdG9jb2wuYXV0aGVudGljYXRpb24u", "djEuTG9nb25RdWV1ZVVwZGF0ZVJlcXVlc3QaGS5iZ3MucHJvdG9jb2wuTk9f",
				"UkVTUE9OU0UiBoL5KwIIDBJKCg9PbkxvZ29uUXVldWVFbmQSFC5iZ3MucHJv", "dG9jb2wuTm9EYXRhGhkuYmdzLnByb3RvY29sLk5PX1JFU1BPTlNFIgaC+SsC", "CA0SeQoVT25HYW1lQWNjb3VudFNlbGVjdGVkEjouYmdzLnByb3RvY29sLmF1", "dGhlbnRpY2F0aW9uLnYxLkdhbWVBY2NvdW50U2VsZWN0ZWRSZXF1ZXN0Ghku", "YmdzLnByb3RvY29sLk5PX1JFU1BPTlNFIgmIAgGC+SsCCA4aPYL5KzMKMWJu", "ZXQucHJvdG9jb2wuYXV0aGVudGljYXRpb24uQXV0aGVudGljYXRpb25DbGll", "bnSK+SsCCAEy5gcKFUF1dGhlbnRpY2F0aW9uU2VydmljZRJTCgVMb2dvbhIs", "LmJncy5wcm90b2NvbC5hdXRoZW50aWNhdGlvbi52MS5Mb2dvblJlcXVlc3Qa", "FC5iZ3MucHJvdG9jb2wuTm9EYXRhIgaC+SsCCAESYwoMTW9kdWxlTm90aWZ5", "EjIuYmdzLnByb3RvY29sLmF1dGhlbnRpY2F0aW9uLnYxLk1vZHVsZU5vdGlm",
				"aWNhdGlvbhoULmJncy5wcm90b2NvbC5Ob0RhdGEiCYgCAYL5KwIIAhJmCg1N", "b2R1bGVNZXNzYWdlEjQuYmdzLnByb3RvY29sLmF1dGhlbnRpY2F0aW9uLnYx", "Lk1vZHVsZU1lc3NhZ2VSZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0YSIJ", "iAIBgvkrAggDElcKHFNlbGVjdEdhbWVBY2NvdW50X0RFUFJFQ0FURUQSFi5i", "Z3MucHJvdG9jb2wuRW50aXR5SWQaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIgmI", "AgGC+SsCCAQSjQEKEEdlbmVyYXRlU1NPVG9rZW4SNy5iZ3MucHJvdG9jb2wu", "YXV0aGVudGljYXRpb24udjEuR2VuZXJhdGVTU09Ub2tlblJlcXVlc3QaOC5i", "Z3MucHJvdG9jb2wuYXV0aGVudGljYXRpb24udjEuR2VuZXJhdGVTU09Ub2tl", "blJlc3BvbnNlIgaC+SsCCAUSbgoRU2VsZWN0R2FtZUFjY291bnQSOC5iZ3Mu", "cHJvdG9jb2wuYXV0aGVudGljYXRpb24udjEuU2VsZWN0R2FtZUFjY291bnRS",
				"ZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0YSIJiAIBgvkrAggGEnEKFFZl", "cmlmeVdlYkNyZWRlbnRpYWxzEjsuYmdzLnByb3RvY29sLmF1dGhlbnRpY2F0", "aW9uLnYxLlZlcmlmeVdlYkNyZWRlbnRpYWxzUmVxdWVzdBoULmJncy5wcm90", "b2NvbC5Ob0RhdGEiBoL5KwIIBxKfAQoWR2VuZXJhdGVXZWJDcmVkZW50aWFs", "cxI9LmJncy5wcm90b2NvbC5hdXRoZW50aWNhdGlvbi52MS5HZW5lcmF0ZVdl", "YkNyZWRlbnRpYWxzUmVxdWVzdBo+LmJncy5wcm90b2NvbC5hdXRoZW50aWNh", "dGlvbi52MS5HZW5lcmF0ZVdlYkNyZWRlbnRpYWxzUmVzcG9uc2UiBoL5KwII", "CBo9gvkrMwoxYm5ldC5wcm90b2NvbC5hdXRoZW50aWNhdGlvbi5BdXRoZW50", "aWNhdGlvblNlcnZlcor5KwIQAUIFSAGAAQA="
			}));
			AuthenticationServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AccountTypesReflection.Descriptor,
				ContentHandleTypesReflection.Descriptor,
				EntityTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(ModuleLoadRequest), ModuleLoadRequest.Parser, new string[] { "ModuleHandle", "Message" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ModuleNotification), ModuleNotification.Parser, new string[] { "ModuleId", "Result" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ModuleMessageRequest), ModuleMessageRequest.Parser, new string[] { "ModuleId", "Message" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LogonRequest), LogonRequest.Parser, new string[]
				{
					"Program", "Platform", "Locale", "Email", "Version", "ApplicationVersion", "PublicComputer", "AllowLogonQueueNotifications", "WebClientVerification", "CachedWebCredentials",
					"UserAgent", "DeviceId", "PhoneNumber"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LogonResult), LogonResult.Parser, new string[]
				{
					"ErrorCode", "AccountId", "GameAccountId", "Email", "AvailableRegion", "ConnectedRegion", "BattleTag", "GeoipCountry", "SessionKey", "RestrictedMode",
					"ClientId"
				}, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GenerateSSOTokenRequest), GenerateSSOTokenRequest.Parser, new string[] { "Program" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GenerateSSOTokenResponse), GenerateSSOTokenResponse.Parser, new string[] { "SsoId", "SsoSecret" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LogonUpdateRequest), LogonUpdateRequest.Parser, new string[] { "ErrorCode" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(LogonQueueUpdateRequest), LogonQueueUpdateRequest.Parser, new string[] { "Position", "EstimatedTime", "EtaDeviationInSec" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(AccountSettingsNotification), AccountSettingsNotification.Parser, new string[] { "Licenses", "IsUsingRid", "IsPlayingFromIgr", "CanReceiveVoice", "CanSendVoice" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(ServerStateChangeRequest), ServerStateChangeRequest.Parser, new string[] { "State", "EventTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(VersionInfo), VersionInfo.Parser, new string[] { "Number", "Patch", "IsOptional", "KickTime" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(VersionInfoNotification), VersionInfoNotification.Parser, new string[] { "VersionInfo" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemModuleLoadRequest), MemModuleLoadRequest.Parser, new string[] { "Handle", "Key", "Input" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MemModuleLoadResponse), MemModuleLoadResponse.Parser, new string[] { "Data" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SelectGameAccountRequest), SelectGameAccountRequest.Parser, new string[] { "GameAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GameAccountSelectedRequest), GameAccountSelectedRequest.Parser, new string[] { "Result", "GameAccountId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GenerateWebCredentialsRequest), GenerateWebCredentialsRequest.Parser, new string[] { "Program" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GenerateWebCredentialsResponse), GenerateWebCredentialsResponse.Parser, new string[] { "WebCredentials" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(VerifyWebCredentialsRequest), VerifyWebCredentialsRequest.Parser, new string[] { "WebCredentials" }, null, null, null, null)
			}));
		}

		// Token: 0x04004108 RID: 16648
		private static FileDescriptor descriptor;
	}
}
