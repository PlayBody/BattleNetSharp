using System;
using Bgs.Protocol.Account.V1;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V1
{
	// Token: 0x0200052E RID: 1326
	public static class SessionServiceReflection
	{
		// Token: 0x170028A2 RID: 10402
		// (get) Token: 0x0600806B RID: 32875 RVA: 0x001F3D64 File Offset: 0x001F1F64
		public static FileDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.descriptor;
			}
		}

		// Token: 0x0600806C RID: 32876 RVA: 0x001F3D7C File Offset: 0x001F1F7C
		static SessionServiceReflection()
		{
			byte[] array = Convert.FromBase64String(string.Concat(new string[]
			{
				"CidiZ3MvbG93L3BiL2NsaWVudC9zZXNzaW9uX3NlcnZpY2UucHJvdG8SF2Jn", "cy5wcm90b2NvbC5zZXNzaW9uLnYxGiViZ3MvbG93L3BiL2NsaWVudC9hY2Nv", "dW50X3R5cGVzLnByb3RvGiFiZ3MvbG93L3BiL2NsaWVudC9ycGNfdHlwZXMu", "cHJvdG8aJWJncy9sb3cvcGIvY2xpZW50L3Nlc3Npb25fdHlwZXMucHJvdG8i", "vgIKFENyZWF0ZVNlc3Npb25SZXF1ZXN0EjMKCGlkZW50aXR5GAEgASgLMiEu", "YmdzLnByb3RvY29sLmFjY291bnQudjEuSWRlbnRpdHkSEAoIcGxhdGZvcm0Y", "AiABKAcSDgoGbG9jYWxlGAMgASgHEhYKDmNsaWVudF9hZGRyZXNzGAQgASgJ", "EhsKE2FwcGxpY2F0aW9uX3ZlcnNpb24YBSABKAUSEgoKdXNlcl9hZ2VudBgG", "IAEoCRITCgtzZXNzaW9uX2tleRgHIAEoDBI4CgdvcHRpb25zGAggASgLMicu", "YmdzLnByb3RvY29sLnNlc3Npb24udjEuU2Vzc2lvbk9wdGlvbnMSIgoTcmVx",
				"dWlyZXNfbWFya19hbGl2ZRgJIAEoCDoFZmFsc2USEwoLbWFjX2FkZHJlc3MY", "CiABKAkiPgoVQ3JlYXRlU2Vzc2lvblJlc3BvbnNlEhIKCnNlc3Npb25faWQY", "ASABKAkSEQoJdGltZW91dF9zGAIgASgNIpkBChRVcGRhdGVTZXNzaW9uUmVx", "dWVzdBIzCghpZGVudGl0eRgBIAEoCzIhLmJncy5wcm90b2NvbC5hY2NvdW50", "LnYxLklkZW50aXR5EjgKB29wdGlvbnMYAiABKAsyJy5iZ3MucHJvdG9jb2wu", "c2Vzc2lvbi52MS5TZXNzaW9uT3B0aW9ucxISCgpzZXNzaW9uX2lkGAMgASgJ", "ImAKFURlc3Ryb3lTZXNzaW9uUmVxdWVzdBIzCghpZGVudGl0eRgBIAEoCzIh", "LmJncy5wcm90b2NvbC5hY2NvdW50LnYxLklkZW50aXR5EhIKCnNlc3Npb25f", "aWQYAiABKAkiGwoZR2V0U2Vzc2lvbkNhcGFjaXR5UmVxdWVzdCJUChpHZXRT", "ZXNzaW9uQ2FwYWNpdHlSZXNwb25zZRIaChJzZXNzaW9uc19hdmFpbGFibGUY",
				"ASABKA0SGgoSdGltZV9mcmFtZV9zZWNvbmRzGAIgASgNIq0BCiJHZXRTZXNz", "aW9uU3RhdGVCeUJlbmVmYWN0b3JSZXF1ZXN0EkUKEWJlbmVmYWN0b3JfaGFu", "ZGxlGAEgASgLMiouYmdzLnByb3RvY29sLmFjY291bnQudjEuR2FtZUFjY291", "bnRIYW5kbGUSJwoYaW5jbHVkZV9iaWxsaW5nX2Rpc2FibGVkGAIgASgIOgVm", "YWxzZRIXCg9iZW5lZmFjdG9yX3V1aWQYAyABKAkiwwEKI0dldFNlc3Npb25T", "dGF0ZUJ5QmVuZWZhY3RvclJlc3BvbnNlEkkKEWJlbmVmYWN0b3JfaGFuZGxl", "GAEgASgLMiouYmdzLnByb3RvY29sLmFjY291bnQudjEuR2FtZUFjY291bnRI", "YW5kbGVCAhgBEjYKB3Nlc3Npb24YAiADKAsyJS5iZ3MucHJvdG9jb2wuc2Vz", "c2lvbi52MS5TZXNzaW9uU3RhdGUSGQoRbWludXRlc19yZW1haW5pbmcYAyAB", "KA0iVwoYTWFya1Nlc3Npb25zQWxpdmVSZXF1ZXN0EjsKB3Nlc3Npb24YASAD",
				"KAsyKi5iZ3MucHJvdG9jb2wuc2Vzc2lvbi52MS5TZXNzaW9uSWRlbnRpZmll", "ciJfChlNYXJrU2Vzc2lvbnNBbGl2ZVJlc3BvbnNlEkIKDmZhaWxlZF9zZXNz", "aW9uGAEgAygLMiouYmdzLnByb3RvY29sLnNlc3Npb24udjEuU2Vzc2lvbklk", "ZW50aWZpZXIifQoWR2V0U2Vzc2lvblN0YXRlUmVxdWVzdBI6CgZoYW5kbGUY", "ASABKAsyKi5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5HYW1lQWNjb3VudEhh", "bmRsZRInChhpbmNsdWRlX2JpbGxpbmdfZGlzYWJsZWQYAiABKAg6BWZhbHNl", "IpEBChdHZXRTZXNzaW9uU3RhdGVSZXNwb25zZRI+CgZoYW5kbGUYASABKAsy", "Ki5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5HYW1lQWNjb3VudEhhbmRsZUIC", "GAESNgoHc2Vzc2lvbhgCIAEoCzIlLmJncy5wcm90b2NvbC5zZXNzaW9uLnYx", "LlNlc3Npb25TdGF0ZSJcChxHZXRTaWduZWRTZXNzaW9uU3RhdGVSZXF1ZXN0",
				"EjwKCGFnZW50X2lkGAEgASgLMiouYmdzLnByb3RvY29sLmFjY291bnQudjEu", "R2FtZUFjY291bnRIYW5kbGUiLgodR2V0U2lnbmVkU2Vzc2lvblN0YXRlUmVz", "cG9uc2USDQoFdG9rZW4YASABKAkiLwoYUmVmcmVzaFNlc3Npb25LZXlSZXF1", "ZXN0EhMKC3Nlc3Npb25fa2V5GAEgASgMIjAKGVJlZnJlc2hTZXNzaW9uS2V5", "UmVzcG9uc2USEwoLc2Vzc2lvbl9rZXkYASABKAwiVwoZR2V0R2FtZVNlc3Np", "b25JbmZvUmVxdWVzdBI6CgZoYW5kbGUYASABKAsyKi5iZ3MucHJvdG9jb2wu", "YWNjb3VudC52MS5HYW1lQWNjb3VudEhhbmRsZSJcChpHZXRHYW1lU2Vzc2lv", "bkluZm9SZXNwb25zZRI+CgxzZXNzaW9uX2luZm8YASABKAsyKC5iZ3MucHJv", "dG9jb2wuc2Vzc2lvbi52MS5HYW1lU2Vzc2lvbkluZm8inQEKGlNlc3Npb25D", "cmVhdGVkTm90aWZpY2F0aW9uEjMKCGlkZW50aXR5GAEgASgLMiEuYmdzLnBy",
				"b3RvY29sLmFjY291bnQudjEuSWRlbnRpdHkSDgoGcmVhc29uGAIgASgNEhIK", "CnNlc3Npb25faWQYAyABKAkSEwoLc2Vzc2lvbl9rZXkYBCABKAwSEQoJY2xp", "ZW50X2lkGAUgASgJIo8BChxTZXNzaW9uRGVzdHJveWVkTm90aWZpY2F0aW9u", "EjMKCGlkZW50aXR5GAEgASgLMiEuYmdzLnByb3RvY29sLmFjY291bnQudjEu", "SWRlbnRpdHkSDgoGcmVhc29uGAIgASgNEhIKCnNlc3Npb25faWQYAyABKAkS", "FgoOcmVhc29uX2RldGFpbHMYBCABKA0idQoaU2Vzc2lvblVwZGF0ZWROb3Rp", "ZmljYXRpb24SMwoIaWRlbnRpdHkYASABKAsyIS5iZ3MucHJvdG9jb2wuYWNj", "b3VudC52MS5JZGVudGl0eRIOCgZyZWFzb24YAiABKA0SEgoKc2Vzc2lvbl9p", "ZBgDIAEoCSKsAQoiU2Vzc2lvbkdhbWVUaW1lV2FybmluZ05vdGlmaWNhdGlv", "bhIzCghpZGVudGl0eRgBIAEoCzIhLmJncy5wcm90b2NvbC5hY2NvdW50LnYx",
				"LklkZW50aXR5EhIKCnNlc3Npb25faWQYAiABKAkSIwobcmVtYWluaW5nX3Rp", "bWVfZHVyYXRpb25fbWluGAMgASgNEhgKEHJlc3RyaWN0aW9uX3R5cGUYBCAB", "KA0isgEKH1Nlc3Npb25RdWV1ZVVwZGF0ZWROb3RpZmljYXRpb24SMwoIaWRl", "bnRpdHkYASABKAsyIS5iZ3MucHJvdG9jb2wuYWNjb3VudC52MS5JZGVudGl0", "eRISCgpzZXNzaW9uX2lkGAIgASgJEhAKCHBvc2l0aW9uGAMgASgNEhwKFGF2", "Z19jcmVhdGlvbl90aW1lX21zGAQgASgEEhYKDnF1ZXVlZF90aW1lX21zGAUg", "ASgEInYKG1Nlc3Npb25RdWV1ZUVuZE5vdGlmaWNhdGlvbhIzCghpZGVudGl0", "eRgBIAEoCzIhLmJncy5wcm90b2NvbC5hY2NvdW50LnYxLklkZW50aXR5EhIK", "CnNlc3Npb25faWQYAiABKAkSDgoGcmVhc29uGAMgASgNMogECg9TZXNzaW9u", "TGlzdGVuZXISagoQT25TZXNzaW9uQ3JlYXRlZBIzLmJncy5wcm90b2NvbC5z",
				"ZXNzaW9uLnYxLlNlc3Npb25DcmVhdGVkTm90aWZpY2F0aW9uGhkuYmdzLnBy", "b3RvY29sLk5PX1JFU1BPTlNFIgaC+SsCCAESbgoST25TZXNzaW9uRGVzdHJv", "eWVkEjUuYmdzLnByb3RvY29sLnNlc3Npb24udjEuU2Vzc2lvbkRlc3Ryb3ll", "ZE5vdGlmaWNhdGlvbhoZLmJncy5wcm90b2NvbC5OT19SRVNQT05TRSIGgvkr", "AggCEmoKEE9uU2Vzc2lvblVwZGF0ZWQSMy5iZ3MucHJvdG9jb2wuc2Vzc2lv", "bi52MS5TZXNzaW9uVXBkYXRlZE5vdGlmaWNhdGlvbhoZLmJncy5wcm90b2Nv", "bC5OT19SRVNQT05TRSIGgvkrAggDEnoKGE9uU2Vzc2lvbkdhbWVUaW1lV2Fy", "bmluZxI7LmJncy5wcm90b2NvbC5zZXNzaW9uLnYxLlNlc3Npb25HYW1lVGlt", "ZVdhcm5pbmdOb3RpZmljYXRpb24aGS5iZ3MucHJvdG9jb2wuTk9fUkVTUE9O", "U0UiBoL5KwIIBBoxgvkrJwolYm5ldC5wcm90b2NvbC5zZXNzaW9uLlNlc3Np",
				"b25MaXN0ZW5lcor5KwIIATK8CQoOU2Vzc2lvblNlcnZpY2USdgoNQ3JlYXRl", "U2Vzc2lvbhItLmJncy5wcm90b2NvbC5zZXNzaW9uLnYxLkNyZWF0ZVNlc3Np", "b25SZXF1ZXN0Gi4uYmdzLnByb3RvY29sLnNlc3Npb24udjEuQ3JlYXRlU2Vz", "c2lvblJlc3BvbnNlIgaC+SsCCAESXgoORGVzdHJveVNlc3Npb24SLi5iZ3Mu", "cHJvdG9jb2wuc2Vzc2lvbi52MS5EZXN0cm95U2Vzc2lvblJlcXVlc3QaFC5i", "Z3MucHJvdG9jb2wuTm9EYXRhIgaC+SsCCAISXAoNVXBkYXRlU2Vzc2lvbhIt", "LmJncy5wcm90b2NvbC5zZXNzaW9uLnYxLlVwZGF0ZVNlc3Npb25SZXF1ZXN0", "GhQuYmdzLnByb3RvY29sLk5vRGF0YSIGgvkrAggFEoUBChJHZXRTZXNzaW9u", "Q2FwYWNpdHkSMi5iZ3MucHJvdG9jb2wuc2Vzc2lvbi52MS5HZXRTZXNzaW9u", "Q2FwYWNpdHlSZXF1ZXN0GjMuYmdzLnByb3RvY29sLnNlc3Npb24udjEuR2V0",
				"U2Vzc2lvbkNhcGFjaXR5UmVzcG9uc2UiBoL5KwIIBhKgAQobR2V0U2Vzc2lv", "blN0YXRlQnlCZW5lZmFjdG9yEjsuYmdzLnByb3RvY29sLnNlc3Npb24udjEu", "R2V0U2Vzc2lvblN0YXRlQnlCZW5lZmFjdG9yUmVxdWVzdBo8LmJncy5wcm90", "b2NvbC5zZXNzaW9uLnYxLkdldFNlc3Npb25TdGF0ZUJ5QmVuZWZhY3RvclJl", "c3BvbnNlIgaC+SsCCAcSggEKEU1hcmtTZXNzaW9uc0FsaXZlEjEuYmdzLnBy", "b3RvY29sLnNlc3Npb24udjEuTWFya1Nlc3Npb25zQWxpdmVSZXF1ZXN0GjIu", "YmdzLnByb3RvY29sLnNlc3Npb24udjEuTWFya1Nlc3Npb25zQWxpdmVSZXNw", "b25zZSIGgvkrAggIEnwKD0dldFNlc3Npb25TdGF0ZRIvLmJncy5wcm90b2Nv", "bC5zZXNzaW9uLnYxLkdldFNlc3Npb25TdGF0ZVJlcXVlc3QaMC5iZ3MucHJv", "dG9jb2wuc2Vzc2lvbi52MS5HZXRTZXNzaW9uU3RhdGVSZXNwb25zZSIGgvkr",
				"AggJEo4BChVHZXRTaWduZWRTZXNzaW9uU3RhdGUSNS5iZ3MucHJvdG9jb2wu", "c2Vzc2lvbi52MS5HZXRTaWduZWRTZXNzaW9uU3RhdGVSZXF1ZXN0GjYuYmdz", "LnByb3RvY29sLnNlc3Npb24udjEuR2V0U2lnbmVkU2Vzc2lvblN0YXRlUmVz", "cG9uc2UiBoL5KwIIChKCAQoRUmVmcmVzaFNlc3Npb25LZXkSMS5iZ3MucHJv", "dG9jb2wuc2Vzc2lvbi52MS5SZWZyZXNoU2Vzc2lvbktleVJlcXVlc3QaMi5i", "Z3MucHJvdG9jb2wuc2Vzc2lvbi52MS5SZWZyZXNoU2Vzc2lvbktleVJlc3Bv", "bnNlIgaC+SsCCAsaMIL5KyYKJGJuZXQucHJvdG9jb2wuc2Vzc2lvbi5TZXNz", "aW9uU2VydmljZYr5KwIQAUIFSAGAAQA="
			}));
			SessionServiceReflection.descriptor = FileDescriptor.FromGeneratedCode(array, new FileDescriptor[]
			{
				AccountTypesReflection.Descriptor,
				RpcTypesReflection.Descriptor,
				SessionTypesReflection.Descriptor
			}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(CreateSessionRequest), CreateSessionRequest.Parser, new string[] { "Identity", "Platform", "Locale", "ClientAddress", "ApplicationVersion", "UserAgent", "SessionKey", "Options", "RequiresMarkAlive", "MacAddress" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(CreateSessionResponse), CreateSessionResponse.Parser, new string[] { "SessionId", "TimeoutS" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(UpdateSessionRequest), UpdateSessionRequest.Parser, new string[] { "Identity", "Options", "SessionId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(DestroySessionRequest), DestroySessionRequest.Parser, new string[] { "Identity", "SessionId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetSessionCapacityRequest), GetSessionCapacityRequest.Parser, null, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetSessionCapacityResponse), GetSessionCapacityResponse.Parser, new string[] { "SessionsAvailable", "TimeFrameSeconds" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetSessionStateByBenefactorRequest), GetSessionStateByBenefactorRequest.Parser, new string[] { "BenefactorHandle", "IncludeBillingDisabled", "BenefactorUuid" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetSessionStateByBenefactorResponse), GetSessionStateByBenefactorResponse.Parser, new string[] { "BenefactorHandle", "Session", "MinutesRemaining" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MarkSessionsAliveRequest), MarkSessionsAliveRequest.Parser, new string[] { "Session" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(MarkSessionsAliveResponse), MarkSessionsAliveResponse.Parser, new string[] { "FailedSession" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetSessionStateRequest), GetSessionStateRequest.Parser, new string[] { "Handle", "IncludeBillingDisabled" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetSessionStateResponse), GetSessionStateResponse.Parser, new string[] { "Handle", "Session" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetSignedSessionStateRequest), GetSignedSessionStateRequest.Parser, new string[] { "AgentId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetSignedSessionStateResponse), GetSignedSessionStateResponse.Parser, new string[] { "Token" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RefreshSessionKeyRequest), RefreshSessionKeyRequest.Parser, new string[] { "SessionKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(RefreshSessionKeyResponse), RefreshSessionKeyResponse.Parser, new string[] { "SessionKey" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetGameSessionInfoRequest), GetGameSessionInfoRequest.Parser, new string[] { "Handle" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(GetGameSessionInfoResponse), GetGameSessionInfoResponse.Parser, new string[] { "SessionInfo" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SessionCreatedNotification), SessionCreatedNotification.Parser, new string[] { "Identity", "Reason", "SessionId", "SessionKey", "ClientId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SessionDestroyedNotification), SessionDestroyedNotification.Parser, new string[] { "Identity", "Reason", "SessionId", "ReasonDetails" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SessionUpdatedNotification), SessionUpdatedNotification.Parser, new string[] { "Identity", "Reason", "SessionId" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SessionGameTimeWarningNotification), SessionGameTimeWarningNotification.Parser, new string[] { "Identity", "SessionId", "RemainingTimeDurationMin", "RestrictionType" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SessionQueueUpdatedNotification), SessionQueueUpdatedNotification.Parser, new string[] { "Identity", "SessionId", "Position", "AvgCreationTimeMs", "QueuedTimeMs" }, null, null, null, null),
				new GeneratedClrTypeInfo(typeof(SessionQueueEndNotification), SessionQueueEndNotification.Parser, new string[] { "Identity", "SessionId", "Reason" }, null, null, null, null)
			}));
		}

		// Token: 0x04003A4A RID: 14922
		private static FileDescriptor descriptor;
	}
}
